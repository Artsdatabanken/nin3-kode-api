using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Infrastructure.in_data
{
    public class CsvDataImporter_grunntype_variabeltrinn
    {

        public string grunntype_kode { get; set; }
        public string varkode2 { get; set; }
        public string trinn { get; set; }

        internal static CsvDataImporter_grunntype_variabeltrinn ParseRow(string row)
        {
            var columns = row.Split(';');
            return new CsvDataImporter_grunntype_variabeltrinn()
            {
                grunntype_kode = columns[0],
                varkode2 = columns[1],
                trinn = columns[2]

            };
        }
        public static List<CsvDataImporter_grunntype_variabeltrinn> ProcessCSV(string path)
        {
            return System.IO.File.ReadAllLines(path)
                .Skip(1)
                .Where(row => row.Length > 0)
                .Select(CsvDataImporter_grunntype_variabeltrinn.ParseRow).ToList();
        }
    }
}

