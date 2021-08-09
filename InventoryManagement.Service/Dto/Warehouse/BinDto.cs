using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Dto.Warehouse
{
   public class BinDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string SerialNumber { get; set; }

        public string Color { get; set; }

        public int? Width { get; set; }

        public int? Depth { get; set; }

        public decimal? Height { get; set; }

        public int? DividerSlots { get; set; }

        public decimal? Weight { get; set; }

        public long WarehouseId { get; set; }

    }
}
