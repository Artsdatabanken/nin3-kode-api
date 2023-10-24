using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core
{
    /* Transient class to hold variabelnavn and måleskala for type -classes on mapping to DTOs */
    public class Variabeltrinn
    {
        public Models.Variabelnavn? Variabelnavn { get; set; }
        public Models.Maaleskala Maaleskala { get; set; }
    }
}
