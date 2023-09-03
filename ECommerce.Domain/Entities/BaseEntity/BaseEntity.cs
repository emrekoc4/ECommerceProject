namespace ECommerce.Domain.Entities.BaseEntity;

public class BaseEntity<TKey>
{
    public TKey Id { get; set; }
    public DateTime CreateedDate { get; set; }
}
