using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Domain.Entities
{
    public class TransactionLine:BaseEntity<long>
    {
        [Required]
        public long TransactionId { get;  set; }

        [ForeignKey("TransactionId")]
        public Transaction Transaction { get;  set; }

  
        public bool? Box { get; init; }

        public int BoxNumbers { get; set; }

   
        [MaxLength(400)]
        public string Description { get; private set; }
 
        public DateTime ExpiryDate { get; set; }

 
        [Required]
        public long ProductId { get; init; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

      
        public int Quantity { get;  set; }


        #region Purchase 
        [Column(TypeName = "decimal(18,4)"), Required]
        public decimal BuyingBoxPrice { get; set; }

        [Column(TypeName = "decimal(18,4)"), Required]
        public decimal BuyingUnitPrice { get; set; }

         [Column(TypeName = "decimal(18,4)"), Required]
        public decimal BuyingPrice { get; set; }
 
        #endregion




        [Required, Column(TypeName = "decimal(18,2)")]

        public decimal SellingUnitPrice { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal SellingBoxPrice { get; set; }


 


        //[Required, Column(TypeName = "decimal(18,2)")]
        //public decimal WholesaleUnitPrice { get; set; }

        //[Required, Column(TypeName = "decimal(18,2)")]
        //public decimal WholesaleBoxPrice { get; set; }


        //[Required, Column(TypeName = "decimal(18,2)")]
        //public decimal WholesaleBoxProfit { get; set; }

        //[Required, Column(TypeName = "decimal(18,2)")]
        //public decimal SegmentalProfit { get; set; }


        //public void CalculateBuyingBoxPrice(Product product)
        //{
        //    BuyingBoxPrice =  BuyingPrice / productDtl. BoxNumber
        //}

    }
}
