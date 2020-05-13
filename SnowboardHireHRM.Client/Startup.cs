using System.Net.Http;
using SnowboardHireHRM.Server;
using SnowboardHireHRM.Server.Services;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SnowboardHireHRM.ClientApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<HttpClient>(s =>
            {
                var client = new HttpClient(){ BaseAddress = new System.Uri("https://localhost:44340/") };
                return client;
            });

            //services.AddScoped<IEmployeeDataService, MockEmployeeDataService>();
            services.AddScoped<IEmployeeDataService, EmployeeDataService>();
            services.AddScoped<ICountryDataService, CountryDataService>();
            services.AddScoped<IJobCategoryDataService, JobCategoryDataService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
