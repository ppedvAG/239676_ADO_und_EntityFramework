using System;
using System.Collections.Generic;

namespace EfCoreDbFirst.Models;

public partial class Kunden
{
    public int Id { get; set; }

    public string KundenNummer { get; set; } = null!;

    public int? AnsprechpartnerId { get; set; }

    public DateOnly? Aaaa { get; set; }

    public virtual Mitarbeiter? Ansprechpartner { get; set; }

    public virtual Person IdNavigation { get; set; } = null!;
}
