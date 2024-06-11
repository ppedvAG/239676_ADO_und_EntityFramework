using System;
using System.Collections.Generic;

namespace EfCoreDbFirst.Models;

public partial class Person
{
    public int Id { get; set; }

    public string DerName { get; set; } = null!;

    public DateTime GebDatum { get; set; }

    public virtual Kunden? Kunden { get; set; }

    public virtual Mitarbeiter? Mitarbeiter { get; set; }
}
