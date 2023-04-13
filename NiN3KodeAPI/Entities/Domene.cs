using System.ComponentModel.DataAnnotations;

namespace NiN3KodeAPI.Entities
{
    public class Domene
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(255)]
        public string Navn { get; set; } = string.Empty;
    }
}
