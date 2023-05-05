using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DemoService.Application.Client.Modules
{
    public static class ApplicationModule
    {
        public static IServiceCollection ConfigureClientApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
