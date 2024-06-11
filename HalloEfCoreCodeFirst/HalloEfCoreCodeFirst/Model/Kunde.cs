using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HalloEfCoreCodeFirst.Model
{
    public class Kunde : Person
    {
        [Column("KundenNummer")]
        [MaxLength(12)]
        public string KdNummer { get; set; } = string.Empty;
        public virtual Mitarbeiter? Ansprechpartner { get; set; }
    }

}
