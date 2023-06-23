using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NiN3.Core.Models.Enums
{
    public enum TypekategoriEnum
    {
        [Description("livsmedium")]
        LI,
        [Description("landformvariasjon")]
        LV,
        [Description("marine vannmasser")]
        MV,
        [Description("primært økodiversitetsnivå")]
        PE,
        [Description("sekundært økodiversitetsnivå")]
        SE
    }
}
