
using InventoryManagement.Service.Dto;
using InventoryManagement.Service.Implementation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
    public class BaseAppService<Entity, PK, EntityDto, CreateDto, UpdateDto, FilterDto> : ControllerBase
    {
        private readonly IBaseCrudService<Entity, PK, EntityDto, CreateDto, UpdateDto, FilterDto> _baseSvc;

        public BaseAppService(IBaseCrudService<Entity, PK, EntityDto, CreateDto, UpdateDto, FilterDto> baseSvc)
        {
            _baseSvc = baseSvc;
        }
        [HttpPost]
        [Route("Create")]
        public virtual async Task<IActionResult> Create(CreateDto model)
        {
            return Ok(await _baseSvc.CreateAsync(model) );
        }

        [HttpPut]
        [Route("Update")]
        public virtual async Task<IActionResult> Update(UpdateDto model,PK id)
        {
            return Ok(await _baseSvc.UpdateAsync(model,id));
        }

        
        [HttpGet]
        [Route("")]
        public virtual async Task<IActionResult> GetAllFiltered(GetAllRequest<Entity, FilterDto> request)
        {
            return Ok(await _baseSvc.GetAllFiltered(request) );
           // return Ok(await _baseSvc.GetAllFiltered(filter,includeProperties) );
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById(PK id)
        {
            return Ok(await _baseSvc.GetById(id));
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(PK id)
        {
            return Ok(await _baseSvc.DeleteAsync(id));
        }

 
    }




  

}
