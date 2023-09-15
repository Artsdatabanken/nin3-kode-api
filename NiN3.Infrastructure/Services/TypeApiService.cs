using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NiN.Infrastructure.Services;
using NiN3.Core.Models;
using NiN3.Infrastructure.DbContexts;
using NiN3.Infrastructure.in_data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiN3.Core.Models.DTOs;
using AutoMapper;
using System.ComponentModel.Design;
using NiN3.Infrastructure.Mapping;
using NiN3.Core.Models.DTOs.type;


namespace NiN3.Infrastructure.Services
{
    public class TypeApiService : ITypeApiService
    {
        private readonly ILogger<TypeApiService> _logger;
        private readonly NiN3DbContext _context;
        private IConfiguration _conf;
        private IMapper _mapper;
        private List<CsvdataImporter_htg_ht_gt_mapping> csvdataImporter_Htg_Ht_Gt_Mappings;
        private List<Versjon> Domenes;
        private NiN3DbContext inmemorydb;
        private ILogger<TypeApiService> logger;

        public TypeApiService(NiN3DbContext context, ILogger<TypeApiService> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Retrieves all codes for a given version.
        /// </summary>
        /// <param name="versjon">The version to retrieve codes for.</param>
        /// <returns>A VersjonDto containing all codes for the given version.</returns>
        public async Task<VersjonDto> AllCodesAsync(string versjon)
        {
            var mapper = NiNkodeMapper.Instance;
            var typer =  await _context.Type.ToListAsync();

            Versjon _versjon = await _context.Versjon.Where(v => v.Navn == versjon)
                .Include(v => v.Typer/*.Where(t => t.Kode == "C-PE-NA")*/.OrderBy(t => t.Kode))
                .ThenInclude(type => type.Hovedtypegrupper.OrderBy(htg => htg.Kode))
                .ThenInclude(hovedtypegruppe => hovedtypegruppe.Hovedtyper.OrderBy(ht => ht.Kode))
                .ThenInclude(hovedtype => hovedtype.Grunntyper.OrderBy(t => t.Kode))
                .Include(v => v.Typer)
                .ThenInclude(type => type.Hovedtypegrupper)
                .ThenInclude(hovedtypegruppe => hovedtypegruppe.Hovedtyper)
                .ThenInclude(hovedtype => hovedtype.Hovedtype_Kartleggingsenheter)
                .ThenInclude(Hovedtype_Kartleggingsenheter => Hovedtype_Kartleggingsenheter.Kartleggingsenhet)
                .ThenInclude(kartleggingsenhet => kartleggingsenhet.Grunntyper)
                .FirstAsync();
            return mapper.Map(_versjon);
        }

        public TypeDto GetType(string kode) {
            var mapper = NiNkodeMapper.Instance;
            Core.Models.Type _type = _context.Type.Where(t => t.Kode == kode)
                .Include(type => type.Hovedtypegrupper.OrderBy(htg => htg.Kode))
                    .ThenInclude(hovedtypegruppe => hovedtypegruppe.Hovedtyper.OrderBy(ht => ht.Kode))
                        .ThenInclude(hovedtype => hovedtype.Grunntyper.OrderBy(t => t.Kode))
        .Include(type => type.Hovedtypegrupper)
            .ThenInclude(hovedtypegruppe => hovedtypegruppe.Hovedtyper)
                .ThenInclude(hovedtype => hovedtype.Hovedtype_Kartleggingsenheter)
                .ThenInclude(Hovedtype_Kartleggingsenheter => Hovedtype_Kartleggingsenheter.Kartleggingsenhet)
                .ThenInclude(kartleggingsenhet => kartleggingsenhet.Grunntyper)
             .First();
            return mapper.Map(_type);
        }

        /*
 public VersjonDto AllCodesDummy() {
     //return empty ICollection<VersjonDto>
     var kode1 = new KodeDto { Id = "NA-C-B" };
     var kode2 = new KodeDto { Id = "NA-A-C" };
     var typedto1 = new TypeDto { Navn = "Isbretyper", Kode = kode1 };
     var typedto2 = new TypeDto { Navn = "Stentyper", Kode = kode2 };
     VersjonDto versjon = new VersjonDto { Navn = "3.0", Typer = new List<TypeDto> { typedto1, typedto2 } };
     return versjon;
 }
*/
    }
}
