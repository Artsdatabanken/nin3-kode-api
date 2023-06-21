using NiN3.Core.Models.Enums;

namespace NiN3KodeAPI.in_data
{
    public class CsvdataImporter_Hovedtypegruppe
    {
        public Typekategori2Enum Typekategori2 { get; set; }   
        public string Hovedtypegruppe { get; set;}
        public string Hovedtypegruppenavn { get; set;}
        public string Kode { get; set; }
        internal static CsvdataImporter_Hovedtypegruppe ParseRow(string row)
        {
            var columns = row.Split(';');
            return new CsvdataImporter_Hovedtypegruppe()
            {
                Typekategori2 = EnumUtil.ParseEnum<Typekategori2Enum>(columns[0]),
                Hovedtypegruppe = columns[1],
                Hovedtypegruppenavn = columns[2],
                Kode = columns[3]
            };
        }

        public static List<CsvdataImporter_Hovedtypegruppe> ProcessCSV(string path)
        {
            return File.ReadAllLines(path)
                .Skip(1)
                .Where(row => row.Length > 0)
                .Select(CsvdataImporter_Hovedtypegruppe.ParseRow).ToList();
        }
    }
}
