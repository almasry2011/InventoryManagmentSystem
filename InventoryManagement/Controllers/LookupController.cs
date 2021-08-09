
using AutoMapper;
using Datatable.Models;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Persistence.UnitOfWork;
using InventoryManagement.Service.Dto;
using InventoryManagement.Service.Dto.Partner;
using InventoryManagement.Service.Implementation;
using LinqKit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
   // [Authorize]
    [ApiController]
    [Route("api/v{version:apiVersion}")]
    [ApiVersion("1.0")]
    public class LookupController : ControllerBase  
    {
        private readonly IUnitOfWork<Partner, long> _uow;
        private readonly IMapper _mapper;

        public LookupController( IUnitOfWork<Partner,long> uow,IMapper mapper )
        {
            _uow = uow;
           _mapper = mapper;
        }

        [HttpPost]
        [Route("GetFilteredWarehouseBins")]
        public async   Task<IActionResult> GetFilteredWarehouseBins(GetAllRequest<Bin, long> request)
        {
          var querable =    _uow._binRepo.GetAll(s => s.WarehouseId == request.Filter) ;

 
            var PaggedData = await querable.Skip((request.PageSize * request.PageNumber)).Take(request.PageSize).ToListAsync();

            var mapped = _mapper.Map<List<Bin>>(PaggedData);
           

            return Ok(new PagedResponse(mapped, request.PageNumber, querable.Count(), request.PageSize, request.Search));
        }

        [HttpPost]
        [Route("GetFilteredCategories")]
        public async Task<IActionResult> GetFilteredCategories(GetAllRequest<Category, Nullable<int>> request)
        {
            var querable = _uow._categoryRepo.GetAll();

            var PaggedData = await querable.Skip((request.PageSize * request.PageNumber)).Take(request.PageSize)
                .Select(s=>new Category {CategoryName=s.CategoryName,Id=s.Id }).ToListAsync();
            return Ok(new PagedResponse(PaggedData, request.PageNumber, querable.Count(), request.PageSize, request.Search));
        }
    }
}
