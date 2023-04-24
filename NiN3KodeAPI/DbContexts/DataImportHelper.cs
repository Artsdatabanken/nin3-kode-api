namespace NiN3KodeAPI.DbContexts
{
    public class DataImportHelper
    {
        private readonly NiN3DbContext _context;
        public DataImportHelper(NiN3DbContext context) {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void GetDomene() { 
            var ds = _context.domene.FirstOrDefault();
            Console.WriteLine(ds);
        }
        
        public void PopulateHovedtypegruppe() {
            string[] allLines = File.ReadAllLines(@"in_data\hovedtypegruppe.csv");
            foreach (var line in allLines)
            {
                Console.WriteLine(line[0]);
            }
            //var query = from line in allLine
             //           let data = line.Split(';')
                        /*
                        select new
                        {
                            Device = data[0],
                            SignalStrength = data[1],
                            Location = data[2],
                            Time = data[3],
                            Age = Convert.ToInt16(data[4])
                        };*/
            // get csv file
            // loop csv lines 
            // fetch Typekategori2 by code
            // fetch Hovedtypegruppe navn
            // store kode in Kode
            // Navn = Hovedtypegruppenavn
        }
    }
}
