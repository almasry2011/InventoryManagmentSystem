using InventoryManagement.Domain;
using InventoryManagement.Domain.Auth;
using InventoryManagement.Domain.Entities;
using InventoryManagement.Persistence.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryManagement.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.HasDefaultSchema("Identity");
            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "User");
            });

            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });

            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });

            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });

            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });

            modelBuilder.Seed();
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Warehouse> warehouses { get; set; }
        public DbSet<Bin> Bins { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionLine> TransactionLines { get; set; }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

          //  int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            
            //// dispatch events only if save was successful
            //BaseEntity[] entitiesWithEvents = ChangeTracker.Entries<BaseEntity>()
            //    .Select(e => e.Entity)
            //    .Where(e => e.Events.Any())
            //    .ToArray();


            // Get all the entities that inherit from AuditableEntity
            // and have a state of Added or Modified
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity<long> && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));
            


            // For each entity we will set the Audit properties
            foreach (var entityEntry in entries)
            {
                  if (entityEntry.State == EntityState.Added && entityEntry.IsKeySet)
                {
                    entityEntry.State = EntityState.Modified;
                }

                // If the entity state is Added let's set
                // the CreatedAt and CreatedBy properties
                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity<long>)entityEntry.Entity).CreatedDate = DateTime.UtcNow;
                  //  ((BaseEntity<long>)entityEntry.Entity).CreatedBy = _httpContextAccessor?.HttpContext?.User?.Identity?.Name ?? "MyApp";
                }
                else
                {
                    // If the state is Modified then we don't want
                    // to modify the CreatedAt and CreatedBy properties
                    // so we set their state as IsModified to false
                    Entry((BaseEntity<long>)entityEntry.Entity).Property(p => p.CreatedDate).IsModified = false;
                   // Entry((BaseEntity<long>)entityEntry.Entity).Property(p => p.CreatedBy).IsModified = false;
                }

                // In any case we always want to set the properties
                // ModifiedAt and ModifiedBy
                ((BaseEntity<long>)entityEntry.Entity).LastModifiedDate = DateTime.UtcNow;
             //   ((BaseEntity)entityEntry.Entity).LastModifiedBy = _httpContextAccessor?.HttpContext?.User?.Identity?.Name ?? "MyApp";
            }

            // After we set all the needed properties
            // we call the base implementation of SaveChangesAsync
            // to actually save our entities in the database








            //foreach (BaseEntity entity in entitiesWithEvents)
            //{
            //    BaseDomainEvent[] events = entity.Events.ToArray();
            //    entity.Events.Clear();

            //    foreach (BaseDomainEvent domainEvent in events)
            //    {
            //        await _mediator.Publish(domainEvent).ConfigureAwait(false);
            //    }
            //}

           // return result;

            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
