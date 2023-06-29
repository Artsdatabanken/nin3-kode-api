using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core.Models.DTOs
{
    public class GrunntypeDto
    {
        public string Navn { get; set; }
        public string Kategori { get; set; } = "Grunntype";
        public KodeDto Kode { get; set; }
    }
}
