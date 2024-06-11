namespace HalloEfCoreCodeFirst.Model
{
    public class Mitarbeiter : Person
    {
        public string Job { get; set; } = string.Empty;
        public virtual ICollection<Kunde> Kunden { get; set; } = new HashSet<Kunde>();
        public virtual ICollection<Abteilung> Abteilungen { get; set; } = new HashSet<Abteilung>();
    }

}
