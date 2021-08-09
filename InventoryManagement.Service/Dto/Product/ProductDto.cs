using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.Product
{
   public class ProductDto: ProductBaseDto
    {
 
        public string ProductCategoryStr { get; set; }
        public string WarehouseStr { get; set; }
        public string WarehouseBinStr { get; set; }

        public int AvalableBoxs { get; set; }
        public int  SingleItems    => NumberInStock % ItemsInBox;
        public decimal WholesaleProfit { get; set; }
        public decimal SegmentalProfit { get; set; }

    

    }
}
