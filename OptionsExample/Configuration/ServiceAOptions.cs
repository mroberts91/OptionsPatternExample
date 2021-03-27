using System.ComponentModel.DataAnnotations;

namespace OptionsExample.Configuration
{
    public class ServiceAOptions : IServiceOptions
    {
        [Required(ErrorMessage = "Service Url is Required", AllowEmptyStrings = false)]
        [Url]
        public string ServiceUrl { get; set ; }
        public string AppIdentifier { get; set; }
    }
}
