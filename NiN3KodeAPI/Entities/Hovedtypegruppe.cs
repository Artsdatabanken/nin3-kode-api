using NiN3KodeAPI.Entities.Enums;
using NiN3KodeAPI.Entities.Lookupdata;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiN3KodeAPI.Entities
{

    [Index(nameof(Kode), IsUnique = false)]
    public class Hovedtypegruppe //: BaseEntity
    {
        public Guid Id { get; set; }
        [Required]
        public Domene Domene { get; set; }
        public string Delkode { get; set; }
        [StringLength(255)]
        public string Kode { get; set; }
        public string? Navn { get; set; }
        public Typekategori2Enum? Typekategori2 { get; set; }
    }
}