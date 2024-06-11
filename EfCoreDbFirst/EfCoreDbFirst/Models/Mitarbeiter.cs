using System;
using System.Collections.Generic;

namespace EfCoreDbFirst.Models;

public partial class Mitarbeiter
{
    public int Id { get; set; }

    public string Job { get; set; } = null!;

    public virtual Person IdNavigation { get; set; } = null!;

    public virtual ICollection<Kunden> Kundens { get; set; } = new List<Kunden>();

    public virtual ICollection<Abteilungen> Abteilungens { get; set; } = new List<Abteilungen>();
}
