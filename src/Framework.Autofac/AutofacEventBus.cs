
using Autofac;
using Framework.Domain;

namespace Framework.Autofac;

public class AutofacEventBus : IEventBus
{
    private readonly ILifetimeScope _scope;

    public AutofacEventBus(ILifetimeScope scope)
    {
        _scope = scope;
    }

    public void Dispatch<T>(T @event) where T : IEvent
    {
        var handlerType = typeof(IEventHandler<>).MakeGenericType(@event.GetType());
        var handlers = _scope.Resolve(typeof(IEnumerable<>).MakeGenericType(handlerType)); 
        foreach (var handler in (System.Collections.IEnumerable)handlers) ((dynamic)handler).Handle((dynamic)@event);
    }
}