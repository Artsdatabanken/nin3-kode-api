using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moq;
using NiN3KodeAPI.DbContexts;
using NiN3KodeAPI.Entities;
using NiN3KodeAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Test_NiN3KodeAPI.Infrastructure
{
    
    public class LoaderServiceTest
    {
        private LoaderService _loaderService;
        private ILogger<LoaderService> _logger;

        public LoaderServiceTest() {
            _logger = new Mock<ILogger<LoaderService>>().Object;
        }
        private static NiN3DbContext GetInMemoryDb()//out SqliteConnection connection, out DbContextOptions<NiN3DbContext> options)
        {
            var connection = new SqliteConnection("Filename=:memory:");
            connection.Open();
            connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            var options = new DbContextOptionsBuilder<NiN3DbContext>()
            .UseSqlite(connection)
            .Options;
            var context = new NiN3DbContext(options);
            context.Database.EnsureCreated();
            return context;
        }

        [Fact]
        public void TestLoadHovedtypeGruppe() {
            var inmemorydb = GetInMemoryDb();
            var service = new LoaderService(null, inmemorydb, _logger);
            service.LoadHovedtypeGruppeData();
            var numOfHGD = inmemorydb.Hovedtypegruppe.Count();
            Assert.Equal(70, numOfHGD);   
        }

        [Fact]
        public void TestLoadHovedtype() {
            var inmemorydb = GetInMemoryDb();
            var service = new LoaderService(null, inmemorydb, _logger);
            service.LoadHovedtypeGruppeData();
            service.LoadHtg_Ht_Gt_Mappings();
            service.LoadHovedtypeData();
            var numOfHD = inmemorydb.Hovedtype.Count();
            Assert.Equal(445,numOfHD);
        }

        [Fact]
        public void TestLoadGrunntype() {
            var inmemorydb = GetInMemoryDb();
            var service = new LoaderService(null, inmemorydb, _logger);
            service.LoadHovedtypeGruppeData();
            service.LoadHtg_Ht_Gt_Mappings();
            service.LoadHovedtypeData();
            service.LoadGrunntypedata();
            var numOfGD = inmemorydb.Grunntype.Count();
            Assert.Equal(166, numOfGD);
        }

        [Fact]
        public void TestLoadType()
        {
            var inmemorydb = GetInMemoryDb();
            var service = new LoaderService(null, inmemorydb, _logger);
            service.LoadTypeData();
            var numOfTD = inmemorydb.Type.Count();
            Assert.Equal(10, numOfTD);
        }
    }
}
