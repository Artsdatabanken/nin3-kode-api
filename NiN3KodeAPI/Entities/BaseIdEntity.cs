using System.ComponentModel.DataAnnotations;

namespace NiN3KodeAPI.Entities
{
    public class BaseIdEntity
    {
        [Key]
        public Guid Id { get; set; }

        public Domene Version { get; set; }
    }
}
