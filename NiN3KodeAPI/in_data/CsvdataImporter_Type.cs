namespace NiN3KodeAPI.in_data
{
    public class CsvdataImporter_Type
    {
        public string Ecosystnivaa { get; set; }
        public string Typekategori { get; set; }
        public string Typekategori2 { get; set; }
        public string Kode { get; set; }

        internal static CsvdataImporter_Type ParseRow(string row)
        {
            var columns = row.Split(';');
            return new CsvdataImporter_Type()
            {
                Ecosystnivaa = columns[0],
                Typekategori = columns[1],
                Typekategori2 = columns[2],
                Kode = columns[3]
            };
        }

        public static List<CsvdataImporter_Type> ProcessCSV(string path)
        {
            return File.ReadAllLines(path)
                .Skip(1)
                .Where(row => row.Length > 0)
                .Select(CsvdataImporter_Type.ParseRow).ToList();
        }
    }
}
