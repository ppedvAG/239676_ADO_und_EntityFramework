namespace YummyInMyTummy.Model.Domain;

public class Address : Entity
{
    public string Name1 { get; set; } = string.Empty;
    public string Name2 { get; set; } = string.Empty;
    public int Floor { get; set; }
    public string Street { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public virtual ICollection<Order> AsPayment { get; set; } = new HashSet<Order>();
    public virtual ICollection<Order> AsDelivery { get; set; } = new HashSet<Order>();
}


