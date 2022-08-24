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
        private readonly ITextServices _textService;
        public TextController( ITextServices textService )
        {
            _textService = textService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateText( CreateTextDTO text )
        {
            await _textService.CreateText( text );
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok( await _textService.GetTextDTO() );
        }

        [HttpGet]
        [Route("dto")]
        public async Task<IActionResult> GetText()
        {
            return Ok( await _textService.GetTexts() );
        }
    }
}
