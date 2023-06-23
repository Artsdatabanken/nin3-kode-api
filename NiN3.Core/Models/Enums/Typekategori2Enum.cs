using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NiN3.Core.Models.Enums
{
    public enum Typekategori2Enum
    {
        [Description("bremassiv")]
        BM,
        [Description("elveløp")]
        EL,
        [Description("landformer i fast fjell og løsmasser")]
        FL,
        [Description("innsjøbasseng")]
        IB,
        [Description("landskapstype")]
        LA,
        [Description("natursystem")]
        NA,
        [Description("naturkompleks")]
        NK,
        [Description("torvmarksmassiv")]
        TM
    }
}
