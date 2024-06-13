namespace YummyInMyTummy.Model.Domain;

public class Order : Entity
{
    public DateTime OrderDate { get; set; } = DateTime.Now;

    public string Notes { get; set; }
    public OrderStatus Status { get; set; }
    public virtual Address? DeliveryAddress { get; set; }
    public virtual required Address PaymentAddress { get; set; }
    public virtual ICollection<OrderItem> Items { get; set; } = new HashSet<OrderItem>();
}

public enum OrderStatus
{
    New,
    Accepted,
    Preparing,
    Delivering,
    Delivered = -1,
    Aborted = -2,
    Declined = -3,
    Lost = -4
}


