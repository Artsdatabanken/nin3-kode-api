using NiN3KodeAPI.Entities.Enums;
using NiN3KodeAPI.Entities.Lookupdata;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiN3KodeAPI.Entities
{
    public class Hovedtype //: BaseEntity
    {
        public Guid Id { get; set; }
        [Required]
        public Domene Domene { get; set; }
        public string Delkode { get; set; }
        [StringLength(255)]
        public string Kode { get; set; }
        public string? Navn { get; set; }
        public ProsedyrekategoriEnum Prosedyrekategori { get; set; }
        public Hovedtypegruppe Hovedtypegruppe { get; set; }
    }
}
