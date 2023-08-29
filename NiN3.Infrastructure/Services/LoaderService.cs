using NiN3.Core.Models;
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
using NiN3.Core.Models.Enums;

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
        private List<Versjon> Domenes;

        private List<CsvDataImporter_typeklasser_langkode> Langkoder_typeklasser;
        //private string AdminToken;
        private readonly Dictionary<string, dynamic> EntitiesTypeDict = new Dictionary<string, dynamic>();

        public LoaderService(IConfiguration configuration, NiN3DbContext context, ILogger<LoaderService> logger)
        {
            _context = context;
            _logger = logger;
            _conf = configuration;
            //Assuming the method OpprettInitDb() is responsible for creating tables, add the following code to check if tables are already created before running the method. If they do not exist already, then execute the OpprettInitDb() method.

            /* Trying to use memory database to increase performance, but not working at the moment, problems with tables dissapering after creation
            if (!_context.Database.CanConnect())
            {
                _logger.LogInformation("Couldn't connect to database. Running migrations.");
                _context.Database.Migrate();
            }

            if (!HasTable("Versjon"))
            {
                _context.Database.EnsureCreated();
            }*/
            LoadTypeklasser_langkoder();
        }

        private bool HasTable(string tableName)
        {
            var tableNames = _context.Model.GetEntityTypes()
            .Select(t => t.GetTableName())
            .Distinct()
            .ToList();
            return tableNames.Contains(tableName);
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


        //public bool OpprettInitDbAsync()
        public bool OpprettInitDb()
        {
            LoadLookupData();
            LoadType_HTG_Mappings();
            LoadHtg_Ht_Gt_Mappings();
            try
            {
                LoadTypeData();
                _logger.LogInformation("Import of Types. Done");
                LoadHovedtypeGruppeData();
                _logger.LogInformation("Import of HTGdata. Done");
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
            LoadLookupData();
            LoadTypeData();
            LoadType_HTG_Mappings();
            LoadHovedtypeGruppeData();
            LoadHtg_Ht_Gt_Mappings();
            LoadHovedtypeData();
            LoadGrunntypedata();
            LoadKartleggingsenhet_m005();
            LoadKartleggingsenhet_m020();
            LoadKartleggingsenhet_m050();
            LoadVariabel();
            LoadVariabelnavn();

            _context.SaveChanges();
        }

        public void LoadLookupData()
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
        public void SeedLookupData()
        {
            List<Versjon> domenes = new List<Versjon>();
            domenes.Add(new Versjon() { Navn = "3.0" });
            _context.SaveChanges();
        }
        
        /// <summary>
        /// Loads data for the Grunntype entity type. 
        /// It imports Grunntype data if the table is empty and saves it to the database.
        /// </summary>
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

        /// <summary>
        /// Loads the data for Hovedtype if there is no data available in the context.
        /// </summary>
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
                    var langkode_grunntype = Langkoder_typeklasser.FirstOrDefault(s => s.kode_hovedtype == ht.Kode);
                    var langkodeForType = LangkodeForParent(langkode_grunntype.langkode, TypeklasseTypeEnum.HT, ht.Kode);
                    var hovedtype = new Hovedtype()
                    {
                        Id = Guid.NewGuid(),
                        Kode = ht.Kode,
                        Langkode = langkodeForType,
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
        
        /// <summary>
        /// Loads data of hovedtypegruppe from CSV file to database, if data not already present.
        /// </summary>
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
                    var langkode_grunntype = Langkoder_typeklasser.FirstOrDefault(s => s.kode_hovedtypegruppe == htg.Kode).langkode;
                    var langkodeForType = LangkodeForParent(langkode_grunntype, TypeklasseTypeEnum.HTG, htg.Kode);
                    var hovedtg = new Hovedtypegruppe()
                    {
                        Kode = htg.Kode,
                        Langkode = langkodeForType,
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

        /// <summary>
        /// Loads data for Type object if not already present in the database.
        /// </summary>
        private void LoadTypeklasser_langkoder() { 
            Console.WriteLine("Loading Typeklassekoder and Langkoder");
            Langkoder_typeklasser= CsvDataImporter_typeklasser_langkode.ProcessCSV("in_data/typeklasser_langkode_mapping.csv");
        }        
        public void LoadTypeData()
        {
            var tbls = Tabeller();
            //var tp_count = _context.Hovedtypegruppe.Count();
            if (_context.Type.Count() == 0)
            {
                var typer = CsvdataImporter_Type.ProcessCSV("in_data/type.csv");
                var domene = Domenes.FirstOrDefault(s => s.Navn == "3.0");// todo-sat: get this from config or even better, get from request parameter -value.
                foreach (var type in typer)
                {
                    var langkode_grunntype = Langkoder_typeklasser.FirstOrDefault(s => s.kode_type == type.Kode).langkode;
                    var langkodeForType = LangkodeForParent(langkode_grunntype, TypeklasseTypeEnum.T, type.Kode);
                    var t = new NiN3.Core.Models.Type()
                    {
                        Kode = type.Kode,                 
                        Langkode = langkodeForType,
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
        
        /// <summary>
        /// Loads data into database for kartleggingsenhet with maalestokk M005
        /// </summary>
        public void LoadKartleggingsenhet_m005()
        {
            var m005list = CsvdataImporter_m005.ProcessCSV("in_data/m005.csv");
            var m005_gtlist = CsvdataImporter_m005_grunntype_mapping.ProcessCSV("in_data/m005_grunntype_mapping.csv");
            var _versjon = Domenes.FirstOrDefault(s => s.Navn == "3.0");

            if (_context.Kartleggingsenhet.Where(k => k.Maalestokk == NiN3.Core.Models.Enums.MaalestokkEnum.M005).Count() == 0)
            {
                foreach (var m005 in m005list)
                {
                    var hovedtypeList = new List<Hovedtype>();
                    var k = new NiN3.Core.Models.Kartleggingsenhet()
                    {
                        Kode = m005.Kode,
                        Navn = m005.Navn,
                        Maalestokk = NiN3.Core.Models.Enums.MaalestokkEnum.M005,
                        Versjon = _versjon
                    };
                    m005_gtlist.Where(s => s.m005kode == m005.Kode).ToList().ForEach(s =>
                    {
                        var gt = _context.Grunntype.FirstOrDefault(g => g.Kode == s.Grunntype_kode);
                        if (gt != null)
                        {
                            k.Grunntyper.Add(gt);
                            hovedtypeList.Add(gt.Hovedtype);
                        }
                        else { 
                        //logg the m005 kode that has no grunntype mapping  
                            _logger.Equals("m005 kode: " + m005.Kode + " has no grunntype mapping");
                        }
                    });
                    _context.Add(k);
                    //adding the kartleggingsenhet to the hovedtype
                    var hovedtypelist_unique = hovedtypeList.Distinct();
                    foreach (var ht in hovedtypelist_unique)
                    {
                        var hovetype_kartleggingsenhet = new Hovedtype_Kartleggingsenhet()
                        {
                            Versjon = _versjon,
                            Hovedtype = ht,
                            Kartleggingsenhet = k

                        };  
                    _context.Add(hovetype_kartleggingsenhet);
                    }
                }
                _context.SaveChanges();
            }
            else
            {
                _logger.LogInformation("Objecttype <<Type>> allready has data!");
            }
        }

        public void LoadKartleggingsenhet_m020()
        {
            var m020list = CsvdataImporter_m020.ProcessCSV("in_data/m020.csv");
            var m020_gtlist = CsvdataImporter_m020_grunntype_mapping.ProcessCSV("in_data/m020_grunntype_mapping.csv");
            var _versjon = Domenes.FirstOrDefault(s => s.Navn == "3.0");

            if (_context.Kartleggingsenhet.Where(k => k.Maalestokk == NiN3.Core.Models.Enums.MaalestokkEnum.M020).Count() == 0)
            {
                foreach (var m020 in m020list)
                {
                    var hovedtypeList = new List<Hovedtype>();
                    var k = new NiN3.Core.Models.Kartleggingsenhet()
                    {
                        Kode = m020.Kode,
                        Navn = m020.Navn,
                        Maalestokk = NiN3.Core.Models.Enums.MaalestokkEnum.M020,
                        Versjon = _versjon
                    };
                    m020_gtlist.Where(s => s.m020kode == m020.Kode).ToList().ForEach(s =>
                    {
                        var gt = _context.Grunntype.FirstOrDefault(g => g.Kode == s.Grunntype_kode);
                        if (gt != null)
                        {
                            k.Grunntyper.Add(gt);
                            hovedtypeList.Add(gt.Hovedtype);
                        }
                        else
                        {
                            //logg the m020 kode that has no grunntype mapping  
                            _logger.Equals("m020 kode: " + m020.Kode + " has no grunntype mapping");
                        }
                    });
                    _context.Add(k);
                    //adding the kartleggingsenhet to the hovedtype
                    var hovedtypelist_unique = hovedtypeList.Distinct();
                    foreach (var ht in hovedtypelist_unique)
                    {
                        var hovetype_kartleggingsenhet = new Hovedtype_Kartleggingsenhet()
                        {
                            Versjon = _versjon,
                            Hovedtype = ht,
                            Kartleggingsenhet = k

                        };
                        _context.Add(hovetype_kartleggingsenhet);
                    }
                }
                _context.SaveChanges();
            }
            else
            {
                _logger.LogInformation("Objecttype <<Type>> already has data!");
            }
        }

        //load variabel 
        public List<Variabel> LoadVariabel()
        {
            //parse csv file
            var variabelList = CsvDataImporter_Variabel.ProcessCSV("in_data/variabel.csv");
            var _versjon = Domenes.FirstOrDefault(s => s.Navn == "3.0");
            var loadedVariabels = new List<Variabel>();

            //load variabel data to model class
            foreach (var v in variabelList.OrderBy(v => v.Kode))
            {
                var _navn = $"{EnumUtil.ToDescription(v.Ecosystnivaa)} {EnumUtil.ToDescription(v.Variabelkategori)}".ToLower().Replace("_", " ");
                _navn = char.ToUpper(_navn[0]) + _navn.Substring(1);
                var variabel = new Variabel()
                {
                    Kode = v.Kode,
                    Ecosystnivaa = v.Ecosystnivaa,
                    Variabelkategori = v.Variabelkategori, // No semicolon here
                    Navn = _navn,
                    Versjon = _versjon
                };
                _context.Add(variabel);
                loadedVariabels.Add(variabel);
            }

            _context.SaveChanges();
            return loadedVariabels;
        }

        public List<Variabelnavn> LoadVariabelnavn()
        {
            //parse csv file
            var variabelList = CsvdataImporter_Variabelnavn.ProcessCSV("in_data/variabelnavn_variabel_mapping.csv");
            var _versjon = Domenes.FirstOrDefault(s => s.Navn == "3.0");
            var loadedVariabelnavn = new List<Variabelnavn>();
            var parents = _context.Variabel.ToList();
            //load variabel data to model class
            foreach (var v in variabelList.OrderBy(v => v.Kode))
            {
                var parent = parents.FirstOrDefault(p => p.Kode == v.VariabelKode);
                var variabel = new Variabelnavn()
                {
                    Kode = v.Kode,
                    Navn = v.Navn,
                    Versjon = _versjon,
                    Variabelkategori2 = v.Variabelkategori2, // No semicolon here
                    Variabeltype = v.Variabeltype,
                    Variabelgruppe = v.Variabelgruppe,
                    Variabel = parent,
                    Langkode = v.Langkode,
                    //Versjon = _versjon
                };
                _context.Add(variabel);
                loadedVariabelnavn.Add(variabel);
            }

            _context.SaveChanges();
            return loadedVariabelnavn;
        }

        public string LangkodeForParent(string raw_langkode, TypeklasseTypeEnum typeklasseType, string kortkode)
        {
            // switch case to check type of parent and return corresponding langkode substring
            // replace with actual code that gets the parent object's type
            //Todo: Set actual parent types
            if (raw_langkode != null)
            {
                var kodeledd_list = raw_langkode.Split("_");
                switch (typeklasseType)
                {
                    case TypeklasseTypeEnum.T:
                        //if (kodeledd_list.Length == 1)//join correct kodeledd from kodeledd_list and return
                        return "NIN-3.0-T-"+kortkode;
                    case TypeklasseTypeEnum.HTG:

                        //if (kodeledd_list.Length == 1)//join correct kodeledd from kodeledd_list and return
                        return "hovedtypegruppe.langkodecutting not impl.";
                    case TypeklasseTypeEnum.HT:
                        //if (kodeledd_list.Length == 1)//join correct kodeledd from kodeledd_list and return
                        return "hovedtype.langkodecutting not impl.";
                    // add additional cases for other types
                    default:
                        throw new ArgumentException("Invalid parent type!");
                }
            }
            else {
                _logger.LogWarning("Langkode is null");
                return "langkode mangler";
            }
        }

        public void LoadKartleggingsenhet_m050()
        {
            var m050list = CsvdataImporter_m050.ProcessCSV("in_data/m050.csv");
            var m050_gtlist = CsvdataImporter_m050_grunntype_mapping.ProcessCSV("in_data/m050_grunntype_mapping.csv");
            var _versjon = Domenes.FirstOrDefault(s => s.Navn == "3.0");

            if (_context.Kartleggingsenhet.Where(k => k.Maalestokk == NiN3.Core.Models.Enums.MaalestokkEnum.M050).Count() == 0)
            {
                foreach (var m050 in m050list)
                {
                    var hovedtypeList = new List<Hovedtype>();
                    var k = new NiN3.Core.Models.Kartleggingsenhet()
                    {
                        Kode = m050.Kode,
                        Navn = m050.Navn,
                        Maalestokk = NiN3.Core.Models.Enums.MaalestokkEnum.M050,
                        Versjon = _versjon
                    };
                    m050_gtlist.Where(s => s.m050kode == m050.Kode).ToList().ForEach(s =>
                    {
                        var gt = _context.Grunntype.FirstOrDefault(g => g.Kode == s.Grunntype_kode);
                        if (gt != null)
                        {
                            k.Grunntyper.Add(gt);
                            hovedtypeList.Add(gt.Hovedtype);
                        }
                        else
                        {
                            //logg the m050 kode that has no grunntype mapping  
                            _logger.Equals("m050 kode: " + m050.Kode + " has no grunntype mapping");
                        }
                    });
                    _context.Add(k);
                    //adding the kartleggingsenhet to the hovedtype
                    var hovedtypelist_unique = hovedtypeList.Distinct();
                    foreach (var ht in hovedtypelist_unique)
                    {
                        var hovetype_kartleggingsenhet = new Hovedtype_Kartleggingsenhet()
                        {
                            Versjon = _versjon,
                            Hovedtype = ht,
                            Kartleggingsenhet = k

                        };
                        _context.Add(hovetype_kartleggingsenhet);
                    }
                }
                _context.SaveChanges();
            }
            else
            {
                _logger.LogInformation("Objecttype <<Type>> already has data!");
            }
        }
        public List<object> Tabelldata(string tablename)
        {
            throw new NotImplementedException();
        }
    }
}
