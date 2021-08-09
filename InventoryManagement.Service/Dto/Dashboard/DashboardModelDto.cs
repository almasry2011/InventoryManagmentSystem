using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.Dashboard
{
     public  class DashboardModelDto
    {
        public int Products { get; set; }
        public decimal Purchase  { get; set; }
        public decimal Sales { get; set; }
        public decimal Profit { get; set; }

        public decimal LWPurchase { get; set; }
        public decimal LWSales { get; set; }
        public decimal LWProfit { get; set; }

        public string LWDate { get; set; }







        public DashboardModelDto()
        {
            Profit = Sales - Purchase;
        }


    }
}
