using NiN3KodeAPI.Entities.Lookupdata;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiN3KodeAPI.Entities
{
    [Table("Grunntype")]
    public class Grunntype : BaseEntity
    {
        public string Delkode { get; set; }
        //public Hovedtypegruppe Hovedtypegruppe { get; set; }
        public Prosedyrekategori Prosedyrekategori { get; set; }
        public Hovedtype Hovedtype { get; set; }

    }
}
