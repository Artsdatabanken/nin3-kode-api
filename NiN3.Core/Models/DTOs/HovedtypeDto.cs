using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core.Models.DTOs
{
    public class HovedtypeDto
    {
        public string Navn { get; set; }
        public string Kategori { get; set; } = "Hovedtype";
        public KodeDto Kode { get; set; }
        // add icollection of grunntypeDtos
        public ICollection<GrunntypeDto> Grunntyper { get; set; } = new List<GrunntypeDto>();
        public ICollection<KartleggingsenhetDto> Kartleggingsenheter { get; set; } = new List<KartleggingsenhetDto>();
    }
}
