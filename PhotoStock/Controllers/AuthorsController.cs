using DTOs.Services;
using Microsoft.AspNetCore.Mvc;

namespace PhotoStock.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorServices _authorServices;

        public AuthorsController( IAuthorServices authorServices )
        {
            _authorServices = authorServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAuthors()
        {
            return Ok( await _authorServices.GetAuthors() );
        }
    }
}
