using System;
using System.Collections.Generic;
using System.Text;

namespace AtlanticoAPI.Infrastructure.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApiDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Default")));


            // Identity
            //services.AddIdentity<User, Role>().AddEntityFrameworkStores<ApiDbContext>().AddDefaultTokenProviders();

            // Unit Of Work
            services.AddTransient<IUnitOfWork, UnitOfWork>();



            #region Repositories

            services.AddTransient<ICourseRepository, CourseRepository>();

            #endregion

            return services;
        }
    }
}
