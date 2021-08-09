using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Domain.Entities
{
    public class Bin : BaseEntity<long>
    {
        public string Name { get; private set; }

        public string SerialNumber { get; private set; }

        public string Color { get; private set; }

        public int? Width { get; private set; }

        public int? Depth { get; private set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? Height { get; private set; }

        public int? DividerSlots { get; private set; }


        [Column(TypeName = "decimal(18,4)")]
        public decimal? Weight { get; private set; }

        public long WarehouseId { get; private set; }

        public Warehouse Warehouse { get; private set; }

        private Bin()
        {
        }

        public Bin(string name, string serialNumber, string color, int? width=0, int? depth = 0, decimal? height = 0, int? dividerSlots = 0, decimal? weight = 0)
        {
            Name = name;
            SerialNumber = serialNumber;
            Color = color;
            Width = width;
            Depth = depth;
            Height = height;
            DividerSlots = dividerSlots;
            Weight = weight;
            //WarehouseId = warehouseId;
        }

        public void UpdateDetails(string name, string serialNumber, string color, int? width, int? depth, decimal? height, int? dividerSlots, decimal? weight)
        {
            Name = name;
            SerialNumber = serialNumber;
            Color = color;
            Width = width;
            Depth = depth;
            Height = height;
            DividerSlots = dividerSlots;
            Weight = weight;
            LastModifiedDate = DateTime.UtcNow;
        }

        public void ChangeWarehouse(long warehouseId)
        {
            WarehouseId = warehouseId;
            LastModifiedDate = DateTime.UtcNow;
        }
    }
}
