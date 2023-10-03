using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;
using System.Runtime.Serialization;

namespace NiN3.Core.Models.Enums
{
    /// <summary>
    /// Testing summary for ecosystnivaa
    /// </summary>
    public enum EcosystnivaaEnum
    {
        [EnumMember(Value = "A")]
        [Description("abiotisk")]
        A,
        [EnumMember(Value = "B")]
        [Description("biotisk")]
        B,
        [EnumMember(Value = "C")]
        [Description("økodiversitet")]
        C
    }
}
