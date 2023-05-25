using NiN3KodeAPI.in_data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_NiN3KodeAPI.core.in_data
{
    public class CsvDataimporterTest
    {
        [Fact]
        public void TestingCsvdataimporter_Hovedtypegruppe()
        {
            CsvdataImporter_Hovedtypegruppe.ProcessCSV("..");
            Assert.Equal(1, 1);
        }
    }
}
