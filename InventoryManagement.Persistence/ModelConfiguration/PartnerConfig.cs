using InventoryManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace InventoryManagement.Persistence.ModelConfiguration
{
    public class PartnerConfig : IEntityTypeConfiguration<Partner>
    {
        public void Configure(EntityTypeBuilder<Partner> builder)
        {
            builder.OwnsOne(l => l.Address, a =>
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
