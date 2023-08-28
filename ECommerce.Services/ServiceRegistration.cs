using ECommerce.Application.Interfaces;
using ECommerce.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Services;

public static class ServiceRegistration
{
    public static void AddServices(this IServiceCollection services)
    {
        services.AddSingleton<IProductService, ProductService>();
    }
}
