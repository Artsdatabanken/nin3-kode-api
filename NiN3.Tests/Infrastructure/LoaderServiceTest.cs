using DocumentFormat.OpenXml.InkML;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NiN.Infrastructure.Services;
using NiN3.Core.Models.Enums;
using NiN3.Infrastructure.DbContexts;

namespace NiN3.Tests.Infrastructure
{

    [Collection("Sequential")]
    public class LoaderServiceTest
    {
        private LoaderService _loaderService;
        private ILogger<LoaderService> _logger;

        //Methods that alter data must call InMemoryDbContextFactory.Dispose() after test is done
        public LoaderServiceTest()
        {
            _logger = new Mock<ILogger<LoaderService>>().Object;
        }
        private static NiN3DbContext GetInMemoryDb()//out SqliteConnection connection, out DbContextOptions<NiN3DbContext> options)
        {
            var inmemorydb = InMemoryDbContextFactory.GetInMemoryDb();
            if (inmemorydb.Type.Count() == 0)
            {//if data is not allready loaded 
                var loader = new LoaderService(null, inmemorydb, new Mock<ILogger<LoaderService>>().Object);
                loader.load_all_data();
            }
            return inmemorydb;
        }


        [Fact]
        public void TestLoadType()
        {
            // Get an instance of the InMemoryDb class
            var inmemorydb = GetInMemoryDb();
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
            Assert.Equal("Bremassiv", type_eco_A.Navn);
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
            //Get the number of Hovedtypegruppe objects in the InMemoryDb object
            var numOfHGD = inmemorydb.Hovedtypegruppe.Count();
            //q: get the first Hovedtypegruppe object in the InMemoryDb object after ordering by Kode
            var firstHGD = inmemorydb.Hovedtypegruppe.OrderBy(x => x.Kode).First();
            //Assert that the number of Hovedtypegruppe objects is equal to 71
            Assert.Equal(72, numOfHGD);


            //Testing langkode for Hovedtypegruppe that should have typekategori3 embedded in langkode
            var HTG_NA_T = inmemorydb.Hovedtypegruppe.Where(x => x.Kode == "NA-T").FirstOrDefault();
            Assert.Equal("NIN-3.0-T-C-PE-NA-MB-NA-T", HTG_NA_T.Langkode);
            
            //Testing langkode for Hovedtypegruppe that should NOT have typekategori3 embedded in langkode

        }

        [Fact]
        public void TestLoadhovedtypeGruppeAndCheckHovedoekosystem() {
            //Create an InMemoryDb object
            var inmemorydb = GetInMemoryDb();

            //Testing a Hovedtypegruppe with one Hovedoekosystem
            var HTG_NA_T = inmemorydb.Hovedtypegruppe.Where(x => x.Kode == "NA-T").FirstOrDefault();
            Assert.Equal("NIN-3.0-T-C-PE-NA-MB-NA-T", HTG_NA_T.Langkode);
            Assert.Equal("Fastmarkssystemer", HTG_NA_T.Navn);
            Assert.Equal(1, HTG_NA_T.Hovedoekosystemer.Count);
            var Hovedtypgruppe_Hovedoekosystem = HTG_NA_T.Hovedoekosystemer.FirstOrDefault();
            Assert.Equal(HovedoekosystemEnum.L, Hovedtypgruppe_Hovedoekosystem.HovedoekosystemEnum);

            //Testing a Hovedtypegruppe with multiple Hovedoekosystemer
            var HTG_FL_I = inmemorydb.Hovedtypegruppe.Where(x => x.Kode == "FL-I").FirstOrDefault();
            Assert.Equal(2, HTG_FL_I.Hovedoekosystemer.Count);
            var Hovedtypgruppe_Hovedoekosystem_First = HTG_FL_I.Hovedoekosystemer.FirstOrDefault();
            var Hovedtypgruppe_Hovedoekosystem_Second = HTG_FL_I.Hovedoekosystemer.LastOrDefault();
            Assert.Equal(HovedoekosystemEnum.H, Hovedtypgruppe_Hovedoekosystem_First.HovedoekosystemEnum);
            Assert.Equal(HovedoekosystemEnum.L, Hovedtypgruppe_Hovedoekosystem_Second.HovedoekosystemEnum);
        }

        [Fact]
        //This code tests the LoadHovedtype method by creating an in-memory database,
        //instantiating a LoaderService object, and then calling the LoadHovedtypeGruppeData, LoadHtg_Ht_Gt_Mappings,
        //and LoadHovedtypeData methods. Finally, it checks that the number of Hovedtype objects in the in-memory database is equal to 445. 

        public void TestLoadHovedtype()
        {
            //Create an in-memory database
            var inmemorydb = GetInMemoryDb();

            //Check that the number of Hovedtype objects in the in-memory database is equal to 445
            var numOfHD = inmemorydb.Hovedtype.Count();
            var hovedtyper = inmemorydb.Hovedtype.ToList();
            Assert.Equal(450, numOfHD);
            var HT_0_C_01 = inmemorydb.Hovedtype.Where(x => x.Kode == "0-C-01").FirstOrDefault();
            Assert.NotNull(HT_0_C_01);
            Assert.Equal("Varmkildekompleks", HT_0_C_01.Navn);
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
            // Get the number of Grunntype records
            var numOfGD = inmemorydb.Grunntype.Count();
            // Assert that the number of records is 166
            Assert.Equal(1403, numOfGD);
            // Get the Grunntype record with the code "M-A-01-05"
            var grunntype = inmemorydb.Grunntype.Where(gt => gt.Kode == "M-A-01-05").FirstOrDefault();
            // Assert that the name of the record is "sukkertareskog"
            Assert.Equal("Spiraltangbunn", grunntype.Navn);
            // Assert that the delkode of the record is "05"
            Assert.Equal("05", grunntype.Delkode);
            //Testing langkode for M-A-01-05
            Assert.Equal("NIN-3.0-T-C-PE-NA-MB-M-A-01-05", grunntype.Langkode);
        }                

        [Fact]
        public void TestLoadKartleggingsenhet_m005()
        {
            var inmemorydb = GetInMemoryDb();
            var numOfKE = inmemorydb.Kartleggingsenhet.Count();
            var firstKE = inmemorydb.Kartleggingsenhet.OrderBy(x => x.Kode).First();
            var hovedtype_kartlegginsenhetFirstKE = inmemorydb.Hovedtype_Kartleggingsenhet.Where(x => x.Kartleggingsenhet.Id == firstKE.Id).FirstOrDefault();
            Assert.NotNull(hovedtype_kartlegginsenhetFirstKE);
            Assert.Equal("Varig snø", firstKE.Navn);
            Assert.Equal(1278, numOfKE);
            Assert.Equal("NiN-3.0-T-C-PE-NA-MB-IA01-M005-01", firstKE.Langkode);
        }

        //create test for loadvariabel
        [Fact]
        public void TestLoadVariabel()
        {
            var inmemorydb = GetInMemoryDb();
            // Create a new LoaderService instance
            var numOfV = inmemorydb.Variabel.Count();
            var firstV = inmemorydb.Variabel.OrderBy(x => x.Kode).First();
            Assert.NotNull(firstV);
            Assert.Equal("A-M", firstV.Kode);
            Assert.Equal("Abiotisk menneskebetinget", firstV.Navn);
            Assert.Equal(4, numOfV);
            Assert.Equal("NIN-3.0-V-A-M", firstV.Langkode);
        }

        [Fact]  
        public void TestLoadVariabelnavn()
        {
            var inmemorydb = GetInMemoryDb();
            var VariabelnavnList = inmemorydb.Variabelnavn.ToList();
            var numOfVN = VariabelnavnList.Count();
            var firstVN = VariabelnavnList.OrderBy(x => x.Kode).First();
            Assert.NotNull(firstVN);
            Assert.Equal(370, numOfVN);
            Assert.True(firstVN.Kode == "AD-FA");
            Assert.True(firstVN.Navn == "Fremmedartsantall");
            Assert.True(firstVN.Variabelkategori2.ToString() == "AD");
            Assert.True(firstVN.Variabelgruppe.ToString() == "FA");
            Assert.True(firstVN.Variabeltype.ToString() == "GE");
            Assert.True(firstVN.Versjon.Navn == "3.0");
        }


        /// <summary>
        /// Test method for loading of the Variabeltrinn.
        /// </summary>
        [Fact]
        public void TestLoadMaaleskala()
        {
            // prepare test
            var inmemorydb = GetInMemoryDb();
            var numOfMS = inmemorydb.Maaleskala.Count();
            Assert.Equal(157, numOfMS);
            var maaleskalaSO = inmemorydb.Maaleskala.FirstOrDefault(m => m.MaaleskalatypeEnum == MaaleskalatypeEnum.SO);
            var maaleskalaSI = inmemorydb.Maaleskala.FirstOrDefault(m => m.MaaleskalatypeEnum == MaaleskalatypeEnum.SI);
            Assert.NotNull(maaleskalaSO);
            Assert.True(EnhetEnum.VSO == maaleskalaSO.EnhetEnum);
            Assert.True(EnhetEnum.VSI == maaleskalaSI.EnhetEnum);
        }


        [Fact]
        public void TestLoadTrinn() {
            // prepare test
            var inmemorydb = GetInMemoryDb();
            //var numOfTrinn = inmemorydb.Trinn.ToList().Count();
            //Assert.Equal(1023,numOfTrinn);

            var trinnNhB = inmemorydb.Trinn.Where(trinn => trinn.Verdi == "NH_B").FirstOrDefault();
            var bMaaleskala = inmemorydb.Maaleskala.Where(m=> m.MaaleskalaNavn == "B").FirstOrDefault();
            Assert.Equal(2, bMaaleskala.Trinn.Count);//Checking that Binær-måleskala is loaded and has its trinn
            Assert.Equal("Barentshavet og Polhavet", trinnNhB.Beskrivelse);
            Assert.Equal(MaaleskalatypeEnum.SI, trinnNhB.Maaleskala.MaaleskalatypeEnum);
            //var uniqueCount = inmemorydb.Trinn.Select(x => x.Verdi).Distinct().Count();
            //assert that trinn-navn is unique
            //Assert.Equal(numOfTrinn, uniqueCount);
        }

        [Fact]
        public void TestMakeMaalestokkMappingForVariabelnavn() {
            var inmemorydb = GetInMemoryDb();

            var vn_LO_KA = inmemorydb.Variabelnavn.Where(x => x.Kode == "LO-KA").FirstOrDefault();
            Assert.NotNull(vn_LO_KA);
            Assert.Equal("LO-KA", vn_LO_KA.Kode);
            Assert.Equal(2, vn_LO_KA.VariabelnavnMaaleskala.Count);
            var maaleskalasInVn = vn_LO_KA.VariabelnavnMaaleskala.Select(x => x.Maaleskala).OrderBy(x => x.MaaleskalaNavn).ToList();
            Assert.Equal(2, maaleskalasInVn.Count);
            Assert.Equal("D0", maaleskalasInVn[0].MaaleskalaNavn);
            Assert.Equal(11, maaleskalasInVn[0].Trinn.Count);
            Assert.Equal("T0", maaleskalasInVn[1].MaaleskalaNavn);
            Assert.Equal(16, maaleskalasInVn[1].Trinn.Count);
        }

        [Fact]
        public void TestFetchTrinnFromVariabelnavn()
        {
            // prepare test
            var inmemorydb = GetInMemoryDb();
            // Testing Trinn mapping
            var variabelnavn = inmemorydb.Variabelnavn.Where(x => x.Kode == "RM-MS").FirstOrDefault();
            //var variabelnavnRMMS = inmemorydb.Variabelnavn
            //                     .Where(v => v.Kode == "RM-MS")
            //                     .Include(v => v.VariabelnavnMaaleskala).FirstOrDefault();
           
            
            Assert.Equal(1, variabelnavn.VariabelnavnMaaleskala.Count);
            /*Assert.Equal("marine bioklimatiske soner", trinnMapping.Variabelnavn.Navn);
            Assert.Equal("MS-a", trinnMapping.Trinn.Navn);
            Assert.Equal("Nordsjøen og Skagerrak", trinnMapping.Trinn.Verdi);
            Assert.Equal(MaaleskalatypeEnum.SO, trinnMapping.Variabeltrinn.MaaleskalatypeEnum);*/
        }

        [Fact]
        public void TestLoadGrunntypeVariabelTrinnMapping() {
            // prepare test
            var inmemorydb = GetInMemoryDb();
            var gtvt = inmemorydb.GrunntypeVariabeltrinn.Count();
            Assert.True(12000<gtvt);
            var grunntype_TE05_01 = inmemorydb.Grunntype.Where(x => x.Kode == "T-E-05-01").FirstOrDefault(); 
            Assert.NotNull(grunntype_TE05_01);
            Assert.Equal(7, grunntype_TE05_01.GrunntypeVariabeltrinn.Count());
        }


        [Fact]
        public void TestLoadAlleKortkoderForType() {
            var inmemorydb = GetInMemoryDb();
            //service.LoadAlleKortkoder();
            var numOfKortkoder = inmemorydb.AlleKortkoder.Count();
            Assert.Equal(3587, numOfKortkoder);
            var kortkode = inmemorydb.AlleKortkoder.Where(x => x.Kortkode == "IB-F").FirstOrDefault();            
            Assert.NotNull(kortkode);
            Assert.Equal("IB-F", kortkode.Kortkode);
            Assert.Equal(KlasseEnum.HTG, kortkode.TypeKlasseEnum);
            Assert.Null(kortkode.KortkodeV2); // not yet impl.
            var numOfTyper= inmemorydb.Type.Count();
            var numOfHovedtypegrupper = inmemorydb.Hovedtypegruppe.Count();
            var numOfHovedtyper = inmemorydb.Hovedtype.Count();
            var numOfGrunntyper = inmemorydb.Grunntype.Count();
            var numOfKartleggingsenheter = inmemorydb.Kartleggingsenhet.Count();
            var countHTinAlleKortkoder = inmemorydb.AlleKortkoder.Count(x => x.TypeKlasseEnum == KlasseEnum.HT);
            var countTypeinAlleKortkoder = inmemorydb.AlleKortkoder.Count(x => x.TypeKlasseEnum == KlasseEnum.T);
            var countHtginAlleKortkoder = inmemorydb.AlleKortkoder.Count(x => x.TypeKlasseEnum == KlasseEnum.HTG);
            var countGtinAlleKortkoder = inmemorydb.AlleKortkoder.Count(x => x.TypeKlasseEnum == KlasseEnum.GT);
            var countKeinAlleKortkoder = inmemorydb.AlleKortkoder.Count(x => x.TypeKlasseEnum == KlasseEnum.KE);
            Assert.True(numOfTyper == countTypeinAlleKortkoder);
            Assert.True(numOfHovedtypegrupper == countHtginAlleKortkoder);
            Assert.Equal(numOfHovedtyper,countHTinAlleKortkoder);
            Assert.True(numOfGrunntyper == countGtinAlleKortkoder);
            Assert.True(numOfKartleggingsenheter == countKeinAlleKortkoder);
        }

        [Fact]
        public void TestLoadAlleKortkoder_Variabler() {
            var inmemorydb = GetInMemoryDb();
            var numOfVariabelAllekortkoder = inmemorydb.AlleKortkoder.Count(x => x.TypeKlasseEnum == KlasseEnum.V);
            var numOfVariabelnavnAllekortkoder = inmemorydb.AlleKortkoder.Count(x => x.TypeKlasseEnum == KlasseEnum.VN);
            Assert.Equal(4, numOfVariabelAllekortkoder);
            Assert.Equal(370,numOfVariabelnavnAllekortkoder);
        }

        [Fact]
        public void TestLoadEnumoppslag() {
            var inmemorydb = GetInMemoryDb();
            var EnumoppslagEcosystnivaa = inmemorydb.Enumoppslag.Where(e => e.Enumtype== "EcosysnivaaEnum").ToList();
            Assert.Equal(3, EnumoppslagEcosystnivaa.Count);
            var EnumoppslagEnhetEnum = inmemorydb.Enumoppslag.Where(e => e.Enumtype == "EnhetEnum").ToList();
            Assert.Equal(8, EnumoppslagEnhetEnum.Count);
            var EnumoppslagHovedoekosystemEnum = inmemorydb.Enumoppslag.Where(e => e.Enumtype == "HovedoekosystemEnum").ToList();
            Assert.Equal(3, EnumoppslagHovedoekosystemEnum.Count);
            var EnumoppslagKlasseEnum = inmemorydb.Enumoppslag.Where(e => e.Enumtype == "KlasseEnum").ToList(); 
            Assert.Equal(7, EnumoppslagKlasseEnum.Count);
            var EnumoppslagMaaleskalatypeEnum = inmemorydb.Enumoppslag.Where(e => e.Enumtype == "MaaleskalatypeEnum").ToList();
            Assert.Equal(18, EnumoppslagMaaleskalatypeEnum.Count);
            var EnumoppslagProsedyrekategoriEnum = inmemorydb.Enumoppslag.Where(e => e.Enumtype == "ProsedyrekategoriEnum").ToList();
            Assert.Equal(15, EnumoppslagProsedyrekategoriEnum.Count);
            var EnumoppslagMaalestokkEnum = inmemorydb.Enumoppslag.Where(e => e.Enumtype == "MaalestokkEnum").ToList();
            Assert.Equal(5, EnumoppslagMaalestokkEnum.Count);
            var EnumoppslagTypekategoriEnum = inmemorydb.Enumoppslag.Where(e => e.Enumtype == "TypekategoriEnum").ToList();
            Assert.Equal(5, EnumoppslagTypekategoriEnum.Count);
            var EnumoppslagTypekategori2Enum = inmemorydb.Enumoppslag.Where(e => e.Enumtype == "Typekategori2Enum").ToList();
            Assert.Equal(8, EnumoppslagTypekategori2Enum.Count);
            var EnumoppslagTypekategori3Enum = inmemorydb.Enumoppslag.Where(e => e.Enumtype == "Typekategori3Enum").ToList();
            Assert.Equal(2, EnumoppslagTypekategori3Enum.Count);
            var EnumoppslagVariabelgruppeEnum = inmemorydb.Enumoppslag.Where(e => e.Enumtype == "VariabelgruppeEnum").ToList(); 
            Assert.Equal(32, EnumoppslagVariabelgruppeEnum.Count);
            var EnumoppslagVariabeltypeEnum = inmemorydb.Enumoppslag.Where(e => e.Enumtype == "VariabeltypeEnum").ToList();
            Assert.Equal(4, EnumoppslagVariabeltypeEnum.Count);
            var EnumoppslagVariabelkategoriEnum = inmemorydb.Enumoppslag.Where(e => e.Enumtype == "VariabelkategoriEnum").ToList();
            Assert.Equal(2, EnumoppslagVariabelkategoriEnum.Count);
            var EnumoppslagVariabelkategori2Enum = inmemorydb.Enumoppslag.Where(e => e.Enumtype == "Variabelkategori2Enum").ToList();
            Assert.Equal(14, EnumoppslagVariabelkategori2Enum.Count);
        }
    }
}