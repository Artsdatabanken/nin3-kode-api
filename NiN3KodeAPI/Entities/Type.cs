using NiN3KodeAPI.Entities.Lookupdata;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiN3KodeAPI.Entities
{
    [Table("Type")]
    public class Type : BaseIdEntity
    {
        public Ecosystnivaa Ecosystnivaa { get; set; }
        public Typekategori Typekategori { get; set; }
        public Typekategori2? Typekategori2 { get; set;}
        public string Kode { get; set; } 
    }
}