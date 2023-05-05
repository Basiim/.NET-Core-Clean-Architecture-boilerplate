using DemoService.Application.Interfaces;
using DemoService.Application.Modules;
using DemoService.Infrastructure.Implementation;
using DemoService.Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DemoService.Infrastructure.Modules
{
    public static class ApplicationModule
    {
        public static IServiceCollection ConfigureInfraStructure(this IServiceCollection services)
        {
            services.ConfigureApplication();
            services.AddTransient<IDemoServiceProvider, DemoProvider>();
            //services.AddTransient<IDemoProvider, DemoProvider>();
            services.AddTransient<IDemo, Demo>();

            return services;
        }
    }
}
