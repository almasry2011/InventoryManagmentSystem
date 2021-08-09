using InventoryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Persistence.ModelConfiguration
{
    public class WarehouseConfig : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.OwnsOne(l => l.LocationAddress, a =>
            {
                a.WithOwner();

                a.Property(a => a.ZipCode)
                    .HasMaxLength(18);

                a.Property(a => a.Street)
                    .HasMaxLength(180);

                a.Property(a => a.State)
                    .HasMaxLength(60);

                a.Property(a => a.Country)
                    .HasMaxLength(90);

                a.Property(a => a.City)
                    .HasMaxLength(100);
            });
        }
    }
}
