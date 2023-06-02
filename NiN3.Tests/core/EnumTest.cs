
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
