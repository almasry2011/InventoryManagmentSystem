using AutoMapper;
using InventoryManagement.Domain;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Infrastructure.ViewModel;
using InventoryManagement.Service.Dto;

namespace InventoryManagement.Infrastructure.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {

            CreateMap(typeof(BaseEntity<>), typeof(EntityDto<>));

            //CreateMap<CustomerModel, Customer>()
            //    .ForMember(dest => dest.Id,
            //            opt => opt.MapFrom(src => src.CustomerId))
            //    .ReverseMap();
        }
    }
}
