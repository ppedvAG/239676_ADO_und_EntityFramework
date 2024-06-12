namespace YummyInMyTummy.Model.Domain;

public class Order : Entity
{
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public Address? DeliveryAddress { get; set; }
    public required Address PaymentAddress { get; set; }
    public virtual ICollection<OrderItem> Items { get; set; } = new HashSet<OrderItem>();
}


