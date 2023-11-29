using CsvHelper;
using System.Globalization;

namespace API_Batya
{
    public class DataContext : IDataContext
    {
        public List<Event> Events { get; set; }

        public DataContext()
        {
            using (var reader = new StreamReader("data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Events = csv.GetRecords<Event>().ToList();
            }
        }
    }
}
