using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core.Models.DTOs
{
    [JsonObject("Type")]
    public class TypeDto
    {
        public string Navn { get; set; }
        public string Kategori { get; set; } = "Type";
        public KodeDto Kode { get; set; } = new KodeDto();
        public TypeDto(String navn, KodeDto kode, String kategori="Type") {
            Navn = navn;
            Kategori = kategori;
        }

        public TypeDto() { }    
    }
}
