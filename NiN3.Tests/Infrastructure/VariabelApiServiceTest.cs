using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using NiN.Infrastructure.Services;
using NiN3.Core.Models;
using NiN3.Infrastructure.DbContexts;
using NiN3.Infrastructure.Mapping;
using NiN3.Infrastructure.Services;
using Xunit;

namespace NiN3.Tests.Infrastructure
{
    public class VariabelApiServiceTest
    {

        private IMapper _mapper;
        private ILogger<VariabelApiService> _logger;
        private NiN3DbContext inmemorydb;

        public VariabelApiServiceTest()
        {
            _logger = new Mock<ILogger<VariabelApiService>>().Object;
        }

        private VariabelApiService GetPrepearedVariabelApiService()
        {
            inmemorydb = GetInMemoryDb();
            var mapper = NiNkodeMapper.Instance;
            mapper.SetConfiguration(CreateConfiguration());
            var loader = new LoaderService(null, inmemorydb, new Mock<ILogger<LoaderService>>().Object);

            loader.load_all_data();
            return new VariabelApiService(inmemorydb, _logger);
        }

        private static NiN3DbContext GetInMemoryDb()
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

        public IConfiguration CreateConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string> {
                    { "root_url", "http://localhost:5001/v3.0" }
                })
                .Build();

            return configuration;
        }

        [Fact]
        public void TestGetAllCodes()
        {
            var service = GetPrepearedVariabelApiService();
            var versjon = "3.0";
            var result = service.AllCodes(versjon);
            var variabler = result.Variabler;
            var firstVariabel = variabler.OrderBy(x => x.Kode.Id).First();
            Assert.Equal(4, variabler.Count);
            Assert.Equal("A-M", firstVariabel.Kode.Id);
            var count = variabler.Count(x => x.Kode.Id == "A-M");
            Assert.Equal(1, count);
            Assert.Equal("Abiotisk menneskebetinget", firstVariabel.Navn);
            const int minVariabelLength = 85;
            Assert.True(firstVariabel.Variabelnavn.Count() == minVariabelLength);
            Assert.Equal("NIN-3.0-V-A-M", firstVariabel.Kode.Langkode);
        }

        [Fact]
        public void TestGetAllCodesWithMaaleskalaTrinn()
        {
            var service = GetPrepearedVariabelApiService();
            var versjon = "3.0";
            var result = service.AllCodes(versjon);
            var vn_RM_MS = result.Variabler.SelectMany(x => x.Variabelnavn).Where(x => x.Kode.Id == "RM-MS").FirstOrDefault();
            Assert.NotNull(vn_RM_MS);
            Assert.Equal(5, vn_RM_MS.MaaleskalaTrinn.Count);
        }
    }
}
