namespace YummyInMyTummy.Model.Domain;

public class Pizza : Food
{
    public virtual ICollection<Topping> Toppings { get; set; } = new HashSet<Topping>();
}


