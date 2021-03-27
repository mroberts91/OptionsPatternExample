using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using OptionsExample.Configuration;

namespace OptionsExample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OptionsExample", Version = "v1" });
                c.EnableAnnotations();
            });

            // Performs Data Anotation Validation
            services.AddOptions<ServiceAOptions>()
                    .BindConfiguration("ServiceA")
                    .ValidateDataAnnotations();

            // Performs Data Anotation Validation
            services.AddOptions<ServiceBOptions>()
                    .BindConfiguration("ServiceB")
                    .ValidateDataAnnotations();

            // No validation
            services.AddOptions<ServiceCOptions>()
                    .BindConfiguration("ServiceC");
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Options Example v1");
                c.RoutePrefix = "documentation";
                c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.List);
                c.DocumentTitle = "Options Example API Documentation";
            });
            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
