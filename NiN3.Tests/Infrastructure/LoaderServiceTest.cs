﻿//Optimized
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NiN3.Infrastructure.DbContexts;
using NiN.Infrastructure.Services;

namespace Test_NiN3KodeAPI.Infrastructure
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
            // Load the TypeData
            service.LoadTypeData();
            service.LoadHtg_Ht_Gt_Mappings();
            // service.LoadHovedtypeData();
            // Get the number of Type records
            var numOfTD = inmemorydb.Type.Count();
            var typer = inmemorydb.Type.ToList();
            // Assert that the number of records is 10
            Assert.Equal(10, numOfTD);
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
            //Call the LoadHovedtypeGruppeData() method
            service.LoadTypeData();
            service.LoadType_HTG_Mappings();
            service.LoadHovedtypeGruppeData();
            //Get the number of Hovedtypegruppe objects in the InMemoryDb object
            var numOfHGD = inmemorydb.Hovedtypegruppe.Count();

            //q: get the first Hovedtypegruppe object in the InMemoryDb object after ordering by Kode
            var firstHGD = inmemorydb.Hovedtypegruppe.OrderBy(x => x.Kode).First();
            var typeOfFirstHGD = firstHGD.Type;
            //Assert that the number of Hovedtypegruppe objects is equal to 70
            Assert.Equal(70, numOfHGD);
            Assert.NotNull(typeOfFirstHGD);
            Assert.Equal("A-LV-BM", typeOfFirstHGD.Kode);
        }

        [Fact]
        //This code tests the LoadHovedtype method by creating an in-memory database, instantiating a LoaderService object, and then calling the LoadHovedtypeGruppeData, LoadHtg_Ht_Gt_Mappings, and LoadHovedtypeData methods. Finally, it checks that the number of Hovedtype objects in the in-memory database is equal to 445. 

        public void TestLoadHovedtype()
        {
            //Create an in-memory database
            var inmemorydb = GetInMemoryDb();

            //Instantiate a LoaderService object
            var service = new LoaderService(null, inmemorydb, _logger);
            //Call the LoadHovedtypeGruppeData, LoadHtg_Ht_Gt_Mappings, and LoadHovedtypeData methods
            service.LoadTypeData();
            service.LoadType_HTG_Mappings();
            service.LoadHovedtypeGruppeData();
            service.LoadHtg_Ht_Gt_Mappings();
            service.LoadHovedtypeData();

            //Check that the number of Hovedtype objects in the in-memory database is equal to 445
            var numOfHD = inmemorydb.Hovedtype.Count();
            Assert.Equal(464, numOfHD);
            var firstHovedtype = inmemorydb.Hovedtype.OrderBy(h => h.Kode).FirstOrDefault();
            Assert.NotNull(firstHovedtype);
            Assert.NotNull(firstHovedtype.Hovedtypegruppe);
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
            Assert.Equal(1405, numOfGD);
            // Get the Grunntype record with the code "M-A-01-05"
            var grunntype = inmemorydb.Grunntype.Where(gt => gt.Kode == "M-A-01-05").FirstOrDefault();
            Assert.Equal("NiN-3.0-T-C-PE-NA-MB-MA01-05", grunntype.Langkode);
            // Assert that the name of the record is "sukkertareskog"
            Assert.Equal("spiraltangbunn", grunntype.Navn);
            // Assert that the delkode of the record is "05"
            Assert.Equal("05", grunntype.Delkode);
        }

        [Fact]
        public void TestLoadKartleggingsenhet_m005_m020()
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
            Assert.Equal(1286, numOfKE);
        }
    }
}