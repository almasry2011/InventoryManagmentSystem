using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Domain.Entities
{
   public class ProductDetails : BaseEntity<long>
    {

        [Column(TypeName = "decimal(18,4)"), Required]
        public decimal BuyingPrice { get; private set; }

        [Column(TypeName = "decimal(18,4)"), Required]
        public decimal UnitPriceWholeSale { get; private set; } 

        [Column(TypeName = "decimal(18,4)"), Required]
        public decimal BoxPriceWholeSale { get; private set; }

        [Required]
        public int BoxNumber { get; private set; }

        [Required]
        public string ProductCode { get; private set; }
         
        [MaxLength(400)]
        public string Description { get; private set; }
         
        [Required]
        public DateTime ProductionDate { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }

        [Required]
        public long ProductId { get; private set; }

        [ForeignKey("ProductId")]
        public Product Product { get; private set; }

 
        public decimal CalculateWholesaleBoxProfit(Product product)
        {
            return ((product.SellingBoxPrice * BoxNumber) - BuyingPrice );
        }

        public void CalculateBoxPriceWholeSale( )
        {
            BoxPriceWholeSale = BuyingPrice / BoxNumber;
        }

        public void SetWholeSalePrice(int itemInBox)
        {
            BoxPriceWholeSale = BuyingPrice / BoxNumber;
            UnitPriceWholeSale = BoxPriceWholeSale / itemInBox;
        }

        //public decimal CalculateBoxSegmentalProfit(Product product)
        //{
        //    return CalculateWholesaleUnitProfit(product) * product.ItemsInBox;
        //}  


        //public decimal CalculateStock()
        //{
        //    return ( ItemsInBox * BoxNumber).Value;
        //}

        public decimal CalculateWholesaleUnitPrice(Product product)
        {
            return (product.SellingBoxPrice / product.ItemsInBox) ;
        }

     
        //public void SetStock(int ItemsInBox )
        //{
        //    this.ItemsInBox = ItemsInBox;
        //    ItemsInStock = (BoxNumber * ItemsInBox).Value;
        //}
         
    }
}
