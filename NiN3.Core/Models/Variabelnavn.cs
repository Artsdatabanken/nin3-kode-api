using NiN3.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core.Models
{
    public class Variabelnavn
    {
        [Key]
        public Guid Id { get; set; }
        public string Kode { get; set; }
        public string? Langkode { get; set; }
        public Variabelkategori2Enum Variabelkategori2 { get; set; }
        public VariabeltypeEnum Variabeltype { get; set; }
        public VariabelgruppeEnum Variabelgruppe { get; set; }
        public String? Navn { get; set; } = "";
        public Versjon Versjon { get; set; }
        [ForeignKey("VariabelId")]
        public Variabel Variabel { get; set; }
    }
}
