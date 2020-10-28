using Microsoft.Extensions.DependencyInjection;

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
    }
}
