using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NiN3.Core.Models;
using NiN3.Core.Models.DTOs.rapport;
using NiN3.Infrastructure.DbContexts;
using NiN3.Infrastructure.in_data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiN3.Core.Models;
using NiN3.Core.Models.Enums;
using NiN3.Infrastructure.Mapping;

namespace NiN3.Infrastructure.Services
{
    public class RapportService : IRapportService
    {
        private readonly ILogger<RapportService> _logger;
        private readonly NiN3DbContext _context;
        private IConfiguration _conf;
        private IMapper _mapper;
        private NiN3DbContext inmemorydb;

        public RapportService(NiN3DbContext context, ILogger<RapportService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public List<KodeoversiktDto> GetKodeSummary(string versjon)
        {
            var mapper = NiNkodeMapper.Instance;
            var kodeoversiktDtoList = new List<KodeoversiktDto>();
            var kodeoversiktList = new List<Kodeoversikt>();
            var typer = _context.Type.Select(t => new Kodeoversikt()
            {
                Kortkode = t.Kode,
                Langkode = t.Langkode,
                Navn = $"{EnumUtil.ToDescriptionBlankIfNull(t.Typekategori2)}",
                Klasse = "Type"
            }).ToList(); //todo: where versjon 3.0
            kodeoversiktList.AddRange(typer);
            var hovedtypegrupper = _context.Hovedtypegruppe.Select(htg => new Kodeoversikt()
            {
                Kortkode = htg.Kode,
                Langkode = htg.Langkode,
                Navn = htg.Navn,
                Klasse = "Hovedtypegruppe"
            }).ToList();
            kodeoversiktList.AddRange(hovedtypegrupper);
            var hovedtyper = _context.Hovedtype.Select(htg => new Kodeoversikt()
            {
                Kortkode = htg.Kode,
                Langkode = htg.Langkode,
                Navn = htg.Navn,
                Klasse = "Hovedtypegruppe"
            }).ToList();
            kodeoversiktList.AddRange(hovedtyper);
            var grunntyper = _context.Grunntype.Select(htg => new Kodeoversikt()
            {
                Kortkode = htg.Kode,
                Langkode = htg.Langkode,
                Navn = htg.Navn,
                Klasse = "Grunntype"
            }).ToList();
            kodeoversiktList.AddRange(grunntyper);
            var variabler = _context.Variabel.Select(htg => new Kodeoversikt()
            {
                Kortkode = htg.Kode,
                Langkode = htg.Langkode,
                Navn = htg.Navn,
                Klasse = "Variabel"
            }).ToList();
            kodeoversiktList.AddRange(variabler);
            var variabelnavn = _context.Variabelnavn.Select(htg => new Kodeoversikt()
            {
                Kortkode = htg.Kode,
                Langkode = htg.Langkode,
                Navn = htg.Navn,
                Klasse = "Variabelnavn"
            }).ToList();
            kodeoversiktList.AddRange(variabelnavn);
            foreach (var t in kodeoversiktList) { 
                kodeoversiktDtoList.Add(mapper.Map(t));
            }
            return kodeoversiktDtoList;
        }

        public string MakeKodeoversiktCSV(string versjon) {
            var kodeoversiktDtoList = GetKodeSummary(versjon);
            var csv = new StringBuilder();
            csv.AppendLine("Klasse;Navn;Kortkode;Langkode");
            foreach (var kodeoversiktDto in kodeoversiktDtoList)
            {
                var newLine = $"{kodeoversiktDto.Klasse};{kodeoversiktDto.Navn};{kodeoversiktDto.Kortkode};{kodeoversiktDto.Langkode}";
                csv.AppendLine(newLine);
            }
            return csv.ToString();
        }
    }
}
