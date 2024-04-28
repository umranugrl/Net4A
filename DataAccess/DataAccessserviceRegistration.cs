using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class DataAccessserviceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, EfProductRepository>();//dataaccess
            services.AddScoped<ICategoryRepository, EfCategoryRepository>();//dataaccess
            services.AddDbContext<BaseDbContext>();//dataaccess

            return services;
        }
    }
}