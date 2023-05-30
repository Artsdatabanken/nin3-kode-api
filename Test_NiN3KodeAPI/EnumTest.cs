using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiN3KodeAPI;
using NiN3KodeAPI.Entities.Enums;

namespace Test_NiN3KodeAPI
{
    public class EnumTest
    {

        [Fact]
        public void TestingEcosystnivaaEnum() {
            var stringToParse = "B";
            EcosystnivaaEnum e = EnumUtil.ParseEnum<EcosystnivaaEnum>(stringToParse);
            var Bvalue = e.ToString();
            Assert.Equal(stringToParse, Bvalue);
            var desc = EnumUtil.ToDescription(e);
            Assert.Equal("biotisk", desc);
        }

        [Fact]
        public void TestEnumUtil_null_values() {
            var doesNotExist = "D";
            EcosystnivaaEnum e = EnumUtil.ParseEnum<EcosystnivaaEnum>(doesNotExist);
            var Bvalue = e.ToString();
            //Assert.Equal(doesNotExist, Bvalue);
            //var desc = EnumUtil.ToDescription(e);
            //Assert.Equal("biotisk", desc);
        }
    }
}
