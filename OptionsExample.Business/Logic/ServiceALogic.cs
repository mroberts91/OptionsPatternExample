using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OptionsExample.Business.Configuration;

namespace OptionsExample.Business.Logic
{
    public class ServiceALogic
    {
        private readonly ServiceAOptions _serviceOptions;
        private readonly FileShareOptions _fileShareOptions;

        public ServiceALogic(IOptions<ServiceAOptions> serviceOptions, IOptions<FileShareOptions> fileShareOptions)
        {
            _serviceOptions = serviceOptions.Value;
            _fileShareOptions = fileShareOptions.Value;
        }

        public object GetOptions() => new
        {
            _serviceOptions.ServiceUrl,
            _serviceOptions.AppIdentifier,
            _fileShareOptions.FileSharePath,
        };
    }
}
