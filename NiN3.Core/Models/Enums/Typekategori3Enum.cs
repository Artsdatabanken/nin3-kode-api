using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NiN3.Core.Models.Enums
{
    public enum Typekategori3Enum
    {
        [Display(Name = "vannmassesystemer")]
        VM,
        [Display(Name = "mark- og bunnsystemer")]
        MB
    }
}
