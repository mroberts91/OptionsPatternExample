using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OptionsExample.Business.Configuration;

namespace OptionsExample.Business.Logic
{
    public class ServiceBLogic
    {
        private readonly ServiceBOtpions _serviceOptions;

        public ServiceBLogic(IOptionsSnapshot<ServiceBOtpions> serviceOptions)
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
