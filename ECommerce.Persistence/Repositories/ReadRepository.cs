using ECommerce.Application.IRepositories;
using ECommerce.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommerce.Persistence.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : class
{
    ECommerceDbContext _dbContext;

    public ReadRepository(ECommerceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public DbSet<T> Table => _dbContext.Set<T>();

    public IQueryable<T> GetAll(bool tracking = true)
    {
        IQueryable<T> query = Table.AsQueryable();

        if (!tracking)
            query = query.AsNoTracking();

        return query;
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> predicate, bool tracking = true)
    {
        IQueryable<T> query = Table.Where(predicate);
       
        if (!tracking)
            query = query.AsNoTracking();

        return query;
    }

    public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, bool tracking = true)
    {
        IQueryable<T> query = Table.Where(predicate);

        if (!tracking)
            query = query.AsNoTracking();

        return await query.FirstOrDefaultAsync();
    }

    public async Task<T> GetByIdAsync(string id, bool tracking = true)
    {
        return await Table.FindAsync(id);
    }
}
