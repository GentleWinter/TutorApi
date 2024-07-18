
using Microsoft.Extensions.DependencyInjection;
using Tutor.Application.Services.Interfaces;
using Tutor.Application.Services;

namespace Tutor.Application.IoC
{
    public static class ServicesIoC
    {
        public static IServiceCollection AddServices(this  IServiceCollection services)
        {
            services.AddScoped<ITutorService, TutorService>();

            return services;
        }
    }
}
