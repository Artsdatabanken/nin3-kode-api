using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NiN3.Core.Models;
using NiN3.Core.Models.DTOs;
using NiN3.Core.Models.DTOs.type;
using NiN3.Core.Models.DTOs.variabel;
using NiN3.Infrastructure.DbContexts;
using NiN3.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Infrastructure.Services
{
    public class VariabelApiService : IVariabelApiService
    {
        private readonly NiN3DbContext _context;
        private readonly ILogger<VariabelApiService> _logger;
        private NiN3DbContext inmemorydb;
        private ILogger<VariabelApiService> logger;
        private IMapper _mapper;

        /*public VariabelApiService(NiN3DbContext context, ILogger<VariabelApiService> logger)
        {
            _context = context;
            _logger = logger;

        }*/
        public VariabelApiService(NiN3DbContext context, ILogger<VariabelApiService> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public VersjonDto AllCodes(string versjon)
        {
            Versjon _versjon = _context.Versjon.Where(v => v.Navn == versjon)
                .Include(v => v.Variabler.OrderBy(v => v.Langkode))
                .ThenInclude(variabel => variabel.Variabelnavn)
                .Include(v => v.Variabler.OrderBy(v => v.Langkode))
                .ThenInclude(variabel => variabel.Variabelnavn)
                .ThenInclude(variabelnavn => variabelnavn.VariabelnavnMaaleTrinn)
                .ThenInclude(maaletrinn => maaletrinn.Maaleskala)
                .Include(v => v.Variabler.OrderBy(v => v.Langkode))
                .ThenInclude(variabel => variabel.Variabelnavn)
                .ThenInclude(variabelnavn => variabelnavn.VariabelnavnMaaleTrinn)
                .ThenInclude(maaletrinn => maaletrinn.Trinn)
                .Select(v => new Versjon { Id = v.Id, Navn = v.Navn, Variabler = v.Variabler })
                .AsNoTracking()
                .FirstOrDefault();
            return NiNkodeMapper.Instance.Map(_versjon);
            //return _mapper.Map<VersjonDto>(_versjon);
        }

        public KlasseDto GetVariabelKlasse(string kortkode, string versjon) {
            var alleKortkoder = _context.AlleKortkoder.Where(a => a.Kortkode == kortkode && a.Versjon.Navn == versjon).FirstOrDefault();
            return alleKortkoder != null ? NiNkodeMapper.Instance.Map(alleKortkoder) : null;
        }

        public VariabelDto GetVariabelByKortkode(string kode, string versjon) {
            //TODO: Implement
            Variabel variabel = _context.Variabel.Where(v => v.Kode == kode && v.Versjon.Navn == versjon)
                .Include(variabel => variabel.Variabelnavn)
                .ThenInclude(variabelnavn => variabelnavn.VariabelnavnMaaleTrinn)
                .ThenInclude(maaletrinn => maaletrinn.Maaleskala)
                .Include(variabel => variabel.Variabelnavn)
                .ThenInclude(variabelnavn => variabelnavn.VariabelnavnMaaleTrinn)
                .ThenInclude(maaletrinn => maaletrinn.Trinn)
                .AsNoTracking()
                .FirstOrDefault();
            //return new VariabelnavnDto();
            return variabel != null ? NiNkodeMapper.Instance.Map(variabel) : null;
        }

        public VariabelnavnDto GetVariabelnavnByKortkode(string kode, string versjon)
        {
            Variabelnavn variabelnavn = _context.Variabelnavn.Where(v => v.Kode == kode && v.Versjon.Navn == versjon)
                .Include(variabelnavn => variabelnavn.VariabelnavnMaaleTrinn)
                .ThenInclude(maaletrinn => maaletrinn.Maaleskala)
                .Include(variabelnavn => variabelnavn.VariabelnavnMaaleTrinn)
                .ThenInclude(maaletrinn => maaletrinn.Trinn)
                .AsNoTracking()
                .FirstOrDefault();
            //return new VariabelnavnDto();
            return variabelnavn != null ? NiNkodeMapper.Instance.Map(variabelnavn) : null;
        }
    }
}