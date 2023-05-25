using System.ComponentModel.DataAnnotations;

namespace NiN3KodeAPI.Entities.Enums
{
    public enum TypekategoriEnum
    {
        [Display(Name = "livsmedium")]
        LI,
        [Display(Name = "landformvariasjon")]
        LV,
        [Display(Name = "marine vannmasser")]
        MV,
        [Display(Name = "primært økodiversitetsnivå")]
        PE,
        [Display(Name = "sekundært økodiversitetsnivå")]
        SE
    }
}
