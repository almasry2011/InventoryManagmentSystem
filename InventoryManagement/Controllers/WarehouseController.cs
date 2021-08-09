
using AutoMapper;
using Datatable.Models;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Persistence;
using InventoryManagement.Persistence.UnitOfWork;
using InventoryManagement.Service.Dto;
using InventoryManagement.Service.Dto.Warehouse;
using InventoryManagement.Service.Implementation;
using LinqKit;
using Microsoft.AspNetCore.Mvc;
using Service.Extensions;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
   // [Authorize]
    [ApiController]
    [Route("api/v{version:apiVersion}/Warehouse")]
    [ApiVersion("1.0")]
    public class WarehouseController : BaseAppService<Warehouse,long,WarehouseDto, WarehouseDto, WarehouseDto, WarehouseFilterDto>  //: ControllerBase
    {
        private readonly IBaseCrudService<Warehouse, long, WarehouseDto, WarehouseDto, WarehouseDto, WarehouseFilterDto> _baseSvc;
        private readonly IUnitOfWork<Warehouse, long> _uow;
        private readonly IMapper _mapper;

        public WarehouseController(ApplicationDbContext db, IBaseCrudService<Warehouse, long, WarehouseDto, WarehouseDto, WarehouseDto, WarehouseFilterDto> baseSvc,IUnitOfWork<Warehouse,long> uow,IMapper mapper ):base(baseSvc)
        {
            _baseSvc = baseSvc;
            _uow = uow;
          _mapper = mapper;
        }

        [HttpPost]
       [Route("GetAllFiltered")]
        public override Task<IActionResult> GetAllFiltered(GetAllRequest<Warehouse, WarehouseFilterDto> request)
        {
            request.predicate = BuildSearchPredicate(request.Filter, request.Search);
            request.includeProperties = "Bins,Products";
            return base.GetAllFiltered(request);
        }

        public override async Task<IActionResult> GetById(long id)
        {
            var res = await _baseSvc.FindFirstOrDefaultAsync(s => s.Id == id, "Bins,Products");
            var MappingResult = new ServiceResponse
            {
                Success = true,
                Data = _mapper.Map<WarehouseDto>(res.Data)
            };



            return Ok(MappingResult);
        }


        public override async Task<IActionResult> Create(WarehouseDto model)
        {
            var mapped = _mapper.Map<Warehouse>(model);
            foreach (var bin in model.Bins)
            {
                mapped.AddWarehouseBin(bin.Name, bin.SerialNumber, bin.Color, bin.Width, bin.Depth, bin.Height, bin.DividerSlots, bin.Weight);
            }
            var _entity = _uow.Repository.AddAsync(mapped);
            var res = _uow.Complete();
            await Task.WhenAll(_entity, res);
            return Ok(new ServiceResponse { Success = true, Data = mapped.Id }) ;
        }


        public override async Task<IActionResult> Update(WarehouseDto model, long id)
        {

            var current = await _uow._warehouseRepo.FirstOrDefaultAsync(s=>s.Id==id, "Bins,Products");
           // var current = await _uow._warehouseRepo.FirstOrDefaultAsync(s=>s.Id==id,"");
          var mapped = _mapper.Map(model, current);

            var deletedItems = current.Bins.Where(p => model.Bins.All(p2 => p2.Id != p.Id));
            _uow._binRepo.RemoveRange(deletedItems);

            foreach (var bin in model.Bins)
            {
                if (!deletedItems.Any(s => s.Id == bin.Id))
                {
                    if (bin.Id > 0)
                    {
                        mapped.UpdateWarehouseBin(bin.Name, bin.SerialNumber, bin.Color, bin.Width, bin.Depth, bin.Height, bin.DividerSlots, bin.Weight, bin.Id);
                    }
                    else
                    {
                        mapped.AddWarehouseBin(bin.Name, bin.SerialNumber, bin.Color, bin.Width, bin.Depth, bin.Height, bin.DividerSlots, bin.Weight);
                    }
                }
            }
           

            _uow._warehouseRepo.Update(mapped);
            var res = await _uow.Complete();
            return Ok(new ServiceResponse { Success = true, Data = mapped.Id });
        }

        [HttpPost]
        [Route("GetDataTablePaggedList")]
        public IActionResult GetDataTablePaggedList([FromBody] PagingRequest paging)
        {
            var data = _baseSvc.GetAllQuerable("Bins,Products").MapToDataTable(paging);
            var MappingResult = _mapper.Map<DtPagingResponse<WarehouseDto>>(data);
            return Ok(MappingResult);
        }

        private Expression<Func<Warehouse, bool>> BuildSearchPredicate(WarehouseFilterDto filter,string search)
        {
            var predicate = PredicateBuilder.New<Warehouse>(true); // Eq - Expression<Func<Warehouse, bool>> predicate = c => true;

            if (!string.IsNullOrEmpty(filter?.Name))
            {
                predicate.And(s => s.Name.Contains(filter.Name));
            } 
       
            if (!string.IsNullOrEmpty(search))
            {
                predicate.And(s => s.Name.Contains(search) || s.LocationAddress.ToString().Contains(search) );
            }

            return predicate;
        }

    }
}
