using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.Warehouse
{
   public class WarehouseDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string LocationStreet { get; set; }

        public string LocationCity { get; set; }

        public string LocationState { get; set; }

        public string LocationZipCode { get; set; }

        public string LocationCountry { get; set; }
        public string Location { get; set; }

        public int BinsNumbers { get; set; }


        public ICollection<BinDto> Bins { get; set; }
        public int ProductsCount { get; set; }
        public int ProductsPrice { get; set; }


    }
}
