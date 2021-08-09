using AutoMapper;
using InventoryManagement.Domain;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Persistence.Repository;
using InventoryManagement.Persistence.UnitOfWork;
using InventoryManagement.Service.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
 

namespace InventoryManagement.Service.Implementation
{
    public interface IBaseCrudService<Entity, PK, EntityDto, CreateDto, UpdateDto, FilterDto>
    {
        Task<ServiceResponse> CreateAsync(CreateDto model);
        Task<ServiceResponse> UpdateAsync(UpdateDto model, PK Id);
       Task<ServiceResponse> GetById(PK Id);
        Task<ServiceResponse> FindFirstOrDefaultAsync(Expression<Func<Entity, bool>> predicate, string includeProperties = null, bool tracked = false);
        Task<ServiceResponse> DeleteAsync(PK id);
        Task<PagedResponse> GetAllFiltered(GetAllRequest<Entity, FilterDto> request);
         IQueryable<Entity> GetAllQuerable(string includeProperties = null);
    }

    public class BaseCrudService<Entity, PK, EntityDto, CreateDto, UpdateDto, FilterDto> : IBaseCrudService<Entity, PK, EntityDto, CreateDto, UpdateDto, FilterDto> where Entity : class 
    {
        private readonly IUnitOfWork<Entity, PK> _uow;
        private readonly IMapper _mapper;

        public BaseCrudService(IUnitOfWork<Entity, PK> uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public virtual async Task<ServiceResponse> CreateAsync(CreateDto model)
        {
                var mapped = _mapper.Map<Entity>(model);
                var _entity = _uow.Repository.AddAsync(mapped);
                var res = _uow.Complete();
                await Task.WhenAll(_entity, res);
                return new ServiceResponse { Success = true, Data = mapped };
        }


        public virtual async Task<ServiceResponse> UpdateAsync(UpdateDto model,PK Id)
        {
            var current = await _uow.Repository.GetById(Id);
                var mapped = _mapper.Map( model, current);
         //       _uow.Repository.Update(mapped);
                _uow.Repository.Update(mapped);
                var res = await _uow.Complete();
                return new ServiceResponse { Success = res };
        }


        public virtual async Task<ServiceResponse> GetById(PK Id)
        {
                var result = await _uow.Repository.GetById(Id);
                var mapped = _mapper.Map<EntityDto>(result);

                return new ServiceResponse { Success = true, Data = mapped };

        }

        public virtual async Task<ServiceResponse> FindFirstOrDefaultAsync(Expression<Func<Entity, bool>> predicate, string includeProperties = null, bool tracked = false)
        {

                var result = await _uow.Repository.FirstOrDefaultAsync(predicate, includeProperties, tracked);
                var mapped = _mapper.Map<EntityDto>(result);

                return new ServiceResponse { Success = true, Data = mapped };
        }



        public virtual async Task<PagedResponse> GetAllFiltered(GetAllRequest<Entity, FilterDto> request)
        {

            var querable = _uow.Repository.GetAll(request.predicate, request.includeProperties, false);
            var PaggedData = await querable.Skip((request.PageSize * request.PageNumber)).Take(request.PageSize).ToListAsync();

            var mapped = _mapper.Map<List<EntityDto>>(PaggedData);
            return new PagedResponse(mapped, request.PageNumber, querable.Count(), request.PageSize, request.Search);
     
        }



        public virtual IQueryable<Entity> GetAllQuerable(string includeProperties = null)
        {
            return _uow.Repository.GetAll(null, includeProperties);
        }




        public virtual async Task<ServiceResponse> DeleteAsync(PK id)
        {
                  await _uow.Repository.Remove(id);
                  var res = await _uow.Complete();
            return new ServiceResponse { Success = true};

        }

 
 

    }
}
