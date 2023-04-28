using System.ComponentModel.DataAnnotations.Schema;

namespace NiN3KodeAPI.Entities
{
    [Table("Undertype")]
    public class Undertype : BaseEntity
    {
        public Hovedtypegruppe Hovedtypegruppe { get; set; }
        public Hovedtype Hovedtype { get; set; }
        public Grunntype Grunntype { get; set; }   
    }
}
