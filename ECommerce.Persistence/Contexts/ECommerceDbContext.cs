﻿using ECommerce.Domain.Entities;
using ECommerce.Domain.Entities.BaseEntity;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Persistence.Contexts;

public class ECommerceDbContext : DbContext
{
    public ECommerceDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var datas = ChangeTracker.Entries<BaseEntity<Guid>>();

        foreach (var data in datas)
        {
            _ = data.State switch
            {
                EntityState.Added => data.Entity.CreateedDate = DateTime.UtcNow,
                EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow
            };
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
}
