﻿using Microsoft.Extensions.Diagnostics.HealthChecks;
using NiN3KodeAPI.Entities.Enums;

namespace NiN3KodeAPI.in_data
{
    public class CsvdataImporter_Hovedtype
    {
        public string Hovedtype { get; set; }
        public ProsedyrekategoriEnum Prosedyrekategori { get; set; }
        public string Hovedtypegruppe { get; set; }
        public string Hovedtypenavn { get; set; }
        public string Kode { get; set; }

        internal static CsvdataImporter_Hovedtype ParseRow(string row)
        {
            var columns = row.Split(';');
            return new CsvdataImporter_Hovedtype()
            {
                Hovedtype = columns[0],
                Prosedyrekategori = EnumUtil.ParseEnum<ProsedyrekategoriEnum>(columns[1]),
                Hovedtypegruppe = columns[2],
                Hovedtypenavn = columns[3],
                Kode = columns[4]
            };
        }

        public static List<CsvdataImporter_Hovedtype> ProcessCSV(string path)
        {
            return File.ReadAllLines(path)
                .Skip(1)
                .Where(row => row.Length > 0)
                .Select(CsvdataImporter_Hovedtype.ParseRow).ToList();
        }
    }
}
