using InventoryManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace InventoryManagement.Domain.Entities
{
    public class Warehouse : BaseEntity<long>
    {
        public string Name { get; private set; }

        public Address LocationAddress { get; private set; }


        private List<Bin> _bins = new();

        public IReadOnlyCollection<Bin> Bins => _bins.AsReadOnly();
        public IReadOnlyCollection<Product> Products { get; private set; }

        private Warehouse() { }

        public Warehouse(string name, Address location)
        {
            Name = name;
            LocationAddress = location;
        }

        public void UpdateDetails(string name)
        {
            Name = name;
            LastModifiedDate = DateTime.UtcNow;
        }

        public void ChangeLocation( Address location)
        {
            LocationAddress = location;
            LastModifiedDate = DateTime.UtcNow;
        }

        public void AddWarehouseBin(string name, string serialNumber, string color, int? width, int? depth, decimal? height, int? dividerSlots, decimal? weight)
        {
            var bin = new Bin(name, serialNumber, color,width,depth,height,dividerSlots,weight);
            _bins.Add(bin);
        }

        public void UpdateWarehouseBin(string name, string serialNumber, string color, int? width, int? depth, decimal? height, int? dividerSlots, decimal? weight,long binId=0)
        {
            var row = Bins.FirstOrDefault(s => s.Id == binId);
            row.UpdateDetails(name, serialNumber, color, width, depth, height, dividerSlots, weight);
          //  _bins.Add(bin);
        }





    }
}
