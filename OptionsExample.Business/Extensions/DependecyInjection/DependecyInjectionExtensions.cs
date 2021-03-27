using Microsoft.Extensions.DependencyInjection;
using OptionsExample.Configuration;
using OptionsExample.Business.Logic;

namespace OptionsExample.Business.Extensions.DependecyInjection
{
    public static class DependecyInjectionExtensions
    {
        /// <summary>
        /// Manage the additon of all OptionExample business classes to the IOC
        /// </summary>
        /// <param name="services">IServiceCollection</param>
        /// <returns>IServiceCollection</returns>
        public static IServiceCollection AddOptionsExampleBusiness(this IServiceCollection services)
        {
            services.AddConfigurationOptions();
            services.AddOptionsExampleLogic();

            return services;
        }

        internal static IServiceCollection AddOptionsExampleLogic(this IServiceCollection services)
        {
            // Add All the business logic classes to the IOC
            services.AddScoped<ServiceALogic>();
            services.AddScoped<ServiceCLogic>();
            services.AddScoped<ServiceBLogic>();

            return services;
        }

        internal static IServiceCollection AddConfigurationOptions(this IServiceCollection services)
        {
            ;

            return services;
        }
    }
}
