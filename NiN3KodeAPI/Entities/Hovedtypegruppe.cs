using NiN3KodeAPI.Entities.Lookupdata;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiN3KodeAPI.Entities
{

    [Table("Hovedtypegruppe")]
    public class Hovedtypegruppe : BaseEntity
    {
        public Typekategori2? Typekategori2 { get; set; }
        public string Delkode { get; set; }

    }
}