using System.ComponentModel.DataAnnotations;

namespace NiN3KodeAPI.Entities
{
    public class BaseIdEntity //This class might not be necessary
    {
        [Key]
        public Guid Id { get; set; }

        public Domene Version { get; set; }
    }
}