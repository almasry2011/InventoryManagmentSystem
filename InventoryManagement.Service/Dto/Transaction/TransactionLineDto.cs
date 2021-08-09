using InventoryManagement.Service.Dto.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.Transaction
{
   public class SaleTransactionLineDto : EntityDto<long>
    {
        [Required]
        public long TransactionId { get; set; }
        public bool? Box { get; init; }
        public int BoxNumbers { get; set; }

        [MaxLength(400)]
        public string Description { get;  set; }
        public long ProductId { get; init; }
        public int Quantity { get; set; }
    }


    public class TransactionLineDto : EntityDto<long>
    {
        [Required]
        public long TransactionId { get;  set; }
        [Required]
        public long ProductId { get; set; }
        public string ProductName { get; set; }

        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }

        public ProductDto Product { get; set; }
    }
}
