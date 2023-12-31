﻿using ECommerce.Domain.Entities.BaseEntity;

namespace ECommerce.Domain.Entities;

public class Product : BaseEntity<Guid>
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public long Price { get; set; }
    public ICollection<Order> Orders { get; set; }
}
