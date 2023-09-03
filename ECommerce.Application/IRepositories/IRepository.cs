using Microsoft.EntityFrameworkCore;

namespace ECommerce.Application.IRepositories;

public interface IRepository<T> where T : class
{
    DbSet<T> Table { get; }
}
