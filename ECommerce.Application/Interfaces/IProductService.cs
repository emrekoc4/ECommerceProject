using ECommerce.Domain.Entities;

namespace ECommerce.Application.Interfaces;

public interface IProductService
{
    List<Product> GetAll();
}
