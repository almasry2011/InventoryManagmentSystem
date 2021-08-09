
using AutoMapper;
using Datatable.Models;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Persistence.UnitOfWork;
using InventoryManagement.Service.Dto;
using InventoryManagement.Service.Dto.Partner;
using InventoryManagement.Service.Implementation;
using LinqKit;
using Microsoft.AspNetCore.Mvc;
using Service.Extensions;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
   // [Authorize]
    [ApiController]
    [Route("api/v{version:apiVersion}/Partner")]
    [ApiVersion("1.0")]
    public class PartnerController : BaseAppService<Partner,long,PartnerDto, PartnerDto, PartnerDto, PartnerFilterDto>  
    {
        private readonly IBaseCrudService<Partner, long, PartnerDto, PartnerDto, PartnerDto, PartnerFilterDto> _baseSvc;
        private readonly IUnitOfWork<Partner, long> _uow;
        private readonly IMapper _mapper;

        public PartnerController(IBaseCrudService<Partner, long, PartnerDto, PartnerDto, PartnerDto, PartnerFilterDto> baseSvc,IUnitOfWork<Partner,long> uow,IMapper mapper ):base(baseSvc)
        {
            _baseSvc = baseSvc;
            _uow = uow;
          _mapper = mapper;
        }

        [HttpPost]
       [Route("GetAllFiltered")]
        public override Task<IActionResult> GetAllFiltered(GetAllRequest<Partner, PartnerFilterDto> request)
        {
            request.predicate = BuildSearchPredicate(request.Filter, request.Search);
            return base.GetAllFiltered(request);
        }

        [HttpPost]
        [Route("GetDataTablePaggedList")]
        public IActionResult GetDataTablePaggedList([FromBody] PagingRequest paging)
        {
            var data = _baseSvc.GetAllQuerable().MapToDataTable(paging);
            var MappingResult = _mapper.Map<DtPagingResponse<PartnerDto>>(data);
            return Ok(MappingResult);
        }
        private Expression<Func<Partner, bool>> BuildSearchPredicate(PartnerFilterDto filter,string search)
        {
            var predicate = PredicateBuilder.New<Partner>(true); // Eq - Expression<Func<Partner, bool>> predicate = c => true;

            if (!string.IsNullOrEmpty(filter?.Name))
            {
                predicate.And(s => s.Name.Contains(filter.Name));
            }   
            
            if (!string.IsNullOrEmpty(filter?.Address))
            {
                predicate.And(s => s.Address.ToString().Contains(filter.Address));
            }      

            if (!string.IsNullOrEmpty(filter?.Email))
            {
                predicate.And(s => s.Email==filter.Email);
            } 

            if (!string.IsNullOrEmpty(filter?.PhoneNumber))
            {
                predicate.And(s => s.PhoneNumber==filter.PhoneNumber);
            } 
       
            if (!string.IsNullOrEmpty(search))
            {
                predicate.And(s => s.Name.Contains(search) || s.Address.ToString().Contains(search) );
            }

            return predicate;
        }

    }
}
