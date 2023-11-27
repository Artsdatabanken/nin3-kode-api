using NiN3.Infrastructure.in_data;

namespace NiN3.Tests.Infrastructure
{
    public class CsvDataImporterTests
    {
        [Fact]
        public void TestImportGrunntype()
        {
            //how to 
            var result = CsvdataImporter_Grunntype.ProcessCSV(@"in_data\grunntyper.csv");
            
            Assert.Equal(1401, result.Count);
        }
    }
}
