using System.ComponentModel;

namespace NiN3.Core.Models.Enums
{
    public enum EnhetEnum
    {
        [Description("binær")]
        B,
        [Description("grader")]
        G,
        [Description("observert antall")]
        OA,
        [Description("prosent")]
        P,
        [Description("tetthet")]
        T,
        [Description("ukjent, ikke angitt")]
        U,
        [Description("Variabelspesifikk trinndeling, ikke-ordnet faktorvariabel")]
        VSI,
        [Description("Variabelspesifikk trinndeling, ordnet faktorvariabel")]
        VSO
    }
}