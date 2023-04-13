using System.ComponentModel.DataAnnotations;

namespace NiN3KodeAPI.Entities
{
    public class BaseEntity : BaseIdEntity
    {
        [StringLength(255)]
        public string Navn { get; set; }
    }
}
