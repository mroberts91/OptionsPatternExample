using Microsoft.Extensions.DependencyInjection;
using OptionsExample.Business.Logic;

namespace OptionsExample.Business.Extensions.DependecyInjection
{
    public static class LogicExtensions
    {
        internal static IServiceCollection AddOptionsExampleLogic(this IServiceCollection services)
        {
            // Add All the business logic classes to the IOC

            services.AddScoped<ServiceALogic>();
            services.AddScoped<ServiceCLogic>();
            services.AddScoped<ServiceBLogic>();

            return services;
        }
    }
}
