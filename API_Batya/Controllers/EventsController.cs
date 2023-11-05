using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Batya.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        static List<Event> events = new List<Event>()        {
            new Event("Rosh Hashana",  /*new DateTime(2023, 09, 16)*/new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day) , new DateTime(2023, 09, 16)),
            new Event("יום כיפור",new DateTime(2023, 09, 25), new DateTime(2023, 09, 26)),
            new Event("יוט ראשון של סוכות", new DateTime(2023, 09, 29), new DateTime(2023, 09, 30))
        };
        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Event> Get() => events;

        // GET api/<EventsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id) => "value";

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Event value) => events.Add(new Event(value.Title, value.Start, value.End));

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event value)
        {
            var e = events.Find(e => e.Id == id);
            if (e != null)
            {
                e.Title = value.Title;
                e.Start = value.Start;
                e.End = value.End;
            }
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) => events.Remove(events.Find(e => e.Id == id));
    }
}
