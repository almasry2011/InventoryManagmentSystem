using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.Product
{
    public class ProductFilterDto
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string Code { get; set; }
    }
}
