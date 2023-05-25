using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NiN3KodeAPI.Entities
{
    [Table("Domene")]
    public class Domene
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(255)]
        public string Navn { get; set; } = string.Empty;
    }
}