using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NiN.Infrastructure.Services.LoaderService;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using NiN3.Infrastructure.DbContexts;
using NiN3.Infrastructure.Services;
using AutoMapper;
using Castle.Core.Logging;
using Microsoft.Extensions.Logging;
using Moq;
using NiN.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using static System.Net.WebRequestMethods;

namespace NiN3.Tests.Infrastructure
{
    public class TypeApiServiceTest
    {



        private IMapper _mapper;
        private ILogger<TypeApiService> _logger;

        public TypeApiServiceTest()
        {
            _logger = new Mock<ILogger<TypeApiService>>().Object;
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


        // q: create a method to create Microsoft.Extensions.Configuration.ConfigurationManager object with key and value "root_url": "http://localhost:5001"
        public Microsoft.Extensions.Configuration.IConfigurationRoot CreateConfigurationManager(string key, string value)
        {
            var builder = new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string>
                {
                { "root_url", "http://localhost:5001" }
            });

            return builder.Build();
        }
        public IConfiguration CreateConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string>
                {
                    { "root_url", "http://localhost:5001" }
                })
                .Build();

            return configuration;
        }

        /*
        private void rigMapper()
        {
            //var mappingProfile = new NiN3.Infrastructure.Mapping.Profiles.AllProfiles(CreateConfiguration());
            var mappingProfile = new NiN3.Infrastructure.Mapping.Profiles.AllProfiles();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(mappingProfile);
                //cfg.ValidateInlineMaps = false;
            });
            _mapper = new Mapper(config);
            config.AssertConfigurationIsValid();
            //config.ValidateInlineMaps();
        }*/

        [Fact]
        public void TestAllCodesVersjon()
        {
            //rigMapper();
            var inmemorydb = GetInMemoryDb();
            var loader = new LoaderService(null, inmemorydb, new Mock<ILogger<LoaderService>>().Object);
            var service = new TypeApiService(_mapper, inmemorydb, _logger);
            loader.OpprettInitDb();
            ////loader.LoadHovedtypeData();
            var v3allCodes = service.AllCodes("3.0");
            Assert.Equal("3.0", v3allCodes.Navn);
            Assert.NotNull(v3allCodes);
            //Assert.Null(v3alleCodes.Typer);
            Assert.Equal(10, v3allCodes.Typer.Count);
            var firstType = v3allCodes.Typer.First();
            Assert.Equal("A-LV-BM", firstType.Kode.Id);
            Assert.Equal("abiotisk landformvariasjon bremassiv", firstType.Navn);
            Assert.Equal("https://nin-kode-api.artsdatabanken.no/v3.0/typer/hentkode/A-LV-BM", firstType.Kode.Definisjon);

            Assert.Equal(10, firstType.Hovedtypegrupper.Count);
            var hovedtypegruppe = firstType.Hovedtypegrupper.Where(htg => htg.Kode.Id == "0-MS").First();
            Assert.Equal("0-MS", hovedtypegruppe.Kode.Id);
            Assert.Equal(11, hovedtypegruppe.Hovedtyper.Count);
            // get second hovedtype from firstHovedtypegruppe.Hovedtyper
            var hovedtype = hovedtypegruppe.Hovedtyper.Where(ht => ht.Kode.Id == "MS-0-08").First();
            Assert.Equal("MS-0-08", hovedtype.Kode.Id);
            Assert.Equal(1, hovedtype.Grunntyper.Count);
            var grunntype = hovedtype.Grunntyper.First();
            Assert.Equal("MS-0-08-01", grunntype.Kode.Id);
        }
    }
}

