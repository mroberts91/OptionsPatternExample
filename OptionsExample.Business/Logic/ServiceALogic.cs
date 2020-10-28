using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OptionsExample.Business.Configuration;

namespace OptionsExample.Business.Logic
{
    public class ServiceALogic
    {
        private readonly IOptions<ServiceAOptions> _serviceOptions;
        private readonly IOptions<FileShareOptions> _fileShareOptions;
        private readonly ILogger<ServiceALogic> _logger;

        public ServiceALogic(IOptions<ServiceAOptions> serviceOptions, IOptions<FileShareOptions> fileShareOptions, ILogger<ServiceALogic> logger)
        {
            _serviceOptions = serviceOptions;
            _fileShareOptions = fileShareOptions;
            _logger = logger;
            _logger.LogInformation("Options Injects: {name}, Values: Service Url - {val1}, Service User - {val2}\n", nameof(serviceOptions), _serviceOptions.Value.ServiceUrl, _serviceOptions.Value.ServiceUserId);
            _logger.LogInformation("Options Injects: {name}, Values: File Share Path - {val1}\n", nameof(_fileShareOptions), _fileShareOptions.Value.FileSharePath);
        }

        public object GetOptions() => new
        {
            _serviceOptions.Value.ServiceUrl,
            _serviceOptions.Value.ServiceUserId,
            _fileShareOptions.Value.FileSharePath
        };
    }
}
