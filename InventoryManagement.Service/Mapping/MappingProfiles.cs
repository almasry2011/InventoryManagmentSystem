using AutoMapper;
using Datatable.Models;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Domain.Enum;
using InventoryManagement.Service.Dto.Partner;
using InventoryManagement.Service.Dto.Product;
using InventoryManagement.Service.Dto.ProductCreate;
using InventoryManagement.Service.Dto.ProductUpdate;
using InventoryManagement.Service.Dto.Transaction;
using InventoryManagement.Service.Dto.Warehouse;
using System;
using System.Linq;

namespace InventoryManagement.Service.Mapping
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
             
            CreateMap(typeof(DtPagingResponse<>), typeof(DtPagingResponse<>));

            CreateMap<TransactionLine, SaleTransactionLineDto>().ReverseMap();
            CreateMap<TransactionLine, PurchaseTransactionLineDto>().ReverseMap();

            CreateMap<Product, ProductDto>()
               .ForMember(dest => dest.ProductCategoryStr, src => src.MapFrom(s => s.ProductCategory.CategoryName))
                .ForMember(dest => dest.WarehouseBinStr, src => src.MapFrom(s => s.WarehouseBin.Name))
                .ForMember(dest => dest.AvalableBoxs, src => src.MapFrom(s => s.CalculateStockToBoxs()))
                .ForMember(dest => dest.WarehouseStr, src => src.MapFrom(s => s.Warehouse.Name))
 


           .ForMember(dest => dest.SegmentalProfit, src => src.MapFrom(s => s.GetBoxProfit()))
         .ForMember(dest => dest.WholesaleProfit, src => src.MapFrom(s => s.GetUnitProfit()))
           //.ForMember(dest => dest.WholesaleUnitPrice, src => src.MapFrom(s => s.CalculateWholesaleUnitPrice()))
           //.ForMember(dest => dest.SegmentalUnitPrice, src => src.MapFrom(s => s.CalculateSegmentalUnitPrice()))
           //.ForMember(dest => dest.NumberInStock, src => src.MapFrom(s => s.CalculateStock()))


           .ReverseMap()
           .ForMember(src => src.WarehouseBin, dest => dest.Ignore())
           .ForMember(src => src.Warehouse, dest => dest.Ignore())
           .ForMember(src => src.ProductCategory, dest => dest.Ignore())

            ;




            CreateMap<ProductDetails, ProductDto>()

                //.ForMember(dest => dest.ProductDetailsId, src => src.MapFrom(s => s.Id))
                .ForMember(dest => dest.UnitPriceWholeSale, src => src.MapFrom(s => s.UnitPriceWholeSale))
                .ForMember(dest => dest.BoxPriceWholeSale, src => src.MapFrom(s => s.BoxPriceWholeSale))
                .ForMember(dest => dest.ExpiryDate, src => src.MapFrom(s => s.ExpiryDate))
               .ForMember(dest => dest.Name, src => src.MapFrom(s => s.Product.Name))
               .ForMember(dest => dest.ItemsInBox, src => src.MapFrom(s => s.Product.ItemsInBox))


               .ForMember(dest => dest.SellingUnitPrice, src => src.MapFrom(s => s.Product.SellingUnitPrice))
               .ForMember(dest => dest.SellingBoxPrice, src => src.MapFrom(s => s.Product.SellingBoxPrice))
               .ForMember(dest => dest.Description, src => src.MapFrom(s => s.Product.Description))



               .ForMember(dest => dest.Id, src => src.MapFrom(s => s.Product.Id));


                








            CreateMap<ProductDetails, ProductDetailsDto>()
                
                .ForMember(dest => dest.ProductDetailsId, src => src.MapFrom(s => s.Id))
                //.ForMember(dest => dest.segmentalProfit, src => src.MapFrom(s => s.CalculateSegmentalProfit()))
                //.ForMember(dest => dest.wholesaleProfit, src => src.MapFrom(s => s.CalculateWholesaleProfit()))

                //.ForMember(dest => dest.wholesaleUnitPrice, src => src.MapFrom(s => s.CalculateWholesaleUnitPrice()))
                //.ForMember(dest => dest.segmentalUnitPrice, src => src.MapFrom(s => s.CalculateSegmentalUnitPrice()))

                //.ForMember(dest => dest.Stock, src => src.MapFrom(s => s.CalculateStock()))
                .ReverseMap()
                .ForMember(src => src.Id, dest => dest.MapFrom(s => s.ProductDetailsId));



             




            CreateMap<ProductCreateDto, Product>();
            CreateMap<ProductUpdateDto, Product>();

            CreateMap<Bin, BinDto>().ReverseMap();

            CreateMap<Warehouse, WarehouseDto>()
             .ForMember(dest => dest.LocationCity, src => src.MapFrom(s => s.LocationAddress.City))
             .ForMember(dest => dest.LocationCountry, src => src.MapFrom(s => s.LocationAddress.Country))
             .ForMember(dest => dest.LocationState, src => src.MapFrom(s => s.LocationAddress.State))
             .ForMember(dest => dest.LocationStreet, src => src.MapFrom(s => s.LocationAddress.Street))
             .ForMember(dest => dest.LocationZipCode, src => src.MapFrom(s => s.LocationAddress.ZipCode))

             .ForMember(dest => dest.Location, src => src.MapFrom(s => s.LocationAddress.ToString()))
             .ForMember(dest => dest.BinsNumbers, src => src.MapFrom(s => s.Bins.Count ))
             .ForMember(dest => dest.ProductsCount, src => src.MapFrom(s => s.Products.Count ))
      //       .ForMember(dest => dest.ProductsPrice, src => src.MapFrom(s => s.Products.Sum(s=>s.BuyingPrice) ))

             .ReverseMap()
           .ForMember(src => src.Bins, dest => dest.Ignore());


            CreateMap<Partner, PartnerDto>()
             .ForMember(dest => dest.City, src => src.MapFrom(s => s.Address.City))
             .ForMember(dest => dest.Country, src => src.MapFrom(s => s.Address.Country))
             .ForMember(dest => dest.State, src => src.MapFrom(s => s.Address.State))
             .ForMember(dest => dest.Street, src => src.MapFrom(s => s.Address.Street))
             .ForMember(dest => dest.ZipCode, src => src.MapFrom(s => s.Address.ZipCode))
             .ForMember(dest => dest.FullAddress, src => src.MapFrom(s => s.Address.ToString()))

             .ReverseMap() ;

            CreateMap<Transaction, TransactionDto>()
                  .ForMember(dest => dest.PartnerName, src => src.MapFrom(s => s.Partner.Name))
                  .ForMember(dest => dest.PhoneNumber, src => src.MapFrom(s => s.Partner.PhoneNumber))
                //  .ForMember(dest => dest.Total, src => src.MapFrom(s => s.TransactionLines.Sum(s=>(s.Quantity * s.UnitPrice))))
                  .ForMember(dest => dest.Total, src => src.MapFrom(s => s.TransactionLines.Count()))
                  .ReverseMap()  ;    
            
            CreateMap<Transaction, TransactionLitsDto>()
                  .ForMember(dest => dest.PartnerName, src => src.MapFrom(s => s.Partner.Name))
                  .ForMember(dest => dest.PhoneNumber, src => src.MapFrom(s => s.Partner.PhoneNumber))
                  
                  .ForMember(dest => dest.Profit, src => src.MapFrom(s =>  s.CalculateTrxProfit(s.TransactionType)   ))
                  //.ForMember(dest => dest.SegmentalProfit, src => src.MapFrom(s => s.CalculateTrxProfit(s.TransactionType) ))

                  .ForMember(dest => dest.ProductsCount, src => src.MapFrom(s => s.TransactionLines.Count()))




                  .ForMember(dest => dest.TransactionTypeId, src => src.MapFrom(s =>(int) s.TransactionType))


                  .ForMember(dest => dest.TransactionTypeStr, src => src.MapFrom(s =>Enum.GetName(typeof(TransactionType), s.TransactionType)))
                  
                  
                  .ReverseMap()  ; 
            
            
            CreateMap<PurchaseTransactionDto, Transaction>();

 

            CreateMap<TransactionLine, TransactionLineDto>()
           //     .ForMember(dest => dest.ProductName, src => src.MapFrom(s => s.Product.Name))
                .ReverseMap();





        }
    }
}
