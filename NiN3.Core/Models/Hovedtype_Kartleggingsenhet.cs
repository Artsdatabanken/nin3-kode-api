using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core.Models
{
    public class Hovedtype_Kartleggingsenhet
    {
        public Guid Id { get; set; }
        Versjon versjon { get; set; }

        Kartleggingsenhet kartleggingsenhet { get; set; }
        Hovedtype hovedtype { get; set; }
    }
}
