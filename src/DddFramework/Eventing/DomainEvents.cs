using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DddFramework
{
    public static class DomainEvents
    {
        private static Dictionary<Type, List<Delegate>> _handlers;

        static DomainEvents() {
            _handlers = new Dictionary<Type, List<Delegate>>();
        }

        public static void Register<T>(Action<T> eventHandler)
            where T : IDomainEvent {
            if (!_handlers.ContainsKey(typeof(T))) {
                _handlers.Add(typeof(T), new List<Delegate>() { eventHandler });
            } else {
                _handlers[typeof(T)].Add(eventHandler);
            }
        }

        public static void Raise<T>(T domainEvent)
            where T : IDomainEvent {
            if (!_handlers.ContainsKey(typeof(T))) {
                return;
            }

            foreach (Delegate handler in _handlers[typeof(T)]) {
                var action = (Action<T>)handler;
                action(domainEvent);
            }
        }
    }
}
