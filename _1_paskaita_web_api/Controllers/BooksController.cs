using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_paskaita_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private static readonly List<string> _books = [];

        [HttpPost("addBook")]
        public ActionResult AddBook([FromBody] string title)
        {
            _books.Add(title);
            return Ok();
        }
        [HttpGet]
        public ActionResult GetBooks()
        {
            return Ok(_books);
        }
        [HttpGet("{Book.title}")]
        public ActionResult<string> GetByTitle([FromRoute]string title)
        {
            var book = _books.SingleOrDefault(x => x == title);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
    }
}
