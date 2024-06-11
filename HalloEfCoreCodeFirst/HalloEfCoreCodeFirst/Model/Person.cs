namespace HalloEfCoreCodeFirst.Model
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime GebDatum { get; set; }
    }

}
