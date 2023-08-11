using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NiN3.Core.Models;
using NiN3.Core.Models.DTOs;
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
            var mapper = NiNkodeMapper.Instance;
            Versjon _versjon = _context.Versjon.Where(v => v.Navn == versjon)
                .Include(v => v.Variabler.OrderBy(v => v.Kode))
                .ThenInclude(variabel => variabel.Variabelnavn)
                .Select(v => new Versjon { Id = v.Id, Navn = v.Navn, Variabler = v.Variabler })
                .AsNoTracking()
                .FirstOrDefault();
            return mapper.Map(_versjon);
        }
    }
}