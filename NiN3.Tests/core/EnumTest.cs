
using NiN3.Core.Models.Enums;
using System.Xml.Serialization;

namespace NiN3.Tests.Test.core
{

    //<summary>
    // Tests for various Enums using the EnumUtil Class.
    //</summary>
    public class EnumTest
    {

        [Fact]
        public void TestingEcosystnivaaEnum()
        {
            var stringToParse = "B";
            EcosystnivaaEnum e = EnumUtil.ParseEnum<EcosystnivaaEnum>(stringToParse);
            Assert.Equal(stringToParse, e.ToString());
            Assert.Equal("biotisk", EnumUtil.ToDescription(e));
        }

        [Fact]
        public void TestingTypeKategoriEnum()
        {
            var stringToParse = "PE";
            TypekategoriEnum e = EnumUtil.ParseEnum<TypekategoriEnum>(stringToParse);
            Assert.Equal(stringToParse, e.ToString());
            Assert.Equal("primært økodiversitetsnivå", EnumUtil.ToDescription(e));
        }

        [Fact]
        public void TestingTypeKategori2Enum()
        {
            var stringToParse = "NK";
            Typekategori2Enum e = EnumUtil.ParseEnum<Typekategori2Enum>(stringToParse);
            Assert.Equal(stringToParse, e.ToString());
            Assert.Equal("naturkompleks", EnumUtil.ToDescription(e));
        }

        [Fact]
        public void TestingProsedyrekategoriEnum()
        {
            var stringToParse = "O";
            ProsedyrekategoriEnum e = EnumUtil.ParseEnum<ProsedyrekategoriEnum>(stringToParse);
            Assert.Equal(stringToParse, e.ToString());
            Assert.Equal("Spesiell variasjonsbredde. Sterkt endret system. Hevdpreget. Jordbruksmark.", EnumUtil.ToDescription(e));
        }

    
        [Fact]
        public void TestFetchEnumDescription()
        {
            Typekategori3Enum result = EnumUtil.ParseEnum<Typekategori3Enum>("NK");
            Assert.Equal("vannmassesystemer", EnumUtil.ToDescription(result));
        }

        [Fact]
        public void TestMaalestokkEnumDescription()
        {
            MaalestokkEnum result = EnumUtil.ParseEnum<MaalestokkEnum>("M005");
            Assert.Equal("kartleggingsenhet tilpasset 1:5000", EnumUtil.ToDescription(result));
        }
    }
}
