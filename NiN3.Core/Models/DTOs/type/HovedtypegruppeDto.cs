using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core.Models.DTOs.type
{
    public class HovedtypegruppeDto
    {
        public string Navn { get; set; }

        public string Kategori { get; set; }
        public KodeDto Kode { get; set; }

        public ICollection<HovedtypeDto> Hovedtyper { get; set; } = new List<HovedtypeDto>();
    }
}
