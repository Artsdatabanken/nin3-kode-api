using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using NiN.Infrastructure.Services;
using NiN3.Core.Models.Enums;
using NiN3.Infrastructure.DbContexts;
using NiN3.Infrastructure.Mapping;
using NiN3.Infrastructure.Services;

namespace NiN3.Tests.Infrastructure
{
    [Collection("Sequential")]
    public class TypeApiServiceTest
    {



        private IMapper _mapper;
        private ILogger<TypeApiService> _logger;
        private NiN3DbContext inmemorydb;

        
        public TypeApiServiceTest()
        {
            _logger = new Mock<ILogger<TypeApiService>>().Object;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reloadDB"></param>
        /// <returns></returns>

        private TypeApiService GetPrepearedTypeApiService(bool reloadDB = false)
        {
            inmemorydb = InMemoryDbContextFactory.GetInMemoryDb(reloadDB);
            var mapper = NiNkodeMapper.Instance;
            mapper.SetConfiguration(CreateConfiguration());
            if (inmemorydb.Type.Count() == 0) {//if data is not allready loaded 
                var loader = new LoaderService(null, inmemorydb, new Mock<ILogger<LoaderService>>().Object);
                loader.load_all_data();
            }
            var service = new TypeApiService(inmemorydb, _logger);
            //loader.OpprettInitDb();
            return service;
        }

        /*
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
        }*/

        
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
        ///Tests that all NiN-koder for "TypeDto" in version 3.0 can be loaded and parsed correctly.
        ///</summary>
        [Fact]
        public async Task TestAllTypeCodesInVersjon()
        {
            //rigMapper();
            TypeApiService service = GetPrepearedTypeApiService();
            var v3allCodes = await service.AllCodesAsync("3.0");
            Assert.Equal("3.0", v3allCodes.Navn);
            Assert.NotNull(v3allCodes);
            Assert.Equal(10, v3allCodes.Typer.Count);
            var firstType = v3allCodes.Typer.First();
            Assert.Equal("A-LV-BM", firstType.Kode.Id);
            Assert.Equal("Bremassiv", firstType.Navn);
            Assert.StartsWith("http", firstType.Kode.Definisjon);
            Assert.EndsWith("/v3.0/typer/kodeforType/A-LV-BM", firstType.Kode.Definisjon);
            var hovedtypegrupper = firstType.Hovedtypegrupper.Where(htg => htg.Kode.Id == "0-MS").ToList();
            Assert.True(hovedtypegrupper.Count == 1);
            var hovedtypegruppe = hovedtypegrupper.First();
            Assert.Equal("0-MS", hovedtypegruppe.Kode.Id);
            Assert.Equal("Vannmassesystemer", hovedtypegruppe.Typekategori3Navn);
            Assert.Equal(10, hovedtypegruppe.Hovedtyper.Count);
            // get second hovedtype from firstHovedtypegruppe.Hovedtyper
            var hovedtype = hovedtypegruppe.Hovedtyper.Where(ht => ht.Kode.Id == "MS-0-08").First();
            Assert.Equal("MS-0-08", hovedtype.Kode.Id);
            //assert prosedyrekategori
            Assert.Equal("Normal variasjonsbredde. Variasjon i artssammensetning ikke betinget av strukturerende artsgruppe. Lite endret system.", hovedtype.ProsedyrekategoriNavn);
            Assert.Equal(1, hovedtype.Grunntyper.Count);
            var grunntype = hovedtype.Grunntyper.First();
            Assert.Equal("MS-0-08-01", grunntype.Kode.Id);
            Assert.Equal("NIN-3.0-T-A-LV-BM", firstType.Kode.Langkode);
        }


        [Fact]
        public void TestGetTypeKlasse() {
            TypeApiService service = GetPrepearedTypeApiService();
            var typeklasse = service.GetTypeklasse("A-LV-BM", "3.0");
            Assert.NotNull(typeklasse);
            Assert.Equal("Type", typeklasse.KlasseNavn);
            Assert.Equal(KlasseEnum.T, typeklasse.KlasseEnum);
        }
        
        [Fact]
        public void TestGetTypeByKortkode() {
            TypeApiService service = GetPrepearedTypeApiService();
            var type = service.GetTypeByKortkode("A-LV-BM", "3.0");
            Assert.NotNull(type);
        }

        [Fact]
        public void TestGetHovedtypegruppeByKortkode()
        {
            TypeApiService service = GetPrepearedTypeApiService();
            var hovedtypegruppe = service.GetHovedtypegruppeByKortkode("FL-G", "3.0");
            Assert.NotNull(hovedtypegruppe);
        }

        [Fact]
        public void TestGetHovedtypeByKortkode()
        {
            TypeApiService service = GetPrepearedTypeApiService();
            var hovedtype = service.GetHovedtypeByKortkode("M-A-06", "3.0");
            Assert.NotNull(hovedtype);
        }


        [Fact]
        public void TestGetGrunntypeByKortkode()
        {
            TypeApiService service = GetPrepearedTypeApiService();
            var grunntype = service.GetGrunntypeByKortkode("K-0-02-006", "3.0");
            Assert.NotNull(grunntype);
        }


        [Fact]
        public void TestGetKartleggingsenhetByKortkode()
        {
            TypeApiService service = GetPrepearedTypeApiService();
            var kartleggingsenhet = service.GetKartleggingsenhetByKortkode("LA01-M005-13", "3.0");
            Assert.NotNull(kartleggingsenhet);
        }


        ///<summary>
        ///Tests that a Kartleggingsenhet exists under a Hovedtype 
        ///and is placed correctly in the Type hierarchy.
        ///</summary>
        [Fact]
        public async Task TestAllCodes_kartleggingsenhet_exist_under_hovedtype_m005()
        {
            var service = GetPrepearedTypeApiService();
            var v3allCodesTask = service.AllCodesAsync("3.0");

            var v3allCodes = await v3allCodesTask.ConfigureAwait(false);
            var type_C_PE_NA = v3allCodes.Typer.FirstOrDefault(t => t.Kode.Id == "C-PE-NA");
            //assert not null
            Assert.NotNull(type_C_PE_NA);
            var htg_NA_I = type_C_PE_NA.Hovedtypegrupper.FirstOrDefault(htg => htg.Kode.Id == "NA-I");
            //assert not null
            Assert.NotNull(htg_NA_I);
            var ht_I_A_01 = htg_NA_I.Hovedtyper.FirstOrDefault(ht => ht.Kode.Id == "I-A-01");
            //assert not null
            Assert.NotNull(ht_I_A_01);
            var kl_IA01_M005_03 = ht_I_A_01.Kartleggingsenheter.SingleOrDefault(ke => ke.Kode.Langkode == "NiN-3.0-T-C-PE-NA-MB-IA01-M005-03");
            Assert.NotNull(kl_IA01_M005_03);
            Assert.Equal("Kryokonitt-preget breoverflate", kl_IA01_M005_03.Navn);
            Assert.Equal("Kartleggingsenhet", kl_IA01_M005_03.Kategori);
            Assert.Equal("Kartleggingsenhet tilpasset 1:5000", kl_IA01_M005_03.MaalestokkNavn);
        }

        /// <summary>
        /// This is a unit test for TypeApiService.
        /// </summary>|
        [Fact]
        public async Task TestAllCodes_kartleggingsenhet_exist_under_hovedtype_m020()
        {
            //arrange
            var service = GetPrepearedTypeApiService();

            //act
            var v3allCodes = await service.AllCodesAsync("3.0");
            var type_C_PE_NA = v3allCodes.Typer.FirstOrDefault(t => t.Kode.Id == "C-PE-NA");
            var htg_NA_I = type_C_PE_NA.Hovedtypegrupper.FirstOrDefault(htg => htg.Kode.Id == "NA-I");
            var ht_I_A_01 = htg_NA_I.Hovedtyper.FirstOrDefault(ht => ht.Kode.Id == "I-A-01");
            var kl_IA01_M020_02 = ht_I_A_01.Kartleggingsenheter.SingleOrDefault(ke => ke.Kode.Langkode == "NiN-3.0-T-C-PE-NA-MB-IA01-M020-02");

            //assert
            Assert.NotNull(type_C_PE_NA);
            Assert.NotNull(htg_NA_I);
            Assert.NotNull(ht_I_A_01);
            Assert.NotNull(kl_IA01_M020_02);
            Assert.Equal("Polar havis-overside", kl_IA01_M020_02.Navn);
            Assert.Equal("Kartleggingsenhet", kl_IA01_M020_02.Kategori);
            Assert.Equal("Kartleggingsenhet tilpasset 1:20 000", kl_IA01_M020_02.MaalestokkNavn);
        }

        [Fact]
        public void TestGetGrunntypeByKodeAndVariabeltrinn() { 
            TypeApiService service = GetPrepearedTypeApiService();
            var grunntype = service.GetGrunntypeByKortkode("T-E-05-01", "3.0");
            Assert.NotNull(grunntype);
            var variabeltrinn = grunntype.Variabeltrinn;
            Assert.Equal(3, variabeltrinn.Count());
            var single_variabeltrinn = variabeltrinn.First();
            Assert.Equal(2, single_variabeltrinn.Maaleskala.Trinn.Count());
            Assert.Equal(null, single_variabeltrinn.Variabelnavn);
            //var trinnkoder = 

        }
    }
}

