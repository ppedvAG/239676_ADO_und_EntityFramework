using System;
using System.Collections.Generic;

namespace EfCoreDbFirst.Models;

public partial class Abteilungen
{
    public int Id { get; set; }

    public string Bezeichnung { get; set; } = null!;

    public virtual ICollection<Mitarbeiter> Mitarbeiters { get; set; } = new List<Mitarbeiter>();
}
