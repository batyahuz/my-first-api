using API_Batya;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    internal class DataContextFake : IDataContext
    {
        public List<Event> Events { get; set; }

        public DataContextFake()
        {
            Events = new List<Event>()
            {
                new Event("first title", new DateTime(2023,10,11), new DateTime(2023,10,13)),
                new Event("finish homework title", new DateTime(2023,10,15), new DateTime(2023,10,17)),
                new Event("second title", new DateTime(2023,10,18), new DateTime(2023,10,19)),
                new Event("go to school", new DateTime(2023,9,11), new DateTime(2023,9,20)),
                new Event("succsseed in .net", new DateTime(2023,12,5), new DateTime(2023,12,13)),
            };
        }
    }
}
