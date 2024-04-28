using Business.Abstracts;
using Business.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();//business
            services.AddScoped<ICategoryService, CategoryManager>();//business
            services.AddAutoMapper(Assembly.GetExecutingAssembly());//business

            return services;
        }
    }
}