using ECommerce.Domain.Entities.BaseEntity;

namespace ECommerce.Domain.Entities;

public class Customer : BaseEntity<Guid>
{
    public string Name { get; set; }
    public ICollection<Order> Orders { get; set; }
}
