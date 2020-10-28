using Microsoft.Extensions.DependencyInjection;
using OptionsExample.Business.Configuration;

namespace OptionsExample.Business.Extensions.DependecyInjection
{
    public static class OptionsExtensions
    {
        internal static IServiceCollection AddConfigurationOptions(this IServiceCollection services)
        {
            // Add an IOptions<T> for each of the following configuation groups to the IOC

            services.AddOptions<ServiceBOtpions>()
                    .BindConfiguration("ServiceB");

            services.AddOptions<ServiceAOptions>()
                    .BindConfiguration("ServiceA");

            services.AddOptions<ServiceCOptions>()
                    .BindConfiguration("ServiceC");

            services.AddOptions<FileShareOptions>()
                    .BindConfiguration("FileShare");

            return services;
        }
    }
}
