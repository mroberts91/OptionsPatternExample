﻿namespace OptionsExample.Configuration
{
    public interface IServiceOptions
    {
        string ServiceUrl { get; set; }
        string AppIdentifier { get; set; }
        object GetOptions() => new { ServiceUrl, AppIdentifier };
    }
}
