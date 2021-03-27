using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using OptionsExample.Configuration;

namespace OptionsExample
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private readonly IServiceOptions _serviceAOptions;
        private readonly IServiceOptions _serviceBOptions;
        private readonly IServiceOptions _serviceCOptions;

        public ConfigurationController(IOptions<ServiceAOptions> serviceAOptions, IOptionsSnapshot<ServiceBOptions> serviceBOptions, IOptions<ServiceCOptions> serivceCOptions)
        {
            _serviceAOptions = serviceAOptions.Value;
            _serviceBOptions = serviceBOptions.Value;
            _serviceCOptions = serivceCOptions.Value;
        }

        [HttpGet]
        public IActionResult Get()
            => Ok(new {ServiceA = _serviceAOptions.GetOptions(), ServiceB = _serviceBOptions.GetOptions(), ServiceC = _serviceCOptions.GetOptions()});

    }
}
