using Edgias.Inventory.Management.ApplicationCore.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Domain
{
    public abstract class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; }

        public DateTime CreatedDate { get;  set; } = DateTime.UtcNow;

        public DateTime LastModifiedDate { get;  set; } = DateTime.UtcNow;

        public bool IsActive { get;   set; } = true;

        public bool IsDeleted { get;   set; }

        //public List<BaseDomainEvent> Events { get; private set; } = new List<BaseDomainEvent>();


        //public void AddDomainEvent(BaseDomainEvent domainEvent)

        //{ 
        //     DomainEvents.Raise(new OrderPlaced(order));
        //    Events.Add(domainEvent);
        //}

        //public void RemoveDomainEvent(BaseDomainEvent domainEvent)
        //{
        //    Events.Remove(domainEvent);
        //}

        public void ChangeStatus()
        {
            IsActive = !IsActive;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

    }
}
