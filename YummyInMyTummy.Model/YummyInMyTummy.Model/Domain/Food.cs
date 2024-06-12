namespace YummyInMyTummy.Model.Domain;

public class Food : Entity
{
    public string Name { get; set; } = string.Empty;
    public decimal Preis { get; set; }
    public int KCal { get; set; }
    public bool IsVegan { get; set; }
    public bool IsVegetarian { get; set; }
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
}
