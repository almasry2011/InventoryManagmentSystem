using AutoMapper;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Persistence.UnitOfWork;
using InventoryManagement.Service.Dto;
using InventoryManagement.Service.Dto.Product;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Implementation
{
    public interface IProductService:IBaseCrudService<Product,long, ProductDto, ProductDto, ProductDto, ProductFilterDto>
    {
        Task<PagedResponse> GetAllFilteredddl(GetAllRequest<Product, ProductFilterDto> request);
    }


    public class ProductService: BaseCrudService<Product,long, ProductDto, ProductDto, ProductDto, ProductFilterDto>, IProductService
    {
        private readonly IUnitOfWork<Product, long> _uow;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork<Product,long> uow,IMapper mapper) :base (uow,mapper)
        {
            _uow = uow;
           _mapper = mapper;
        }

        public override async Task<ServiceResponse> CreateAsync(ProductDto model)
        {
            var mapped = _mapper.Map<Product>(model);
            //if (model._productDetails?.Count >0)
            //{
            //    foreach (var dtl in model._productDetails)
            //    {
            //        var mappedDtl = _mapper.Map<ProductDetails>(dtl);
            //     //   mapped.AddProductDetails(mappedDtl);
            //    }
            //}

            var _entity = _uow.Repository.AddAsync(mapped);
            var res = _uow.Complete();
            await Task.WhenAll(_entity, res);
            return new ServiceResponse { Success = true, Data = mapped };
        }

 
        public override async Task<ServiceResponse> UpdateAsync(ProductDto model, long Id)
        {
            var current = await _uow.Repository.FirstOrDefaultAsync(s=>s.Id== model.Id, "ProductDetails",true);
            var mapped = _mapper.Map(model, current);
         
            //if (model._productDetails?.Count > 0)
            //{
                
            //    var deletedItems = model._productDetails.Where(s => s.rowStatus == "delete");
            //    if (deletedItems?.Count()>0)
            //    {
            //         var mappedDtl = _mapper.Map<List< ProductDetails>>(deletedItems);
            //       // mapped.RemoveProductDetails(mappedDtl);
            //    }

            //    var UpdateItems = model._productDetails.Where(s => s.rowStatus == "Update");
            //    if (UpdateItems?.Count() > 0)
            //    {
            //        var mappedDtl = _mapper.Map<List<ProductDetails>>(UpdateItems);
            //   //     mapped.UpdateProductDetails(mappedDtl);
            //    }


            //    var CreateItems = model._productDetails.Where(s => s.rowStatus == "Create");
            //    if (CreateItems?.Count() > 0)
            //    {
            //        var mappedDtl = _mapper.Map<List<ProductDetails>>(CreateItems);
            //       // mapped.AddProductDetails(mappedDtl);
            //    }


            //    //foreach (var dtl in model._productDetails)
            //    //{
            //    //    var mappedDtl = _mapper.Map<ProductDetails>(dtl);
            //    //    mapped.UpdateProductDetails(mappedDtl);
            //    //}
            //}


            _uow.Repository.Update(mapped);
            var res = await _uow.Complete();
            return new ServiceResponse { Success = res };
        }


        public override async Task<ServiceResponse> GetById(long id) 
        {
            return await base.FindFirstOrDefaultAsync(s=>s.Id==id, "ProductCategory,Warehouse,WarehouseBin");
        }

   
        public   async Task<PagedResponse > GetAllFilteredddl(GetAllRequest<Product, ProductFilterDto> request)
        {
            //request.includeProperties = "Product";
          //  var querable =  _uow._productRepo.GetAll(null, "ProductDetails");

       //var x   = await querable.Skip((request.PageSize * request.PageNumber))
       //          .Take(request.PageSize) .ToListAsync();


            // var paggedData = x.SelectMany(s => s.ProductDetails);

            // var data = paggedData.GroupBy(s => s.ProductId)
            //    .Select(group => group.OrderByDescending(student => student.ExpiryDate).FirstOrDefault());

            ///  var mapped = _mapper.Map<List<ProductDto>>(data);
            //   return new PagedResponse(mapped, request.PageNumber, querable.Count(), request.PageSize, request.Search);
            return await base.GetAllFiltered(request);
        }


    }
}
