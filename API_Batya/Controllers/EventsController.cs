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
        public IActionResult Get() => Ok(events);

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var e = events.Find(e => e.Id == id);
            if (e == null)
                return NotFound();
            return Ok(e);
        }

        // POST api/<EventsController>
        [HttpPost]
        public IActionResult Post([FromBody] Event value)
        {
            events.Add(new Event(value.Title, value.Start, value.End));
            return NoContent();
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Event value)
        {
            var e = events.Find(e => e.Id == id);
            if (e == null)
                return NotFound();
            events.Remove(e);
            events.Add(value);
            return Created("succedded with apdate the value", value);
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var e = events.Find(e => e.Id == id);
            if (e == null)
                return NotFound();
            events.Remove(e);
            return NoContent();
        }
    }
}
