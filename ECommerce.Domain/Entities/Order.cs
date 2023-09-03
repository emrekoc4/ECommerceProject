using ECommerce.Domain.Entities.BaseEntity;

namespace ECommerce.Domain.Entities;

public class Order : BaseEntity<Guid>
{
    public string Description { get; set; }
    public string Address { get; set; }
    public ICollection<Product> Products { get; set; }
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
}
