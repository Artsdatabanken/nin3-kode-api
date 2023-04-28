using NiN3KodeAPI.Entities.Lookupdata;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiN3KodeAPI.Entities
{
    [Table("Hovedtype")]
    public class Hovedtype : BaseEntity
    {
        public string Delkode { get; set; }
        public Prosedyrekategori Prosedyrekategori { get; set; }
        public Hovedtypegruppe Hovedtypegruppe { get; set; }
    }
}
