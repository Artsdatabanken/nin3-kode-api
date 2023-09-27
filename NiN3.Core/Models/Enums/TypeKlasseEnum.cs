using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace NiN3.Core.Models.Enums
{
    public enum TypeKlasseEnum
    {
        [Description("Type")]
        T,
        [Description("Hovedtypegruppe")]
        HTG,
        [Description("Hovedtype")]
        HT,
        [Description("Grunntype")]
        GT,
        [Description("Kartleggingsenhet")]
        KE,
    }
}
