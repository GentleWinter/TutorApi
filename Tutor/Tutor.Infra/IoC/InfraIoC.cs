using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tutor.Infra.Contexts;
using Tutor.Infra.Repositories;
using Tutor.Infra.Repositories.Interfaces;

namespace Tutor.Infra.IoC
{
    public static class InfraIoC
    {
        public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Default");

            services.AddDbContext<TutorContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });

            services.AddScoped<DbContext, TutorContext>();
            services.AddScoped<ITutorRepository, TutorRepository>();

            return services;
        }
    }
}
