
using NiN3.Core.Models.Enums;
using System.Xml.Serialization;

namespace NiN3.Tests.Test.core
{
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
            //Spesiell variasjonsbredde. Sterkt endret system.Hevdpreget.Jordbruksmark.
            var stringToParse = "O";
            ProsedyrekategoriEnum e = EnumUtil.ParseEnum<ProsedyrekategoriEnum>(stringToParse);
            Assert.Equal(stringToParse, e.ToString());
            Assert.Equal("Spesiell variasjonsbredde. Sterkt endret system. Hevdpreget. Jordbruksmark.", EnumUtil.ToDescription(e));
        }

        // q: write test that fetches Enum with EnumUtil.ParseEnum for value "NK", enum: TypeKategori3Enum, and checks the Description attribute for typekategori3enum using EnumUtil.ToDescription
        [Fact]
        public void TestFetchEnumDescription()
        {
            Typekategori3Enum result = EnumUtil.ParseEnum<Typekategori3Enum>("NK");
            Assert.Equal("vannmassesystemer", EnumUtil.ToDescription(result));
        }
    }
}
