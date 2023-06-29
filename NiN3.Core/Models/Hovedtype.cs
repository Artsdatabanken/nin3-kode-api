using Microsoft.EntityFrameworkCore;
using NiN3.Core.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiN3.Core.Models
{
    [Index(nameof(Kode), IsUnique = false)]
    public class Hovedtype //: BaseEntity
    {
        public Guid Id { get; set; }
        [Required]
        public Versjon Versjon { get; set; }
        public string Delkode { get; set; }
        [StringLength(255)]
        public string Kode { get; set; }
        public string? Navn { get; set; }
        public ProsedyrekategoriEnum Prosedyrekategori { get; set; }
        [ForeignKey("HovedtypegruppeId")]
        public Hovedtypegruppe Hovedtypegruppe { get; set; }
        public ICollection<Grunntype> Grunntyper { get; set; }
    }
}
