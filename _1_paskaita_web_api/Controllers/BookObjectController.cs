using _1_paskaita_web_api.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_paskaita_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookObjectController : ControllerBase
    {
        private static readonly List<Book> _books = [];

        [HttpPost("addBook")]
        public ActionResult AddBook([FromBody] Book book)
        {
            _books.Add(book); 
            return Ok();
        }
        [HttpGet("getAllBooks")]
        public ActionResult GetBooks()
        {
            return Ok(_books);
        }
        [HttpGet("title/{title}")]
        public ActionResult<Book> GetByTitle([FromRoute] string title)
        {
            var book = _books.SingleOrDefault(x => x.Title == title);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
        [HttpPut("UpdateBookTitle/{title}/{newTitle}")]
        public ActionResult updateBook([FromRoute] string title, string newTitle)
        {
            var book = _books.SingleOrDefault(x => x.Title == title);
            if(book == null)
            {
                return NotFound();
            }
            book.Title = newTitle;
            return Ok();
        }
        [HttpDelete("{title}")]
        public ActionResult DeleteBookByTitle([FromRoute] string title)
        {
            var book = _books.SingleOrDefault(x => x.Title == title);
            if(book == null)
            {
                return NotFound();
            }
            _books.Remove(book);
            return Ok();
        }
    }
}
