using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.Product
{
    public class ProductDetailsDto
    {
        public long ProductId { get; set; }
        public long ProductDetailsId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal BuyingPrice { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public int? BoxNumber { get; set; }
        public int? ItemsInBox { get; set; }
        public decimal? BoxPrice { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public decimal wholesaleProfit { get; set; }
        public decimal segmentalProfit { get; set; }
        public decimal wholesaleUnitPrice { get; set; }
        public decimal segmentalUnitPrice { get; set; }
        public long Stock { get; set; }


        public string rowStatus { get; set; }
 

    }
}
