using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Consumer.Handlers;

namespace Consumer;

public static class HandlerExtensions
{
    public static IServiceCollection AddMessageHandlers(this IServiceCollection services)
    {
        var handlers = Assembly.GetExecutingAssembly().DefinedTypes
            .Where(x => typeof(IMessageHandler).IsAssignableFrom(x) 
                        && !x.IsInterface 
                        && !x.IsAbstract);

        foreach (var handler in handlers)
        {
            var handlerType = handler.AsType();
            services.AddScoped(handlerType);
        }

        return services;
    }
}