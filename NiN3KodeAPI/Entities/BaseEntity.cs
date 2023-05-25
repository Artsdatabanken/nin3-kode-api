using System.ComponentModel.DataAnnotations;

namespace NiN3KodeAPI.Entities
{
    public abstract class BaseEntity :BaseIdEntity
    {
        //[Key]
        //public Guid Id { get; set; }
        //public Domene Version { get; set; }
        [StringLength(255)]
        public string Kode { get; set; }
        public string? Navn { get; set; }
    }
}
