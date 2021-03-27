using Microsoft.Extensions.Options;
using OptionsExample.Business.Configuration;

namespace OptionsExample.Business.Logic
{
    public class ServiceCLogic
    {
        private readonly ServiceCOptions _serviceOptions;

        public ServiceCLogic(IOptionsSnapshot<ServiceCOptions> serviceOptions)
        {
            _serviceOptions = serviceOptions.Value;
        }

        public object GetOptions() => new
        {
            _serviceOptions.ServiceUrl,
            _serviceOptions.AppIdentifier,
        };
    }
}
