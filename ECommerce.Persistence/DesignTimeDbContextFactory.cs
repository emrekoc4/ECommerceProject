using ECommerce.Domain.Constant;
using ECommerce.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ECommerce.Persistence;

//public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceDbContext>
//{
//    IConfiguration _configuration;

//    public DesignTimeDbContextFactory(IConfiguration configuration)
//    {
//        _configuration = configuration;
//    }

//    public ECommerceDbContext CreateDbContext(string[] args)
//    {
//        DbContextOptionsBuilder<ECommerceDbContext> optionsBuilder = new();
//        optionsBuilder.UseNpgsql(_configuration.GetConnectionString(CustomTypes.ECommerceDbPostgres));
//        return new(optionsBuilder.Options);
//    }
//}
