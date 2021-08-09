using AutoMapper;
using Datatable.Models;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Persistence;
using InventoryManagement.Persistence.UnitOfWork;
using InventoryManagement.Service.Dto;
using InventoryManagement.Service.Dto.Product;
using InventoryManagement.Service.Dto.Transaction;
using Microsoft.EntityFrameworkCore;
using Service.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Implementation
{
    public interface ITransactionService:IBaseCrudService<Transaction,long, TransactionDto, TransactionDto, TransactionDto, TransactionFilterDto>
    {
        Task<ServiceResponse> NewPurchaseTransaction(PurchaseTransactionDto model);
        Task<ServiceResponse> NewSaleTransaction(SaleTransactionDto model);
        Task<PagedResponse> GetAllFilteredddl(GetAllRequest<Transaction, TransactionFilterDto> request);
        DtPagingResponse<TransactionLitsDto> GetDataTablePaggedList(PagingRequest paging);
    }


    public class TransactionService: BaseCrudService<Transaction, long, TransactionDto, TransactionDto, TransactionDto, TransactionFilterDto>, ITransactionService
    {
        private readonly IUnitOfWork<Transaction, long> _uow;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext db;

        public TransactionService(IUnitOfWork<Transaction, long> uow,IMapper mapper,ApplicationDbContext db) :base (uow,mapper)
        {
            _uow = uow;
           _mapper = mapper;
            this.db = db;
        }
 

        public   async Task<ServiceResponse> NewPurchaseTransaction(PurchaseTransactionDto model)
        {
            var transaction = new Transaction(Domain.Enum.TransactionType.Purchase, model.PartnerId,model.TransactionDate);

            if (model._TransactionLines?.Count >0)
            {
                foreach (var dtl in model._TransactionLines)
                {
                     var product =await _uow._productRepo.FirstOrDefaultAsync(s=>s.Id== dtl.ProductId, "", true);

                    var Trxline = _mapper.Map<TransactionLine>(dtl);
                    Trxline.Product = product;
                    transaction.AddPurchaseTransactionLine(Trxline);



                   // mapped.AddProductDetails(mappedDtl);
                }
            }

            var _entity = _uow.Repository.AddAsync(transaction);
            var res = _uow.Complete();
            await Task.WhenAll(_entity, res);
            return new ServiceResponse { Success = true, Data = transaction };
        }

         public   async Task<ServiceResponse> NewSaleTransaction(SaleTransactionDto model)
        {
            var transaction = new Transaction(Domain.Enum.TransactionType.Sales, model.PartnerId,model.TransactionDate);

            if (model._TransactionLines?.Count >0)
            {
                foreach (var dtl in model._TransactionLines)
                {
                     var product =await _uow._productRepo.FirstOrDefaultAsync(s=>s.Id== dtl.ProductId, "", true);

                    var mappedline = _mapper.Map<TransactionLine>(dtl);
                           mappedline.Product = product;
                    transaction.AddSaleTransactionLine(mappedline);
                }
            }
            
            var _entity = _uow.Repository.AddAsync(transaction);
            var res = _uow.Complete();
            await Task.WhenAll(_entity, res);
            return new ServiceResponse { Success = true, Data = transaction };
        }


        public async Task<PagedResponse> GetAllFilteredddl(GetAllRequest<Transaction, TransactionFilterDto> request)
        {
 
              var res=  db.Transactions.Include(s => s.TransactionLines)
              .ThenInclude(s => s.Product)
              .Include(s => s.Partner)
              .Skip((request.PageSize * request.PageNumber)).Take(request.PageSize);

            var PaggedData = await res.ToListAsync();

            var mapped = _mapper.Map<List<TransactionDto>>(PaggedData);
            var returnModel = new PagedResponse(mapped, request.PageNumber, res.Count(), request.PageSize, request.Search);



            return returnModel;
             // return await base.GetAllFiltered(request);
        }

 
        public DtPagingResponse<TransactionLitsDto> GetDataTablePaggedList( PagingRequest paging)
       {
       //     var data = _uow.Repository.GetAll(null,"Partner,TransactionLines").MapToDataTable(paging);
            var data = db.Transactions.Include(s=>s.Partner).Include(s=>s.TransactionLines)
                              .ThenInclude(s=>s.Product)
                
                //_uow.Repository.GetAllIncluding(s=>s.Partner   )
                
                //.theninclude
                .MapToDataTable(paging);

            var x1=_mapper.Map<DtPagingResponse<TransactionDto>>(data);
            var x2=_mapper.Map<DtPagingResponse<TransactionLitsDto>>(data);

            return _mapper.Map<DtPagingResponse<TransactionLitsDto>>(data);
        }





        //public override async Task<ServiceResponse> UpdateAsync(ProductDto model, long Id)
        //{
        //    var current = await _uow.Repository.FirstOrDefaultAsync(s=>s.Id== model.Id, "ProductDetails",true);
        //    var mapped = _mapper.Map(model, current);
        //    if (model._productDetails?.Count > 0)
        //    {

        //        var deletedItems = model._productDetails.Where(s => s.rowStatus == "delete");
        //        if (deletedItems?.Count()>0)
        //        {
        //             var mappedDtl = _mapper.Map<List< ProductDetails>>(deletedItems);
        //            mapped.RemoveProductDetails(mappedDtl);
        //        }

        //        var UpdateItems = model._productDetails.Where(s => s.rowStatus == "Update");
        //        if (UpdateItems?.Count() > 0)
        //        {
        //            var mappedDtl = _mapper.Map<List<ProductDetails>>(UpdateItems);
        //            mapped.UpdateProductDetails(mappedDtl);
        //        }


        //        var CreateItems = model._productDetails.Where(s => s.rowStatus == "Create");
        //        if (CreateItems?.Count() > 0)
        //        {
        //            var mappedDtl = _mapper.Map<List<ProductDetails>>(CreateItems);
        //            mapped.AddProductDetails(mappedDtl);
        //        }


        //        //foreach (var dtl in model._productDetails)
        //        //{
        //        //    var mappedDtl = _mapper.Map<ProductDetails>(dtl);
        //        //    mapped.UpdateProductDetails(mappedDtl);
        //        //}
        //    }
        //    _uow.Repository.Update(mapped);
        //    var res = await _uow.Complete();
        //    return new ServiceResponse { Success = res };
        //}


        //public override async Task<ServiceResponse> GetById(long id) 
        //{
        //    return await base.FindFirstOrDefaultAsync(s=>s.Id==id, "ProductDetails,ProductCategory,Warehouse,WarehouseBin");
        //}




    }
}
