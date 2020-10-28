namespace OptionsExample.Business.Configuration
{
    public interface IServiceOptions
    {
        string ServiceUrl { get; set; }
        string ServiceUserId { get; set; }
    }
}
