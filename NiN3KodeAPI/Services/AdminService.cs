﻿using NiN3KodeAPI.Controllers;
using NiN3KodeAPI.DbContexts;
using NiN3KodeAPI.Entities;
using NiN3KodeAPI.Entities.Lookupdata;
using NiN3KodeAPI.in_data;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;
//using NiN3KodeAPI.Migrations;
using Type = NiN3KodeAPI.Entities.Type;
using System;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Newtonsoft.Json;

namespace NiN3KodeAPI.Services
{
    public class AdminService : IAdminService
    {
        private readonly ILogger<AdminService> _logger;
        private readonly NiN3DbContext _context;
        private IConfiguration _conf;
        private List<CsvdataImporter_htg_ht_gt_mapping> csvdataImporter_Htg_Ht_Gt_Mappings;
        private List<Prosedyrekategori> Prosedyrekategoris;
        private List<Ecosystnivaa> Ecosystnivaas;
        private List<Typekategori> Typekategoris;
        private List<Typekategori2> Typekategori2s;
        private List<Domene> Domenes;
        private string AdminToken;
        private readonly Dictionary<string, dynamic> EntitiesTypeDict = new Dictionary<string, dynamic>();

        public AdminService(IConfiguration configuration, NiN3DbContext context, ILogger<AdminService> logger)
        {
            _context = context;
            _logger = logger;
            _conf = configuration;
            //PopulateEntitiesTypeDict();
        }

        public List<string?> Tabeller()
        {
            var tableNames = _context.Model.GetEntityTypes()
                            .Select(t => t.GetTableName())
                            .Distinct()
                            .ToList();
            return tableNames;
        }

        /*
        private void PopulateEntitiesTypeDict() {
            EntitiesTypeDict.Add("", typeof(Ecosystnivaa));
            EntitiesTypeDict.Add("", typeof(Maalestokk));
            EntitiesTypeDict.Add("", typeof(Prosedyrekategori));
            EntitiesTypeDict.Add("", typeof(a));
            EntitiesTypeDict.Add("", typeof(Ecosystnivaa));
            EntitiesTypeDict.Add("", typeof(Ecosystnivaa));

        }*/


        public string Tabelldata(string tablename)
        {
            /*  "Domene",
                  "Grunntype",
                  "Hovedtype",
                  "Hovedtypegruppe",
                  "Ecosystnivaa",
                  "Maalestokk",
                  "Prosedyrekategori",
                  "Typekategori",
                  "Typekategori2",
                  "Typekategori3",
                  "Variabelkategori",
                  "Variabelkategori2",
                  "Variabeltype",
                  "Type",
                  "Undertype"*/
            string res ="";
            dynamic rs = new List<dynamic>();
            switch (tablename)
            {
                case "Domene":
                    //rs = _context.Domene.Cast<Object>().ToList();
                    rs = _context.Domene.ToList();
                    //res = JsonConvert.SerializeObject(rs);
                    break;
                case "Grunntype":
                    rs = _context.Grunntype.ToList();
                    //res = JsonConvert.SerializeObject(rs);
                    break;
                case "Hovedtype":
                    rs = _context.Hovedtype.ToList();
                    //res = JsonConvert.SerializeObject(rs);
                    break;
                case "Hovedtypegruppe":
                    rs = _context.Hovedtypegruppe.ToList();
                    //res = JsonConvert.SerializeObject(rs);
                    break;
                case "Ecosystnivaa":
                    rs = _context.Ecosystnivaa.ToList();
                    //res = JsonConvert.SerializeObject(rs);
                    break;
                case "Maalestokk":
                    rs = _context.Maalestokk.ToList();

                    //res = JsonConvert.SerializeObject(rs);
                    break;
                case "Prosedyrekategori":
                    rs = _context.Prosedyrekategori.ToList();
                    //res = JsonConvert.SerializeObject(rs);
                    break;
                case "Typekategori":
                    rs = _context.Typekategori.ToList();
                    //res = JsonConvert.SerializeObject(rs);
                    break;
                case "Typekategori2":
                    rs = _context.Typekategori2.ToList();
                    //res = JsonConvert.SerializeObject(rs);
                    break;
                case null:
                    break;
            }
            //return rs;
            return JsonConvert.SerializeObject(rs);
        }
        //return _context.typeof(t).FromSqlRaw("Select * from {0}", tablename).ToList();
        //_context.Set<t>().
    




    //fpublic List<string?> Select 

    public async Task<IEnumerable<Domene>> HentDomenerAsync()
    {
        return await _context.Domene.OrderBy(c => c.Navn).ToListAsync();
    }

    public void DoMigrations()
    {// from adminController.
        _context.Database.Migrate();
    }


    public bool OpprettInitDbAsync()
    {
        //throw new NotImplementedException();
        LoadLookupData();
        LoadHtg_Ht_Gt_Mappings();
        try
        {
            GetTypecsvData();
            _logger.LogInformation("Import of Types. Done");
            GetHovedtypeGruppeData();
            _logger.LogInformation("Import of HTGdata. Done");
            //todo-sat: load mapping csv

            GetHovedtypeData();
            _logger.LogInformation("Import of HTdata. Done");

            GetGrunntypedata();
            _logger.LogInformation("Import of GTdata. Done");
        }
        catch (Exception ex)
        {
            _logger.LogError("Error importing data from csv ; " + ex.Message);
        }
        return true;
    }



    private void LoadLookupData()
    {
        Prosedyrekategoris = _context.Prosedyrekategori.ToList();
        Ecosystnivaas = _context.Ecosystnivaa.ToList();
        Typekategoris = _context.Typekategori.ToList();
        Typekategori2s = _context.Typekategori2.ToList();
        Domenes = _context.Domene.ToList();
    }

    private void LoadHtg_Ht_Gt_Mappings()
    {
        csvdataImporter_Htg_Ht_Gt_Mappings = CsvdataImporter_htg_ht_gt_mapping.ProcessCSV("in_data/htg_ht_gt_mapping.csv");
        _logger.LogInformation("Htg_Ht_Gt_Mapping lastet");
    }

    private void GetGrunntypedata()
    {
        if (_context.Grunntype.Count() == 0)
        {
            //todo-sat: do impl. 
            var grunntyper = CsvdataImporter_Grunntype.ProcessCSV("in_data/grunntyper.csv");
            var domene = Domenes.FirstOrDefault(s => s.Navn == "3.0");// todo-sat: get this from config or even better, get from request parameter -value.
            foreach (var gt in grunntyper)
            {
                var psk = Prosedyrekategoris.FirstOrDefault(s => s.Kode == gt.Prosedyrekategori);
                var htg_ht_gt = csvdataImporter_Htg_Ht_Gt_Mappings.FirstOrDefault(s => s.Grunntype_kode == gt.Kode);
                var hovedtype = _context.Hovedtype.FirstOrDefault(s => s.Kode == htg_ht_gt.Hovedtype_kode);
                //var hovedtypegruppe = _context.hovedtypegruppe.FirstOrDefault(s => s.Kode == htg_ht_gt.Hovedtypegruppe_kode);//htg_ht_gt.Hove
                var grunntype = new Grunntype()
                {
                    Id = Guid.NewGuid(),
                    Kode = gt.Kode,
                    Navn = gt.Grunntypenavn,
                    Version = domene,
                    Delkode = gt.Kode,
                    //Hovedtypegruppe = hovedtypegruppe,
                    Hovedtype = hovedtype,
                    Prosedyrekategori = psk
                };
                _context.Add(grunntype);
            }
            _context.SaveChanges();
        }
        else
        {
            _logger.LogInformation("Objecttype <<Grunntype>> allready has data!");
        }
    }

    private void GetHovedtypeData()
    {
        if (_context.Hovedtype.Count() == 0)
        {
            var hovedtyper = CsvdataImporter_Hovedtype.ProcessCSV("in_data/hovedtype.csv");
            var domene = Domenes.FirstOrDefault(s => s.Navn == "3.0");// todo-sat: get this from config or even better, get from request parameter -value.
            foreach (var ht in hovedtyper)
            {
                var psk = Prosedyrekategoris.FirstOrDefault(s => s.Kode == ht.Prosedyrekategori);
                var htg_ht_gt = csvdataImporter_Htg_Ht_Gt_Mappings.FirstOrDefault(s => s.Hovedtype_kode == ht.Kode); // finn hovedtypegruppe koden gitt hovedtypekode fra mapping/relasjonstabell.
                var hovedtypegruppe = _context.Hovedtypegruppe.FirstOrDefault(s => s.Kode == htg_ht_gt.Hovedtypegruppe_kode);
                var hovedtype = new Hovedtype()
                {
                    Id = Guid.NewGuid(),
                    Kode = ht.Kode,
                    Hovedtypegruppe = hovedtypegruppe,
                    Version = domene,
                    Delkode = ht.Hovedtype,
                    Navn = ht.Hovedtypenavn,
                    Prosedyrekategori = psk
                };
                _context.Add(hovedtype);
                //var 
                //htg > //todo-sat: use htg_ht_gt_mapping.csv
                //var htg = _context.hovedtypegruppe.FirstOrDefault(s => s.Kode == ht.Prosedyrekategori)

            }
            _context.SaveChanges();
        }
        else
        {
            _logger.LogInformation("Objecttype <<Hovedtype>> allready has data!");
        }
    }
    private void GetHovedtypeGruppeData()
    {

        var htg_count = _context.Hovedtypegruppe.Count();
        if (_context.Hovedtypegruppe.Count() == 0)
        {
            var hovedtypegrupper = CsvdataImporter_Hovedtypegruppe.ProcessCSV("in_data/hovedtypegruppe.csv");
            var domene = Domenes.FirstOrDefault(s => s.Navn == "3.0");// todo-sat: get this from config or even better, get from request parameter -value.
            foreach (var htg in hovedtypegrupper)
            {
                var tk2 = Typekategori2s.FirstOrDefault(s => s.Kode == htg.Typekategori2);
                var hovedtg = new Hovedtypegruppe()
                {
                    Id = Guid.NewGuid(),
                    Kode = htg.Kode,
                    Typekategori2 = tk2,
                    Version = domene,
                    Delkode = htg.Hovedtypegruppe,
                    Navn = htg.Hovedtypegruppenavn
                };
                _context.Add(hovedtg);
            }
            _context.SaveChanges();
        }
        else
        {
            _logger.LogInformation("Objecttype <<Hovedtypegruppe>> allready has data!");
        }
    }

    private void GetTypecsvData()
    {
        var tp_count = _context.Hovedtypegruppe.Count();
        if (_context.Type.Count() == 0)
        {
            var typer = CsvdataImporter_Type.ProcessCSV("in_data/type.csv");
            var domene = Domenes.FirstOrDefault(s => s.Navn == "3.0");// todo-sat: get this from config or even better, get from request parameter -value.
            foreach (var type in typer)
            {
                var esn = Ecosystnivaas.FirstOrDefault(s => s.Kode == type.Ecosystnivaa);
                var tk = Typekategoris.FirstOrDefault(s => s.Kode == type.Typekategori);
                var tk2 = Typekategori2s.FirstOrDefault(s => s.Kode == type.Typekategori2);

                var t = new Type() { Id = Guid.NewGuid(), Kode = type.Kode, Ecosystnivaa = esn, Typekategori = tk, Typekategori2 = tk2, Version = domene };
                _context.Add(t);
            }
            _context.SaveChanges();
        }
        else
        {
            _logger.LogInformation("Objecttype <<Type>> allready has data!");
        }
    }

       
    }
}
