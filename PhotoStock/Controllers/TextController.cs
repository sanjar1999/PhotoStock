using DAL.Models;
using DTOs.Models;
using DTOs.Services;
using Microsoft.AspNetCore.Mvc;
#pragma warning disable


namespace PhotoStock.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class TextController : ControllerBase
    {
        private readonly ITextServices _createText;
        public TextController( ITextServices createText )
        {
            _createText = createText;
        }
        [HttpPost]
        public async Task<IActionResult> CreateText( CreateTextDTO text )
        {
            await _createText.CreateText( text );
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok( await _createText.GetTexts() );
        }
    }
}
