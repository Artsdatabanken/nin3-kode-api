using System.ComponentModel.DataAnnotations;

namespace NiN3KodeAPI.Entities.Lookupdata
{
    public abstract class Oppslagstype
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Kode {get; set; }
        public string Beskrivelse { get; set; }
    }
}
