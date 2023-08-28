using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities;

namespace ECommerce.Services.Concretes;

public class ProductService : IProductService
{
    public List<Product> GetAll()
    {
        return new List<Product>();
    }
}
