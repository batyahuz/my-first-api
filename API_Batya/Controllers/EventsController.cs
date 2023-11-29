using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Batya.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IDataContext _context;

        public EventsController(IDataContext dataContext)
        {
            _context = dataContext;
        }

        // GET: api/<EventsController>
        [HttpGet]
        public IActionResult Get() => Ok(_context.Events);

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var e = _context.Events.Find(e => e.Id == id);
            if (e == null)
                return NotFound();
            return Ok(e);
        }

        // POST api/<EventsController>
        [HttpPost]
        public IActionResult Post([FromBody] Event value)
        {
            _context.Events.Add(new Event(value.Title, value.Start, value.End));
            return NoContent();
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Event value)
        {
            var e = _context.Events.Find(e => e.Id == id);
            if (e == null)
                return NotFound();
            _context.Events.Remove(e);
            _context.Events.Add(value);
            return Created("succedded with apdate the value", value);
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var e = _context.Events.Find(e => e.Id == id);
            if (e == null)
                return NotFound();
            _context.Events.Remove(e);
            return NoContent();
        }
    }
}
