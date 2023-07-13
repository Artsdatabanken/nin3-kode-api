using NiN3.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core.Models.DTOs.variabel
{
    public class VariabelDto
    {
        public KodeDto Kode { get; set; } = new KodeDto();
        public string Navn { get; set; }

        public string Kategori { get; set; }
        public string Ecosystnivaa { get; set; }
        public string Variabelkategori { get; set; }

        public ICollection<VariabelnavnDto> Variabelnavn { get; set; } = new List<VariabelnavnDto>();

    }
}
