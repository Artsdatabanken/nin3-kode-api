using Microsoft.EntityFrameworkCore;
using NiN3.Core.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiN3.Core.Models
{

    [Index(nameof(Kode), IsUnique = false)]
    public class Hovedtypegruppe //: BaseEntity
    {
        public Guid Id { get; set; }
        [Required]
        public Versjon Versjon { get; set; }
        public string Delkode { get; set; }
        [StringLength(255)]
        public string Kode { get; set; }
        public string? Langkode { get; set; }
        public string? Navn { get; set; }
        public Typekategori2Enum? Typekategori2 { get; set; }
        public Typekategori3Enum? Typekategori3 { get; set; }
        [ForeignKey("TypeId")]
        public Type Type { get; set; }
        public ICollection<Hovedtype> Hovedtyper { get; set; }
    }   
}