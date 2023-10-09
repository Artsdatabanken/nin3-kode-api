using NiN3.Core.Models.DTOs;
using NiN3.Core.Models.DTOs.type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Infrastructure.Services
{
    public interface IVariabelApiService
    {
        public VersjonDto AllCodes(string versjon);
        public KlasseDto GetVariabelKlasse(string kortkode, string versjon);
    }
}