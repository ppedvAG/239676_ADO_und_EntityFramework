namespace YummyInMyTummy.Model.Domain;

public class Pizza : Food
{
    public List<PizzaSize> OfferedSizes { get; set; } = new List<PizzaSize>();

    public virtual ICollection<Topping> Toppings { get; set; } = new HashSet<Topping>();
}

public enum PizzaSize
{
    r28cm,
    r33cm,
    r40cm,
    s33x46cm,
    s60x40cm,
}

    


