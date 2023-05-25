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
        public Ecosystnivaa Ecosystnivaa { get; set; }
        public Typekategori Typekategori { get; set; }
        public Typekategori2? Typekategori2 { get; set;}
        public string Kode { get; set; } 
    }
}