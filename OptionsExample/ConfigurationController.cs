using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using OptionsExample.Business.Logic;
using System.ComponentModel;

namespace OptionsExample
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private readonly ServiceALogic _serviceALogic;
        private readonly ServiceBLogic _serviceBLogic;
        private readonly ServiceCLogic _serviceCLogic;

        public ConfigurationController(ServiceALogic serviceALogic, ServiceBLogic serviceBLogic, ServiceCLogic serviceCLogic)
        {
            _serviceALogic = serviceALogic;
            _serviceBLogic = serviceBLogic;
            _serviceCLogic = serviceCLogic;
        }

        [HttpGet]
        [SwaggerOperation(
            Summary = "Get Option Configuration",
            Description = "Get the available configuaration options on all services",
            OperationId = "Configuaration.Get",
            Tags = new[] { "ConfigurationEndpoint" })
        ]
        [Produces(System.Net.Mime.MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(OptionsResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Get()
        {
            return Ok(new OptionsResponse
            {
                ServiceA = _serviceALogic.GetOptions(),
                ServiceB = _serviceBLogic.GetOptions(),
                ServiceC = _serviceCLogic.GetOptions()
            });
        }

        public class OptionsResponse
        {
            public object ServiceA { get; set; }
            public object ServiceB { get; set; }
            public object ServiceC { get; set; }
            
        }
    }
}
