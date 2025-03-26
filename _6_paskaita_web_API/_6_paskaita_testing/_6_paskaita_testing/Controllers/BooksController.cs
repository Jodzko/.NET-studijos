using _6_paskaita_testing.Models;
using _6_paskaita_testing.Services;
using Microsoft.AspNetCore.Mvc;

namespace _6_paskaita_testing.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            return Ok(_bookService.GetAllBooks());
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetById(int id)
        {
            var book = _bookService.GetBook(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public ActionResult<Book> Create([FromBody] Book book)
        {
            var created = _bookService.CreateBook(book);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public ActionResult<Book> Update(int id, [FromBody] Book book)
        {
            if (id != book.Id) return BadRequest("ID mismatch.");
            var updated = _bookService.UpdateBook(book);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var success = _bookService.DeleteBook(id);
            if (!success) return NotFound();
            return NoContent();
        }
    }
}
