using ECommerce.Application.IRepositories;
using ECommerce.Domain.Entities;
using ECommerce.Persistence.Contexts;

namespace ECommerce.Persistence.Repositories;

public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
{
 
    public CustomerWriteRepository(ECommerceDbContext dbContext) : base(dbContext)
    {
      
    }

}
