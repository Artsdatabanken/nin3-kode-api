//Optimized
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NiN3.Infrastructure.DbContexts;
using NiN.Infrastructure.Services;

namespace NiN3.Tests.Infrastructure
{

    public class LoaderServiceTest
    {
        private LoaderService _loaderService;
        private ILogger<LoaderService> _logger;

        public LoaderServiceTest()
        {
            _logger = new Mock<ILogger<LoaderService>>().Object;
        }
        private static NiN3DbContext GetInMemoryDb()//out SqliteConnection connection, out DbContextOptions<NiN3DbContext> options)
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            var options = new DbContextOptionsBuilder<NiN3DbContext>()
            .UseSqlite(connection)
            .Options;
            var context = new NiN3DbContext(options);
            context.Database.EnsureCreated();

            return context;
        }


        [Fact]
        public void TestLoadType()
        {
            // Get an instance of the InMemoryDb class
            var inmemorydb = GetInMemoryDb();
            // Create a new LoaderService instance
            var service = new LoaderService(null, inmemorydb, _logger);
            service.SeedLookupData();
            service.LoadLookupData();
            // Load the TypeData
            //service.Load
            service.LoadLookupData();
            service.LoadTypeData();
            service.LoadHtg_Ht_Gt_Mappings();
            // service.LoadHovedtypeData();
            // Get the number of Type records
            var numOfTD = inmemorydb.Type.Count();
            var typer = inmemorydb.Type.ToList();
            // Assert that the number of records is 10
            Assert.Equal(10, numOfTD);

            //Test a type langkode within ecosystnivaa = C
            var type_eco_C = inmemorydb.Type.Where(t => t.Kode == "C-PE-NA").FirstOrDefault(); //Get Type with Kode = "C-PE-NA"
            Assert.Equal("NIN-3.0-T-C-PE-NA", type_eco_C.Langkode);

            //Test a type langkode within ecosystnivaa = A 
            var type_eco_A = inmemorydb.Type.Where(t => t.Kode == "A-MV-0").FirstOrDefault(); //Get Type with Kode = "CA-MV-0"
            Assert.Equal("NIN-3.0-T-A-MV-0", type_eco_A.Langkode);
        }


        [Fact]
        public void TestLoadType_Htg_Mapping()
        {
            var inmemorydb = GetInMemoryDb();
            // Create a new LoaderService instance
            var service = new LoaderService(null, inmemorydb, _logger);
            service.LoadType_HTG_Mappings();
            Assert.Equal(70, service.csvdataImporter_Type_Htg_Mappings.Count());
        }

        //This code tests the LoadHovedtypeGruppeData() method of the LoaderService class. 
        //It creates an InMemoryDb object and passes it to the LoaderService constructor. 
        //It then calls the LoadHovedtypeGruppeData() method and checks the number of Hovedtypegruppe objects in the InMemoryDb object. 
        //It then asserts that the number of Hovedtypegruppe objects is equal to 70. 
        [Fact]
        public void TestLoadHovedtypeGruppe()
        {
            //Create an InMemoryDb object
            var inmemorydb = GetInMemoryDb();
            //Create a LoaderService object and pass the InMemoryDb object to its constructor
            var service = new LoaderService(null, inmemorydb, _logger);
            service.SeedLookupData();
            service.LoadLookupData();
            //Call the LoadHovedtypeGruppeData() method
            service.LoadTypeData();
            service.LoadType_HTG_Mappings();
            service.LoadHovedtypeGruppeData();
            //Get the number of Hovedtypegruppe objects in the InMemoryDb object
            var numOfHGD = inmemorydb.Hovedtypegruppe.Count();
            //q: get the first Hovedtypegruppe object in the InMemoryDb object after ordering by Kode
            var firstHGD = inmemorydb.Hovedtypegruppe.OrderBy(x => x.Kode).First();
            //Assert that the number of Hovedtypegruppe objects is equal to 71
            Assert.Equal(73, numOfHGD);


            //Testing langkode for Hovedtypegruppe that should have typekategori3 embedded in langkode
            var HTG_NA_T = inmemorydb.Hovedtypegruppe.Where(x => x.Kode == "NA-T").FirstOrDefault();
            Assert.Equal("NIN-3.0-T-C-PE-NA-MB-NA-T", HTG_NA_T.Langkode);
            
            //Testing langkode for Hovedtypegruppe that should NOT have typekategori3 embedded in langkode

        }

        [Fact]
        //This code tests the LoadHovedtype method by creating an in-memory database,
        //instantiating a LoaderService object, and then calling the LoadHovedtypeGruppeData, LoadHtg_Ht_Gt_Mappings,
        //and LoadHovedtypeData methods. Finally, it checks that the number of Hovedtype objects in the in-memory database is equal to 445. 

        public void TestLoadHovedtype()
        {
            //Create an in-memory database
            var inmemorydb = GetInMemoryDb();

            //Instantiate a LoaderService object
            var service = new LoaderService(null, inmemorydb, _logger);
            service.SeedLookupData();
            service.LoadLookupData();
            //Call the LoadHovedtypeGruppeData, LoadHtg_Ht_Gt_Mappings, and LoadHovedtypeData methods
            service.LoadTypeData();
            service.LoadType_HTG_Mappings();
            service.LoadHovedtypeGruppeData();
            service.LoadHtg_Ht_Gt_Mappings();
            service.LoadHovedtypeData();

            //Check that the number of Hovedtype objects in the in-memory database is equal to 445
            var numOfHD = inmemorydb.Hovedtype.Count();
            var hovedtyper = inmemorydb.Hovedtype.ToList();
            Assert.Equal(464, numOfHD);
            var HT_0_C_01 = inmemorydb.Hovedtype.Where(x => x.Kode == "0-C-01").FirstOrDefault();
            Assert.NotNull(HT_0_C_01);
            Assert.NotNull(HT_0_C_01.Hovedtypegruppe);
            Assert.Equal("NIN-3.0-T-C-SE-NK-0-C-01", HT_0_C_01.Langkode);

            //testing that hovedtype 'T-M-01' has typekategori3 embedded in langkode, (child of HTG "NA-T")
            var HT_T_M_01 = inmemorydb.Hovedtype.Where(x => x.Kode == "T-M-01").FirstOrDefault();
            Assert.Equal("NIN-3.0-T-C-PE-NA-MB-T-M-01", HT_T_M_01.Langkode);
        }

        [Fact]
        public void TestHovedtypeFromHovedtypegruppe()
        {
            var inmemorydb = GetInMemoryDb();
            //Instantiate a LoaderService object
            var service = new LoaderService(null, inmemorydb, _logger);
            service.load_all_data();
            //q: get hovedtypegruppe with kode "A-LV-BM" from inmemorydb object
            //Answer:
            var c = inmemorydb.Hovedtypegruppe.Count();
            var hovedtypegruppe = inmemorydb.Hovedtypegruppe.Where(x => x.Kode == "NA-M")
                .Include(h => h.Hovedtyper).FirstOrDefault();
            //Q: get hovedtypegruppe with kode NA-I and fetch hovedtyper that has relation to it

            //Answer: 
            //var firstHGD = inmemorydb.Hovedtypegruppe.OrderBy(x => x.Kode).First();
            Assert.NotNull(hovedtypegruppe);
            Assert.Equal(23, hovedtypegruppe.Hovedtyper.Count);
        }

        // Rewritten code with comments
        [Fact]
        public void TestLoadGrunntype()
        {
            // Get an instance of the InMemoryDb class
            var inmemorydb = GetInMemoryDb();
            // Create a new LoaderService instance
            var service = new LoaderService(null, inmemorydb, _logger);
            // Load the HovedtypeGruppeData, Htg_Ht_Gt_Mappings, and HovedtypeData
            service.load_all_data();
            // Get the number of Grunntype records
            var numOfGD = inmemorydb.Grunntype.Count();
            // Assert that the number of records is 166
            Assert.Equal(1403, numOfGD);
            // Get the Grunntype record with the code "M-A-01-05"
            var grunntype = inmemorydb.Grunntype.Where(gt => gt.Kode == "M-A-01-05").FirstOrDefault();
            // Assert that the name of the record is "sukkertareskog"
            Assert.Equal("spiraltangbunn", grunntype.Navn);
            // Assert that the delkode of the record is "05"
            Assert.Equal("05", grunntype.Delkode);

            //Testing langkode for M-A-01-05
            Assert.Equal("NIN-3.0-T-C-PE-NA-MB-M-A-01-05", grunntype.Langkode);
        }                

        [Fact]
        public void TestLoadKartleggingsenhet_m005()
        {
            var inmemorydb = GetInMemoryDb();
            // Create a new LoaderService instance
            var service = new LoaderService(null, inmemorydb, _logger);
            service.load_all_data();
            service.LoadKartleggingsenhet_m005();
            var numOfKE = inmemorydb.Kartleggingsenhet.Count();
            var firstKE = inmemorydb.Kartleggingsenhet.OrderBy(x => x.Kode).First();
            var hovedtype_kartlegginsenhetFirstKE = inmemorydb.Hovedtype_Kartleggingsenhet.Where(x => x.Kartleggingsenhet.Id == firstKE.Id).FirstOrDefault();
            Assert.NotNull(hovedtype_kartlegginsenhetFirstKE);
            Assert.Equal(1278, numOfKE);
            Assert.Equal("NiN-3.0-T-C-PE-NA-MB-IA01-M005-01", firstKE.Langkode);
        }

        //create test for loadvariabel
        [Fact]
        public void TestLoadVariabel()
        {
            var inmemorydb = GetInMemoryDb();
            // Create a new LoaderService instance
            var service = new LoaderService(null, inmemorydb, _logger);
            service.SeedLookupData();
            service.LoadLookupData();
            service.LoadVariabel();
            var numOfV = inmemorydb.Variabel.Count();
            var firstV = inmemorydb.Variabel.OrderBy(x => x.Kode).First();
            Assert.NotNull(firstV);
            Assert.Equal("A-M", firstV.Kode);
            Assert.Equal("Abiotisk menneskebetinget", firstV.Navn);
            Assert.Equal(4, numOfV);
        }

        [Fact]  
        //write test that fetches variabelnavn from database
        public void TestLoadVariabelnavn()
        {
            var inmemorydb = GetInMemoryDb();
            // Create a new LoaderService instance
            var service = new LoaderService(null, inmemorydb, _logger);
            service.SeedLookupData();
            service.LoadLookupData();
            service.LoadVariabel();
            var VariabelnavnList = service.LoadVariabelnavn();
            var numOfVN = VariabelnavnList.Count();
            var firstVN = VariabelnavnList.OrderBy(x => x.Kode).First();
            Assert.NotNull(firstVN);

            //Assert.NotNull(firstVN);
            //Assert.Equal("A-M", firstVN.Kode);
            //Assert.Equal("Abiotisk menneskebetinget", firstVN.Navn);
            Assert.Equal(364, numOfVN);
            Assert.True(firstVN.Kode == "AD-FA");
            Assert.True(firstVN.Navn == "fremmedartsantall");
            Assert.True(firstVN.Variabelkategori2.ToString() == "AD");
            Assert.True(firstVN.Variabelgruppe.ToString() == "FA");
            Assert.True(firstVN.Variabeltype.ToString() == "GE");
            Assert.True(firstVN.Versjon.Navn == "3.0");
            //Assert.True(firstVN. == "");
            //todo-sat: test more fields here
        }

    }
}