using AtlanticoAPI.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AtlanticoAPI.Infrastructure.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
        {


            // Unit Of Work
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
