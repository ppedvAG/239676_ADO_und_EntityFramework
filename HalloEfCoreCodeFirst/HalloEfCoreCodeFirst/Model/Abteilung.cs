namespace HalloEfCoreCodeFirst.Model
{
    public class Abteilung
    {
        public int Id { get; set; }
        public string Bezeichnung { get; set; } = string.Empty;
        public virtual ICollection<Mitarbeiter> Mitarbeiter { get; set; } = new HashSet<Mitarbeiter>();
    }

}
