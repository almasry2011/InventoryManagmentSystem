
using AutoMapper;
using Datatable.Models;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Persistence;
using InventoryManagement.Persistence.UnitOfWork;
using InventoryManagement.Service.Dto;
using InventoryManagement.Service.Dto.Transaction;
using InventoryManagement.Service.Implementation;
using LinqKit;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Service.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/Transaction")]
    [ApiVersion("1.0")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _trxSvc;
 
        public TransactionController(ITransactionService trxSvc)
        {
            _trxSvc = trxSvc;

        }


        [Route("PurchaseTransaction")]
        public async Task<IActionResult> ProcurementTransaction(PurchaseTransactionDto model)
        {
            var res = await _trxSvc.NewPurchaseTransaction(model);
            return Ok(res);
        }

        [Route("SaleTransaction")]
        public async Task<IActionResult> SaleTransaction(SaleTransactionDto model)
        {
            var res = await _trxSvc.NewSaleTransaction(model);
            return Ok(res);
        }


        [HttpPost]
        [Route("GetDataTablePaggedList")]
        public IActionResult GetDataTablePaggedList([FromBody] PagingRequest paging)
        {
            var data = _trxSvc.GetDataTablePaggedList(paging);
            return Ok(data);
        }


        //[HttpPost]
        //[Route("GetAllFiltered")]
        //public   async Task<IActionResult> GetAllFiltered(GetAllRequest<Transaction, TransactionFilterDto> request)
        //{

        //    var returnModel = await _trxSvc.GetAllFilteredddl(request);

        //    return Ok(returnModel);
        //}

        //[HttpPost]
        //[Route("SaleTransaction")]
        //public  async Task<IActionResult> SaleTransaction(TransactionCreateDto model)
        //{
        //    var transaction = new Transaction(Domain.Enum.TransactionType.Sales, model.PartnerId);

        //    foreach (var item in model._TransactionLines)
        //    {
        //        var productDtl =await _uow._productDetailsRepo.GetById(item.ProductId);
        //        transaction.AddTransactionLine(productDtl, item.Quantity);
        //    }

        //    var _entity = _uow.Repository.AddAsync(transaction);
        //    var res = _uow.Complete();
        //    await Task.WhenAll(_entity, res);
        //    return Ok(new ServiceResponse { Success = true });
        //}
        //[HttpPost]
        //[Route("PurchaseTransaction")]
        //public async Task<IActionResult> ProcurementTransaction(PurchaseTransactionDto  model)
        //{
        //    var transaction = new Transaction(Domain.Enum.TransactionType.Procurement, model.PartnerId);

        //    foreach (var item in model._TransactionLines)
        //    {
        //        var productDtl = await _uow._productDetailsRepo.GetById(item.ProductId);
        //        transaction.AddTransactionLine(productDtl, item.Quantity);
        //    }

        //    var _entity = _uow.Repository.AddAsync(transaction);
        //    var res = _uow.Complete();
        //    await Task.WhenAll(_entity, res);
        //    return Ok(new ServiceResponse { Success = true });
        //}



        //[HttpPost]
        //[Route("GetDataTablePaggedList")]
        //public IActionResult GetDataTablePaggedList([FromBody] PagingRequest paging)
        //{
        //    var data = _baseSvc.GetAllQuerable("Partner,TransactionLines").MapToDataTable(paging);
        //    var MappingResult = _mapper.Map<DtPagingResponse<TransactionDto>>(data);
        //    return Ok(MappingResult);
        //}





        //private Expression<Func<Transaction, bool>> BuildSearchPredicate(TransactionFilterDto filter,string search)
        //{
        //    var predicate = PredicateBuilder.New<Transaction>(true); 

        //    if (filter?.PartnerId != null )
        //    {
        //        predicate.And(s => s.PartnerId==filter.PartnerId);
        //    } 

        //    if (filter?.TransactionType!=null)
        //    {
        //        predicate.And(s => s.TransactionType==filter.TransactionType);
        //    } 


        //    return predicate;
        //}

    }
}
