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
// q: install AutoMapper from nuget 


namespace NiN3.Infrastructure.Services
{
    public class TypeApiService : ITypeApiService
    {
        private readonly ILogger<TypeApiService> _logger;
        private readonly NiN3DbContext _context;
        private IConfiguration _conf;
        private IMapper _mapper;
        private List<CsvdataImporter_htg_ht_gt_mapping> csvdataImporter_Htg_Ht_Gt_Mappings;
        //private List<Prosedyrekategori> Prosedyrekategoris;
        //private List<Ecosystnivaa> Ecosystnivaas;
        //private List<Typekategori> Typekategoris;
        //private List<Typekategori2> Typekategori2s;
        private List<Versjon> Domenes;
        private IMapper mapper;
        private NiN3DbContext inmemorydb;
        private ILogger<TypeApiService> logger;

        public TypeApiService(IMapper mapper, NiN3DbContext context, ILogger<TypeApiService> logger)
        {
            _context = context;
            _logger = logger;
            //_conf = configuration;
            _mapper = mapper;
            //Versjons = _context.Versjon.ToList();
            //PopulateEntitiesTypeDict();
        }

        public VersjonDto AllCodesDummy() {
            //return empty ICollection<VersjonDto>
            var kode1 = new KodeDto { Id = "NA-C-B" };
            var kode2 = new KodeDto { Id = "NA-A-C" };
            var typedto1 = new TypeDto { Navn = "Isbretyper", Kode = kode1 };
            var typedto2 = new TypeDto { Navn = "Stentyper", Kode = kode2 };
            VersjonDto versjon = new VersjonDto { Navn = "3.0", Typer = new List<TypeDto> { typedto1, typedto2 } };
            return versjon;
        }

        public VersjonDto AllCodes(string versjon)
        {
            //return empty ICollection<VersjonDto>
            //_mapper.
            // q: get versjon from context given navn "3.0"

            //nested load (ThenInclude)
            /*
            var company = context.Companies
             .Include(co => co.Employees).ThenInclude(emp => emp.Employee_Car)
             .Include(co => co.Employees).ThenInclude(emp => emp.Employee_Country)
             .FirstOrDefault(co => co.companyID == companyID); */

            var _versjon = _context.Versjon.Where(v => v.Navn == versjon)
                .Include(v => v.Typer.OrderBy(t => t.Id))               
                .FirstOrDefault();
            var _versjonDto = _mapper.Map<VersjonDto>(_versjon);
            return _mapper.Map<VersjonDto>(_versjonDto);
        }
    }
}
