using System.ComponentModel.DataAnnotations;

namespace NiN3.Core.Models.Enums
{
    public enum Typekategori2Enum
    {
        [Display(Name = "bremassiv")]
        BM,
        [Display(Name = "elveløp")]
        EL,
        [Display(Name = "landformer i fast fjell og løsmasser")]
        FL,
        [Display(Name = "innsjøbasseng")]
        IB,
        [Display(Name = "landskapstype")]
        LA,
        [Display(Name = "natursystem")]
        NA,
        [Display(Name = "naturkompleks")]
        NK,
        [Display(Name = "torvmarksmassiv")]
        TM
    }
}
