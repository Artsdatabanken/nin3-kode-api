using NiN3.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core.Models
{
    public class Kartleggingsenhet
    {
        public Guid Id { get; set; }
        public string Navn { get; set; }
        public string Kode { get; set; }
        public MaalestokkEnum Maalestokk { get; set; }
        public ICollection<Grunntype> Grunntyper { get; set; } = new List<Grunntype>();
        public Versjon Versjon { get; set; }
    }
}
