using _6_paskaita_testing.Models;
using _6_paskaita_testing.Services;
using Microsoft.AspNetCore.Mvc;

namespace _6_paskaita_testing.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Author>> Get()
        {
            return Ok(_authorService.GetAllAuthors());
        }

        [HttpGet("{id}")]
        public ActionResult<Author> GetById(int id)
        {
            var author = _authorService.GetAuthor(id);
            if (author == null) return NotFound();
            return Ok(author);
        }

        [HttpPost]
        public ActionResult<Author> Create([FromBody] Author author)
        {
            var created = _authorService.CreateAuthor(author);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public ActionResult<Author> Update(int id, [FromBody] Author author)
        {
            if (id != author.Id) return BadRequest("ID mismatch.");
            var updated = _authorService.UpdateAuthor(author);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var success = _authorService.DeleteAuthor(id);
            if (!success) return NotFound();
            return NoContent();
        }
    }
}
