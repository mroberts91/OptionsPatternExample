using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OptionsExample.Business.Configuration;

namespace OptionsExample.Business.Logic
{
    public class ServiceCLogic
    {
        private readonly IOptions<ServiceCOptions> _serviceOptions;
        private readonly ILogger<ServiceCLogic> _logger;

        public ServiceCLogic(IOptions<ServiceCOptions> serviceOptions, ILogger<ServiceCLogic> logger)
        {
            _serviceOptions = serviceOptions;
            _logger = logger;
            _logger.LogInformation("Options Injects: {name}, Values: Service Url - {val1}, Service User - {val2}\n", nameof(serviceOptions), _serviceOptions.Value.ServiceUrl, _serviceOptions.Value.ServiceUserId);
        }

        public object GetOptions() => new
        {
            _serviceOptions.Value.ServiceUrl,
            _serviceOptions.Value.ServiceUserId
        };
    }
}
