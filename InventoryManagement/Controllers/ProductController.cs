
using AutoMapper;
using Datatable.Models;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Service.Dto;
using InventoryManagement.Service.Dto.Product;
using InventoryManagement.Service.Dto.ProductCreate;
using InventoryManagement.Service.Dto.ProductUpdate;
using InventoryManagement.Service.Implementation;
using LinqKit;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Service.Extensions;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
   // [Authorize]
    [ApiController]
    [Route("api/v{version:apiVersion}/Product")]
    [ApiVersion("1.0")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _prodSvc;
        private readonly IMapper _mapper;
 
        public ProductController(IProductService prodSvc,IMapper mapper)
        {
            _prodSvc = prodSvc;
            _mapper = mapper;
        }
 
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(ProductDto model)
        {
            var res=  await  _prodSvc.CreateAsync(model);
            res.Data = null;
            return Ok(res);
        }

        [HttpPut]
        [Route("Update")]
        public  async Task<IActionResult> Update(ProductDto model, long id)
        {
 
            return Ok(await _prodSvc.UpdateAsync(model, id));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var res = await _prodSvc.GetById(id);
                //FindFirstOrDefaultAsync(s => s.Id == id, "ProductDetails,ProductCategory,Warehouse,WarehouseBin");
            return Ok(res);
        }


        [HttpPost]
        [Route("GetAllFiltered")]
        public async Task<IActionResult> GetAllFiltered(GetAllRequest<Product, ProductFilterDto> request)
        {
            request.predicate = BuildSearchPredicate(request.Filter, request.Search);
            request.includeProperties = "ProductCategory,Warehouse,WarehouseBin";
            return Ok(await _prodSvc.GetAllFiltered(request));


            //   return Ok(await _prodSvc.GetAllFilteredddl(request));
        }

        [HttpPost]
        [Route("GetDataTablePaggedList")]
        public IActionResult GetDataTablePaggedList([FromBody] PagingRequest paging)
        {
            var data = _prodSvc.GetAllQuerable("ProductCategory,Warehouse,WarehouseBin").MapToDataTable(paging);
            var MappingResult = _mapper.Map<DtPagingResponse<ProductDto>>(data);
            return Ok(MappingResult);
        }

        [HttpDelete("{id}")]
        public   async Task<IActionResult> Delete(long id)
        {
            return Ok(await _prodSvc.DeleteAsync(id));
        }

        //public ProductController(IBaseCrudService<Product, long, ProductDto, ProductCreateDto, ProductUpdateDto, ProductFilterDto> baseSvc,IMapper mapper):base(baseSvc)
        //{
        //    _baseSvc = baseSvc;
        //  _mapper = mapper;
        //}

        // [HttpPost]
        //[Route("GetAllFiltered")]
        // public  Task<IActionResult> GetAllFiltered(GetAllRequest<Product, ProductFilterDto> request)
        // {
        //     request.predicate = BuildSearchPredicate(request.Filter, request.Search);
        //     request.includeProperties = "ProductCategory,Warehouse,WarehouseBin";
        //     return base.GetAllFiltered(request);
        // }

        // public override async Task<IActionResult> GetById(long id)
        // {
        //    var res=await _baseSvc.FindFirstOrDefaultAsync(s => s.Id == id, "ProductCategory,Warehouse,WarehouseBin");
        //     var MappingResult = new ServiceResponse
        //     {
        //         Success = true,
        //         Data = _mapper.Map<ProductDto>(res.Data)
        //     };



        //     return Ok( MappingResult);
        // }

        //[HttpPost]
        //[Route("GetDataTablePaggedList")]
        //public IActionResult GetDataTablePaggedList([FromBody] PagingRequest paging)
        //{
        //    var data = _baseSvc.GetAllQuerable("ProductCategory,Warehouse,WarehouseBin").MapToDataTable(paging);
        //    var MappingResult = _mapper.Map<DtPagingResponse<ProductDto>>(data);
        //    return Ok(MappingResult);
        //}


        private Expression<Func<Product, bool>> BuildSearchPredicate(ProductFilterDto filter,string search)
        {
            var predicate = PredicateBuilder.New<Product>(true); // Eq - Expression<Func<Product, bool>> predicate = c => true;

            if (!string.IsNullOrEmpty(filter?.Name))
            {
                predicate.And(s => s.Name.Contains(filter.Name));
            } 
      
            //if (!string.IsNullOrEmpty(filter?.Code))
            //{
            //    predicate.And(s => s.ProductCode==filter.Code);
            //} 
            //if (filter?.Price!=null && filter?.Price > 0)
            //{
            //    predicate.And(s => s.UnitPrice==filter.Price);
            //}

            //if (!string.IsNullOrEmpty(search))
            //{
            //    predicate.And(s => s.Name.Contains(search) || s.Description.Contains(search) || s.ProductCategory.CategoryName.Contains(search));
            //}

            return predicate;
        }

    }
}
