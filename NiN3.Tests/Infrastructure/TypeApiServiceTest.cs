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
using NiN3.Infrastructure.Mapping;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using NiN3.Core.Models;

namespace NiN3.Tests.Infrastructure
{
    public class TypeApiServiceTest
    {



        private IMapper _mapper;
        private ILogger<TypeApiService> _logger;
        private NiN3DbContext inmemorydb;

        public TypeApiServiceTest()
        {
            _logger = new Mock<ILogger<TypeApiService>>().Object;
        }

        private TypeApiService GetPrepearedTypeApiService()
        {
            inmemorydb = GetInMemoryDb();
            var mapper = NiNkodeMapper.Instance;
            mapper.SetConfiguration(CreateConfiguration());
            var loader = new LoaderService(null, inmemorydb, new Mock<ILogger<LoaderService>>().Object);
            var service = new TypeApiService(inmemorydb, _logger);
            //loader.OpprettInitDb();
            loader.load_all_data();
            return service;
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

        
        public IConfiguration CreateConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string>
                {
                    { "root_url", "http://localhost:5001/v3.0" }
                })
                .Build();

            return configuration;
        }


        ///<summary>
        ///Tests that all NiN-koder for "Typer" in version 3.0 can be loaded and parsed correctly.
        ///</summary>
        [Fact]
        public void TestAllCodesVersjon()
        {
            //rigMapper();
            TypeApiService service = GetPrepearedTypeApiService();
            ////loader.LoadHovedtypeData();
            var v3allCodes = service.AllCodes("3.0");
            Assert.Equal("3.0", v3allCodes.Navn);
            Assert.NotNull(v3allCodes);
            //Assert.Null(v3alleCodes.Typer);
            Assert.Equal(10, v3allCodes.Typer.Count);
            var firstType = v3allCodes.Typer.First();
            Assert.Equal("A-LV-BM", firstType.Kode.Id);
            Assert.Equal("abiotisk landformvariasjon bremassiv", firstType.Navn);
            //Assert.Equal("https://nin-kode-api.artsdatabanken.no/v3.0/typer/hentkode/A-LV-BM", firstType.Kode.Definisjon);
            Assert.StartsWith("http", firstType.Kode.Definisjon);
            Assert.EndsWith("/v3.0/typer/hentkode/A-LV-BM", firstType.Kode.Definisjon);
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

        ///<summary>
        ///Tests that a Kartleggingsenhet exists under a Hovedtype 
        ///and is placed correctly in the Type hierarchy.
        ///</summary>
        [Fact]
        public void TestAllCodes_kartleggingsenhet_exist_under_hovedtype() {
            var service = GetPrepearedTypeApiService();
            var v3allCodes = service.AllCodes("3.0");
            var type_C_PE_NA = v3allCodes.Typer.FirstOrDefault(t => t.Kode.Id == "C-PE-NA");
            //assert not null
            Assert.NotNull(type_C_PE_NA);
            var htg_NA_I = type_C_PE_NA.Hovedtypegrupper.FirstOrDefault(htg => htg.Kode.Id == "NA-I");
            //assert not null
            Assert.NotNull(htg_NA_I);
            var ht_I_A_01 = htg_NA_I.Hovedtyper.FirstOrDefault(ht => ht.Kode.Id == "I-A-01");
            //assert not null
            Assert.NotNull(ht_I_A_01);
            var kl_IA01_M005_03 = ht_I_A_01.Kartleggingsenheter.SingleOrDefault(ke => ke.Kode == "NiN-3.0-T-C-PE-NA-MB-IA01-M005-03");
            Assert.NotNull(kl_IA01_M005_03);
            Assert.Equal("kryokonitt-preget breoverflate", kl_IA01_M005_03.Navn);
            Assert.Equal("Kartleggingsenhet", kl_IA01_M005_03.Kategori);
        }
    }
}

