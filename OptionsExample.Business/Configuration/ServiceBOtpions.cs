using System.ComponentModel.DataAnnotations;

namespace OptionsExample.Business.Configuration
{
    public class ServiceBOtpions : IServiceOptions
    {
        [Required(ErrorMessage = "Service Url is Required", AllowEmptyStrings = false)]
        [Url]
        public string ServiceUrl { get; set; }
        public string AppIdentifier { get; set; }
    }
}
