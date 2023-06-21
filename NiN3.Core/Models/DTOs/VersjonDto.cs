using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Core.Models.DTOs
{
    public class VersjonDto
    {
        public string Navn { get; set; }
        public ICollection<TypeDto> Typer { get; set; }
    }
}
