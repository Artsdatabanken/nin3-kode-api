using System.ComponentModel.DataAnnotations;

namespace NiN3KodeAPI.Entities.Lookupdata
{
    public class Oppslagstype
    {
        [Key]
        public Guid Id { get; set; }
        public string Kode {get; set; }
        public string Beskrivelse { get; set; }
    }
}
