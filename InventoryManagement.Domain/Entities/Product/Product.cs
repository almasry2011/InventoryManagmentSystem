using InventoryManagement.Domain.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace InventoryManagement.Domain.Entities
{
    public class Product : BaseEntity<long>
    {
        [Required,MinLength(3),MaxLength(50)]
        public string Name { get; private set; }


        [Required]
        public long ProductCategoryId { get; private set; }

        [ForeignKey("ProductCategoryId")]
        public Category ProductCategory { get; private set; }


        [Required]
        public long WarehouseId { get; private set; }

        [ForeignKey("WarehouseId")]
        public Warehouse Warehouse { get; private set; }

        [Required]
        public long WarehouseBinId { get; private set; }

        public int? NumberInStock { get; private set; }

 
        public int ItemsInBox { get; private set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal SellingUnitPrice { get; private set; }
        [Column(TypeName = "decimal(18,2")]
        public decimal SellingBoxPrice { get; private set; }

        [Column(TypeName = "decimal(18,4)"), Required]
        public decimal UnitPriceWholeSale { get; private set; }

        [Column(TypeName = "decimal(18,4)"), Required]
        public decimal BoxPriceWholeSale { get; private set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
         
        [ForeignKey("WarehouseBinId")]
        public Bin WarehouseBin { get; private set; }

        [MaxLength(400)]
        public string Description { get; private set; }


        public int CalculateStockToBoxs()
        {
           return NumberInStock.Value / ItemsInBox;
        }
        public decimal GetBoxProfit()
        {
            return SellingBoxPrice - BoxPriceWholeSale;
        }

        public decimal GetUnitProfit()
        {
            return SellingUnitPrice - UnitPriceWholeSale;
        }
        //public IReadOnlyCollection<ProductDetails> ProductDetails => _productDetails;
        //private List<ProductDetails> _productDetails = new();

        //public void AddProductDetails(ProductDetails prodDtl)
        //{
        //    prodDtl.SetWholeSalePrice(ItemsInBox);
        //    _productDetails.Add(prodDtl);
        //    NumberInStock += (prodDtl.BoxNumber *  ItemsInBox);
        //}

        //public void AddProductDetails(List<ProductDetails> prodDtls)
        //{ 
        //    // prodDtls.ForEach(s => s.SetStock(ItemsInBox));
        //    _productDetails.AddRange(prodDtls);

        //    NumberInStock += prodDtls.Sum(s => s.BoxNumber) * ItemsInBox;
        //}

        //public void UpdateProductDetails(ProductDetails prodDtl)
        //{
        //    var dtl = ProductDetails.SingleOrDefault(s => s.Id == prodDtl.Id);
        //        _productDetails.Remove(dtl);
        //        _productDetails.Add(prodDtl);
        //        NumberInStock = ProductDetails.Sum(s => s.BoxNumber ) * ItemsInBox;
        //}


        //public void UpdateProductDetails(List<ProductDetails> prodDtls)
        //{

        //    _productDetails.RemoveAll(s => prodDtls.Where(x => x.Id == s.Id).Any());


        //    _productDetails.AddRange(prodDtls);

        //    NumberInStock = ProductDetails.Sum(s => s.BoxNumber ) *  ItemsInBox ;

        //}



        //public void RemoveProductDetails(List< ProductDetails> prodDtls)
        //{

        //    _productDetails.RemoveAll(s=>prodDtls.Where(x=>x.Id==s.Id).Any());


        //    NumberInStock = ProductDetails.Sum(s => s.BoxNumber ) * ItemsInBox;

        //}


        public void RecordTransaction(TransactionLine trxLine, TransactionType type)
        {
       

            if (type == TransactionType.Sales)
            {
                if (trxLine.Quantity > NumberInStock)
                {
                    throw new ValidationException($"Product ${trxLine.Product.Name} - Quantity {trxLine.Quantity} is greater than the Stock {trxLine.Product.NumberInStock}");
                }
                NumberInStock -= trxLine.Quantity;
            }
            else
            {
                NumberInStock += trxLine.Quantity;

            }
        }





        public void SetWholesalePrice(TransactionLine trxLine)
        {
         
            var CalculatedBoxPriceWholeSale = trxLine.BuyingPrice / trxLine.BoxNumbers;
            var CalculatedUnitPriceWholeSale = CalculatedBoxPriceWholeSale / ItemsInBox;
         
            if (BoxPriceWholeSale == 0  ||  CalculatedBoxPriceWholeSale < BoxPriceWholeSale)
            {
                BoxPriceWholeSale = CalculatedBoxPriceWholeSale;
            }

            if (UnitPriceWholeSale == 0 || CalculatedUnitPriceWholeSale < UnitPriceWholeSale)
            {
                UnitPriceWholeSale = CalculatedUnitPriceWholeSale;
            }

          

        }

        //public decimal CalculateSegmentalProfit()
        //{
        //    return ProductDetails.Sum(s => s.CalculateSegmentalProfit());
        //}

        //public decimal CalculateStock()
        //{
        //    return ProductDetails.Sum(s =>s.CalculateStock());
        //}

        //public decimal CalculateWholesaleUnitPrice()
        //{
        //    return ProductDetails.Sum(s => (s.BoxPrice / ItemsInBox)).Value;
        //}

        //public decimal CalculateSegmentalUnitPrice()
        //{
        //    return ProductDetails!=null ? 0 : ProductDetails.FirstOrDefault().UnitPrice;
        //}








        //[Column(TypeName = "decimal(18,4)"),Required]
        //public decimal UnitPrice { get; private set; }

        //[Column(TypeName = "decimal(18,4)"), Required]
        //public decimal SellingPrice { get; private set; }

        //[Column(TypeName = "decimal(18,4)"), Required]
        //public decimal BuyingPrice { get; private set; }


        //[Required]
        //public string ProductCode { get; private set; }

        //[MaxLength(400)]
        //public string Description { get; private set; }

        //public int NumberInStock { get; private set; } 


        //public int? BoxNumber { get; private set; }

        //public int? ItemsInBox { get; private set; }

        //[Column(TypeName = "decimal(18,4)")]
        //public decimal? BoxPrice { get; private set; }

        //[Required]
        //public DateTime ProductionDate { get; set; }
        //[Required]
        //public DateTime ExpiryDate { get; set; }

        //[Required]
        //public long ProductCategoryId { get; private set; }

        //[ForeignKey("ProductCategoryId")]
        //public Category ProductCategory { get; private set; }

        //    public Product()  {  }
        //public Product(string name, decimal price, int stock, string Code, string description ,long categoryId,
        //                       long warehouseId,long warehouseBinId )  {
        //    Name =  name;
        //    UnitPrice = price;
        //    Description = description;
        //    ProductCode = Code;
        //    ProductCategoryId = categoryId;
        //    WarehouseBinId = warehouseBinId;
        //    WarehouseId = warehouseId;
        //    NumberInStock = stock;
        //}

        //public void UpdateProduct(string name, decimal price, string Code, string description, long categoryId,
        //                     long warehouseId, long warehouseBinId)
        //{
        //    Name = name;
        //    UnitPrice = price;
        //    Description = description;
        //    ProductCode = Code;
        //    ProductCategoryId = categoryId;
        //    WarehouseBinId = warehouseBinId;
        //    WarehouseId = warehouseId;
        //}


        //public void RecordTransaction(TransactionLine trxLine)
        //{
        //    if (trxLine.Quantity > NumberInStock)
        //    {
        //        throw new ValidationException($"Product ${Name} - Quantity {trxLine.Quantity} is greater than the Stock {NumberInStock}");
        //    }

        //    if (trxLine.Transaction.TransactionType==Enum.TransactionType.Sales)
        //    {
        //        NumberInStock -= trxLine.Quantity;
        //    }  else   {
        //        NumberInStock += trxLine.Quantity;
        //    }


        //}

    }
}
