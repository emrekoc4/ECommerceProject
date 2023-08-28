using ECommerce.Domain.Entities.BaseEntity;

namespace ECommerce.Domain.Entities;

public class Product : BaseEntity<Guid>
{
    public string Name { get; set; }
}
