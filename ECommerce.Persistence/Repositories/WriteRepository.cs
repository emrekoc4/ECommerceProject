using ECommerce.Application.IRepositories;
using ECommerce.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ECommerce.Persistence.Repositories;

public class WriteRepository<T> : IWriteRepository<T> where T : class
{
    ECommerceDbContext _dbContext;

    public WriteRepository(ECommerceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public DbSet<T> Table => _dbContext.Set<T>();

    public async Task<bool> AddAsync(T entity)
    {
        EntityEntry<T> entityEntry = await Table.AddAsync(entity);

        return entityEntry.State == EntityState.Added;
    }

    public async Task<bool> AddRangeAsync(List<T> entities)
    {
        await Table.AddRangeAsync(entities);
        return true;
    }

    public bool Remove(T entity)
    {
        EntityEntry<T> entityEntry = Table.Remove(entity);

        return entityEntry.State == EntityState.Deleted;
    }

    public bool RemoveRange(List<T> entities)
    {
        Table.RemoveRange(entities);

        return true;
    }

    public async Task<bool> RemoveAsync(string id)
    {
        T entity = await Table.FindAsync(id);

        return Remove(entity);
    }

    public bool Update(T entity)
    {
        EntityEntry<T> entityEntry = Table.Update(entity);

        return entityEntry.State == EntityState.Modified;
    }

    public async Task SaveAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
