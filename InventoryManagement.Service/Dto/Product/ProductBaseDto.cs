using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.Product
{
   public class ProductBaseDto : EntityDto<long>
    {
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public int NumberInStock { get; set; }
        public long ProductCategoryId { get; set; }
        public long WarehouseId { get; set; }
        public long WarehouseBinId { get; set; }
        public int ItemsInBox { get;  set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SellingUnitPrice { get; set; }
        [Column(TypeName = "decimal(18,2")]
        public decimal SellingBoxPrice { get; set; }
        public decimal UnitPriceWholeSale { get; private set; }
        public decimal BoxPriceWholeSale { get; private set; }
        public DateTime ExpiryDate { get; set; }
 
        //public ICollection<ProductDetailsDto> _productDetails { get; set; }
    }
}
