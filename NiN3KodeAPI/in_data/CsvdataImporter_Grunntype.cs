namespace NiN3KodeAPI.in_data
{
    public class CsvdataImporter_Grunntype
    {
        public string Hovedtypegruppe { get; set; }
        public string Prosedyrekategori { get; set; }

        public string Hovedtype { get; set; }
        public string Grunntype { get; set; }
        public string Grunntypenavn { get; set; }

        public string Kode { get; set; }

        internal static CsvdataImporter_Grunntype ParseRow(string row)
        {
            var columns = row.Split(';');
            return new CsvdataImporter_Grunntype()
            {
                Hovedtype = columns[2],
                Prosedyrekategori = columns[1],
                Hovedtypegruppe = columns[0],
                Grunntype = columns[3],
                Grunntypenavn = columns[4],
                Kode = columns[5]
            };
        }

        public static List<CsvdataImporter_Grunntype> ProcessCSV(string path)
        {
            return File.ReadAllLines(path)
                .Skip(1)
                .Where(row => row.Length > 0)
                .Select(CsvdataImporter_Grunntype.ParseRow).ToList();
        }
    }
}
