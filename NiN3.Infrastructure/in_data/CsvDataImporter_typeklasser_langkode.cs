using NiN3.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiN3.Infrastructure.in_data
{
    public class CsvDataImporter_typeklasser_langkode
    {
        public string kode { get; set; }
        public string langkode { get; set; }
        internal static CsvDataImporter_typeklasser_langkode ParseTypeRow(string row)
        {
            var columns = row.Split(';');
            
            return new CsvDataImporter_typeklasser_langkode()
            {
                langkode = columns[3],
                kode = columns[0]
            };
        }

        internal static CsvDataImporter_typeklasser_langkode ParseHovedtypegruppeRow(string row)
        {
            var columns = row.Split(';');

            return new CsvDataImporter_typeklasser_langkode()
            {
                langkode = columns[3],
                kode = columns[1]
            };
        }

        internal static CsvDataImporter_typeklasser_langkode ParseHovedtypeRow(string row)
        {
            var columns = row.Split(';');
            return new CsvDataImporter_typeklasser_langkode()
            {
                langkode = columns[3],
                kode = columns[2]
            };
        }

        public static List<CsvDataImporter_typeklasser_langkode> ProcessCSV(string path, TypeklasseTypeEnum typeklasseTypeEnum)
        {

            switch (typeklasseTypeEnum)
            {
                case TypeklasseTypeEnum.T:
                 return System.IO.File.ReadAllLines(path)
                .Skip(1)
                .Where(row => row.Length > 0)
                .Select(CsvDataImporter_typeklasser_langkode.ParseTypeRow).ToList();
                    break;
                case TypeklasseTypeEnum.HTG:
                    return System.IO.File.ReadAllLines(path)
                   .Skip(1)
                   .Where(row => row.Length > 0)
                   .Select(CsvDataImporter_typeklasser_langkode.ParseHovedtypegruppeRow).ToList();
                    break;
                case TypeklasseTypeEnum.HT:
                    return System.IO.File.ReadAllLines(path)
                   .Skip(1)
                   .Where(row => row.Length > 0)
                   .Select(CsvDataImporter_typeklasser_langkode.ParseHovedtypeRow).ToList();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeklasseTypeEnum), typeklasseTypeEnum, null);
            }            
        }

    }
}
