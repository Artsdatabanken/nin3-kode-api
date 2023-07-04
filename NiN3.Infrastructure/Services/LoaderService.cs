﻿using NiN3.Core.Models;
using NiN3.Infrastructure.in_data;
//using Type = NiN3.Core.Models.Type;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using NiN3KodeAPI.in_data;
using Newtonsoft.Json;
using NiN3.Infrastructure.Services;
using NiN3.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Xml;
using System;


namespace NiN.Infrastructure.Services
{
    public class LoaderService : ILoaderService
    {
        private readonly ILogger<LoaderService> _logger;
        private readonly NiN3DbContext _context;
        private IConfiguration _conf;
        public List<CsvdataImporter_htg_ht_gt_mapping> csvdataImporter_Htg_Ht_Gt_Mappings { get; set; }
        public List<CsvdataImporter_Type_Htg_mapping> csvdataImporter_Type_Htg_Mappings { get; set; }
        public List<NiN3.Core.Models.Type> _typer { get; set; }
        //private List<Prosedyrekategori> Prosedyrekategoris;
        //private List<Ecosystnivaa> Ecosystnivaas;
        //private List<Typekategori> Typekategoris;
        //private List<Typekategori2> Typekategori2s;
        private List<Versjon> Domenes;
        //private string AdminToken;
        private readonly Dictionary<string, dynamic> EntitiesTypeDict = new Dictionary<string, dynamic>();

        public LoaderService(IConfiguration configuration, NiN3DbContext context, ILogger<LoaderService> logger)
        {
            _context = context;
            _logger = logger;
            _conf = configuration;
            Domenes = _context.Versjon.ToList();
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
        public List<dynamic> Tabelldata(string tablename)
        {
            // write a switch that gets records based on tablename possible options are "Type, Hovedtypegruppe and Hovedtype"
            string res = "";
            dynamic rs = new List<dynamic>();
            //FormattableString sql = $"SELECT * FROM [{tablename}]";
            //var result = _context.Database.FromRaw(sql);'
            string typeName = "NiN3.Core.Model.{tablename}";
            System.Type type = System.Type.GetType(typeName);
            var result = _context.Set<dynamic>).FromSql($"select * from {tablename}").ToList();
            return (List<object>)result;
        }
        */

        public IEnumerable<Versjon> HentDomener()
        {
            return _context.Versjon.OrderBy(c => c.Navn).ToList();
        }

        public void DoMigrations()
        {// from adminController.
            _context.Database.Migrate();
        }


        //public bool OpprettInitDbAsync()
        public bool OpprettInitDb()
        {
            //throw new NotImplementedException();
            //SeedLookupData();

            LoadLookupData();
            LoadType_HTG_Mappings();
            LoadHtg_Ht_Gt_Mappings();
            try
            {
                LoadTypeData();
                _logger.LogInformation("Import of Types. Done");
                LoadHovedtypeGruppeData();
                _logger.LogInformation("Import of HTGdata. Done");
                //todo-sat: load mapping csv

                LoadHovedtypeData();
                _logger.LogInformation("Import of HTdata. Done");

                LoadGrunntypedata();
                _logger.LogInformation("Import of GTdata. Done");
            }
            catch (Exception ex)
            {
                _logger.LogError("Error importing data from csv ; " + ex.Message);
            }
            return true;
        }


        public void load_all_data()
        {
            SeedLookupData();
            LoadTypeData();
            LoadType_HTG_Mappings();
            LoadHovedtypeGruppeData();
            LoadHtg_Ht_Gt_Mappings();
            LoadHovedtypeData();
            LoadGrunntypedata();
        }

        private void LoadLookupData()
        {
            Domenes = _context.Versjon.ToList();
        }

        // Rewritten code with comments

        /// <summary>
        /// Loads the Type_HTG_Mapping from the csv file and logs a message to indicate that the Type_HTG_Mapping has been loaded.
        /// </summary>
        public void LoadType_HTG_Mappings()
        {
            // Create an instance of the CsvdataImporter_Type_Htg_mapping class
            csvdataImporter_Type_Htg_Mappings = CsvdataImporter_Type_Htg_mapping.ProcessCSV("in_data/type_htg_mapping.csv");
            // Log a message to indicate that the Type_HTG_Mapping has been loaded
            _logger.LogInformation("Type_HTG_Mapping lastet");
        }
        /// <summary>
        /// Creates an instance of the CsvdataImporter_htg_ht_gt_mapping class and logs a message to indicate that the Htg_Ht_Gt_Mapping has been loaded.
        /// </summary>
        public void LoadHtg_Ht_Gt_Mappings()
        {
            // Create an instance of the CsvdataImporter_htg_ht_gt_mapping class
            csvdataImporter_Htg_Ht_Gt_Mappings = CsvdataImporter_htg_ht_gt_mapping.ProcessCSV("in_data/htg_ht_gt_mapping.csv");
            // Log a message to indicate that the Htg_Ht_Gt_Mapping has been loaded
            _logger.LogInformation("Htg_Ht_Gt_Mapping lastet");
        }


        /// <summary>
        /// Seeds the lookup data.
        /// </summary>
        private void SeedLookupData()
        {
            List<Versjon> domenes = new List<Versjon>();
            domenes.Add(new Versjon() { Navn = "3.0" });
            _context.SaveChanges();
        }
        public void LoadGrunntypedata()
        {
            if (_context.Grunntype.Count() == 0)
            {
                //todo-sat: do impl. 
                var grunntyper = CsvdataImporter_Grunntype.ProcessCSV("in_data/grunntyper.csv");
                var domene = Domenes.FirstOrDefault(s => s.Navn == "3.0");// todo-sat: get this from config or even better, get from request parameter -value.
                foreach (var gt in grunntyper)
                {
                    var htg_ht_gt = csvdataImporter_Htg_Ht_Gt_Mappings.FirstOrDefault(s => s.Grunntype_kode == gt.Kode);
                    var hovedtype = _context.Hovedtype.FirstOrDefault(s => s.Kode == htg_ht_gt.Hovedtype_kode);
                    //var hovedtypegruppe = _context.hovedtypegruppe.FirstOrDefault(s => s.Kode == htg_ht_gt.Hovedtypegruppe_kode);//htg_ht_gt.Hove
                    var grunntype = new Grunntype()
                    {
                        /* Id = Guid.NewGuid(), */
                        Kode = gt.Kode,
                        Langkode = gt.Langkode,
                        Navn = gt.Grunntypenavn,
                        Versjon = domene,
                        Delkode = gt.Grunntype,
                        //Hovedtypegruppe = hovedtypegruppe,
                        Hovedtype = hovedtype,
                        Prosedyrekategori = gt.Prosedyrekategori
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

        public void LoadHovedtypeData()
        {
            if (_context.Hovedtype.Count() == 0)
            {
                var hovedtyper = CsvdataImporter_Hovedtype.ProcessCSV("in_data/hovedtype.csv");
                var domene = Domenes.FirstOrDefault(s => s.Navn == "3.0");// todo-sat: get this from config or even better, get from request parameter -value.
                foreach (var ht in hovedtyper)
                {
                    var psk = ht.Prosedyrekategori;
                    var htg_ht_gt = csvdataImporter_Htg_Ht_Gt_Mappings.FirstOrDefault(s => s.Hovedtype_kode == ht.Kode); // finn hovedtypegruppe koden gitt hovedtypekode fra mapping/relasjonstabell.
                    var hovedtypegruppe = _context.Hovedtypegruppe.FirstOrDefault(s => s.Kode == htg_ht_gt.Hovedtypegruppe_kode);
                    var hovedtype = new Hovedtype()
                    {
                        Id = Guid.NewGuid(),
                        Kode = ht.Kode,
                        Hovedtypegruppe = hovedtypegruppe,
                        Versjon = domene,
                        Delkode = ht.Hovedtype,
                        Navn = ht.Hovedtypenavn,
                        Prosedyrekategori = ht.Prosedyrekategori
                    };
                    _context.Add(hovedtype);
                }
                _context.SaveChanges();
            }
            else
            {
                _logger.LogInformation("Objecttype <<Hovedtype>> allready has data!");
            }
        }
        public void LoadHovedtypeGruppeData()
        {
            //q: fetch typer from _context
            var typer = _context.Type.ToList();
            var htg_count = _context.Hovedtypegruppe.Count();
            if (_context.Hovedtypegruppe.Count() == 0)
            {
                var hovedtypegrupper = CsvdataImporter_Hovedtypegruppe.ProcessCSV("in_data/hovedtypegrupper.csv");
                var domene = Domenes.FirstOrDefault(s => s.Navn == "3.0");// todo-sat: get this from config or even better, get from request parameter -value.
                foreach (var htg in hovedtypegrupper)
                {
                    var typeKode = csvdataImporter_Type_Htg_Mappings.Where(x => x.Typekategori2 == htg.Typekategori2.ToString()).Select(x => x.Type_kode).FirstOrDefault();
                    var type = typer.FirstOrDefault(s => s.Kode == typeKode);
                    var hovedtg = new Hovedtypegruppe()
                    {
                        Kode = htg.Kode,
                        Typekategori2 = htg.Typekategori2,
                        Versjon = domene,
                        Delkode = htg.Hovedtypegruppe,
                        Navn = htg.Hovedtypegruppenavn,
                        Type = type       /// <summary>
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

        public void LoadTypeData()
        {
            var tp_count = _context.Hovedtypegruppe.Count();
            if (_context.Type.Count() == 0)
            {
                var typer = CsvdataImporter_Type.ProcessCSV("in_data/type.csv");
                var domene = Domenes.FirstOrDefault(s => s.Navn == "3.0");// todo-sat: get this from config or even better, get from request parameter -value.
                foreach (var type in typer)
                {
                    var t = new NiN3.Core.Models.Type()
                    { 
                        Kode = type.Kode,
                        Ecosystnivaa = type.Ecosystnivaa,
                        Typekategori = type.Typekategori,
                        Typekategori2 = type.Typekategori2,
                        Versjon = domene
                    };
                    _context.Add(t);
                }
                _context.SaveChanges();
            }
            else
            {
                _logger.LogInformation("Objecttype <<Type>> allready has data!");
            }
        }

        public void LoadKartleggingsenhet_m005() {
            var m005list = CsvdataImporter_m005.ProcessCSV("in_data/m005.csv");
            var m005_gtlist = CsvdataImporter_m005_grunntype_mapping.ProcessCSV("in_data/m005_grunntype_mapping.csv");
            var _versjon = Domenes.FirstOrDefault(s => s.Navn == "3.0");
            if (_context.Kartleggingsenhet.Where(k => k.Maalestokk == NiN3.Core.Models.Enums.MaalestokkEnum.M005).Count() == 0)
            { 
            foreach (var m005 in m005list)
            {
              var k = new NiN3.Core.Models.Kartleggingsenhet()
                {
                    Kode = m005.Kode,
                    Navn = m005.Navn,
                    Maalestokk = NiN3.Core.Models.Enums.MaalestokkEnum.M005,
                    Versjon = _versjon
                };
                _context.Add(k);
            }
                //todo-sat: find grunntypekoder for m005
                //loop grunntyper
                //todo-sat: find grunntype from dbcontext
                //todo-sat: add the grunntype to the kartleggingsenhet  
                _context.SaveChanges();
        }
            else
            {
                _logger.LogInformation("Objecttype <<Type>> allready has data!");
            }
}

        public List<object> Tabelldata(string tablename)
        {
            throw new NotImplementedException();
        }
    }
}
