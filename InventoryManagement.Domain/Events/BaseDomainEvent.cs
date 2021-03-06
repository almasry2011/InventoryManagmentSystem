using System;
using System.Collections.Generic;

namespace Edgias.Inventory.Management.ApplicationCore.Events
{
    public interface IDomainEvent { }

    public static class DomainEvents
    {
        private static Dictionary<Type, List<Delegate>> _handlers;

        public static void Register<T>(Action<T> eventHandler)
            where T : IDomainEvent
        {
            _handlers[typeof(T)].Add(eventHandler);
        }

        public static void Raise<T>(T domainEvent)
            where T : IDomainEvent
        {
            foreach (Delegate handler in _handlers[domainEvent.GetType()])
            {
                var action = (Action<T>)handler;
                action(domainEvent);
            }
        }
    }
    public abstract class BaseDomainEvent //: INotification
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.Now;
    }
}
