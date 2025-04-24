using _web_api_project.BusinessLogic.Contracts;
using _web_api_project.BusinessLogic.Services.Interfaces;
using _web_api_project.Database.Persistence;
using _web_api_project.Database.Persistence.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace _web_api_project.Api.Controllers
{
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        private readonly INoteRepository _notesRepository;
        private readonly INotesService _notesService;

        public NotesController(IAccountRepository accountRepository, INoteRepository notesRepository, INotesService notesService)
        {
            _accountRepository = accountRepository;
            _notesRepository = notesRepository;
            _notesService = notesService;
        }
        [Authorize]
        [HttpPost("CreateNote")]
        public IActionResult CreateNote([FromForm] CreateNoteRequest request)
        {
            var usernameClaim = User.FindFirst(ClaimTypes.Name);
            if(usernameClaim == null)
            {
                return BadRequest("Username not found in token");
            }
            _notesService.CreateNote(usernameClaim.Value, request.body, request.category, request.Image);
            return Ok();
        }
    }
}
