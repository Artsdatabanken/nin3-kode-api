using NiN3KodeAPI.Entities.Enums;
using NiN3KodeAPI.Entities.Lookupdata;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiN3KodeAPI.Entities
{
    public class Type //: BaseIdEntity
    {
        [Key]
        public Guid Id { get; set; }
        public Domene Domene { get; set; }
        public EcosystnivaaEnum Ecosystnivaa { get; set; }
        public TypekategoriEnum Typekategori { get; set; }
        public Typekategori2Enum? Typekategori2 { get; set;}
        public string Kode { get; set; } 
    }
}