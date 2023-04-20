using NiN3KodeAPI.Entities.Lookupdata;

namespace NiN3KodeAPI.Entities
{
    public class Type : BaseIdEntity
    {
        public Ecosystnivaa Ecosystnivaa { get; set; }
        public Typekategori Typekategori { get; set; }
        public Typekategori2 Typekategori2 { get; set;}
        public string Kode { get; set; }    
    }
}