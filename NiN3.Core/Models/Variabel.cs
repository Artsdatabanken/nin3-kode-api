using NiN3.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core.Models
{
    public class Variabel
    {
        [Key]
        public Guid Id { get; set; }
        public string Kode { get; set; }
        public string? Langkode { get; set; }
        public EcosystnivaaEnum Ecosystnivaa { get; set; }
        public VariabelkategoriEnum Variabelkategori { get; set; }
        public String Navn { get; set; }
        public Versjon Versjon { get; set; }
    }
}