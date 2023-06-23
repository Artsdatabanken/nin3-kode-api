
using NiN3.Core.Models.Enums;
namespace NiN3.Tests.Test.core
{
    public class EnumTest
    {

        [Fact]
        public void TestingEcosystnivaaEnum()
        {
            var stringToParse = "B";
            EcosystnivaaEnum e = EnumUtil.ParseEnum<EcosystnivaaEnum>(stringToParse);
            var Bvalue = e.ToString();
            Assert.Equal(stringToParse, Bvalue);
            var desc = EnumUtil.ToDescription(e);
            Assert.Equal("biotisk", desc);
        }

        [Fact]
        public void TestingTypeKategoriEnum() {
            var stringToParse = "PE";
            TypekategoriEnum e = EnumUtil.ParseEnum<TypekategoriEnum>(stringToParse);
            var Bvalue = e.ToString();
            Assert.Equal(stringToParse, Bvalue);
            var desc = EnumUtil.ToDescription(e);
            Assert.Equal("primært økodiversitetsnivå", desc);
        }

        [Fact]
        public void TestingTypeKategori2Enum()
        {
            var stringToParse = "NK";
            Typekategori2Enum e = EnumUtil.ParseEnum<Typekategori2Enum>(stringToParse);
            var Bvalue = e.ToString();
            Assert.Equal(stringToParse, Bvalue);
            var desc = EnumUtil.ToDescription(e);
            Assert.Equal("naturkompleks", desc);
        }

        [Fact]
        public void TestingProsedyrekategoriEnum() 
        {
            //Spesiell variasjonsbredde. Sterkt endret system.Hevdpreget.Jordbruksmark.
            var stringToParse = "O";
            ProsedyrekategoriEnum e = EnumUtil.ParseEnum<ProsedyrekategoriEnum>(stringToParse);
            var Bvalue = e.ToString();
            Assert.Equal(stringToParse, Bvalue);
            var desc = EnumUtil.ToDescription(e);
            Assert.Equal("Spesiell variasjonsbredde. Sterkt endret system. Hevdpreget. Jordbruksmark.", desc);
        }

        //NK
        /*
        [Fact]
        public void TestEnumUtil_null_values() {
            //When fetching a non existing 
            var doesNotExist = "D";
            EcosystnivaaEnum e = EnumUtil.ParseEnum<EcosystnivaaEnum>(doesNotExist);
            var Bvalue = e.ToString();
            //Assert.Equal(doesNotExist, Bvalue);
            //var desc = EnumUtil.ToDescription(e);
            //Assert.Equal("biotisk", desc);
        }
        */
    }
}
