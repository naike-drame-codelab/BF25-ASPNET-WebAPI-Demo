using Refuge.BLL.Interfaces.Repositories;
using Refuge.BLL.Interfaces.Services;
using Refuge.BLL.Services;
using Refuge.DAL.Repositories;

namespace Refuge.API.Configurations
{
    public static class ServicesExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICatRepository, CatRepository>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICatService, CatService>();
        }
    }
}
