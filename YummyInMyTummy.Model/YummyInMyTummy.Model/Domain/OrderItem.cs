namespace YummyInMyTummy.Model.Domain;

public class OrderItem : Entity
{
    public required Order Order { get; set; }
    public int Amount { get; set; }
    public required Food Food { get; set; }
}


