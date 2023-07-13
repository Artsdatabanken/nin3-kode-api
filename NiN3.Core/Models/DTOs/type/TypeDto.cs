using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core.Models.DTOs.type
{
    [JsonObject("Type")]
    public class TypeDto
    {
        public string Navn { get; set; }
        public string Kategori { get; set; }
        public KodeDto Kode { get; set; } = new KodeDto();

        public string Ecosystnivaa { get; set; }

        public string Typekategori { get; set; }

        public string? Typekategori2 { get; set; }

        public ICollection<HovedtypegruppeDto> Hovedtypegrupper { get; set; } = new List<HovedtypegruppeDto>();
    }
}
