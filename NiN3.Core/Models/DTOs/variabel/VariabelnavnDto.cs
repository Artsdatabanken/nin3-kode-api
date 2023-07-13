using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core.Models.DTOs.variabel
{
    public class VariabelnavnDto
    {
        public string Navn { get; set; }
        public KodeDto Kode { get; set; } = new KodeDto();
        public string Variabelkategori2 { get; set; }
        public string Variabeltype { get; set; }
        public string Variabelgruppe { get; set; }
    }
}
