using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AtlanticoAPI.Application
{
    public static class DependencyInjection
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {

            //#region COURSE CHARACTERIZATIONS

            //services.AddTransient<ICourseService, CourseService>();

            //#endregion


            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
