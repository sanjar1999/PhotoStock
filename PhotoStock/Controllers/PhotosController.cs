using DTOs.Models;
using DTOs.Services;
using Microsoft.AspNetCore.Mvc;

namespace PhotoStock.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        private readonly IPhotoServices _photoServices;
        public PhotosController( IPhotoServices photoServices )
        {
            _photoServices = photoServices;
        }

        [HttpGet]
        [Route( "dto" )]
        public async Task<IActionResult> GetListOfPhotos()
        {
            return Ok( await _photoServices.GetPhotosDTO() );
        }

        [HttpGet]
        [Route( "{id}" )]
        public async Task<IActionResult> GetById( int id )
        {
            return Ok( await _photoServices.GetPhotoById( id ) );
        }

        [HttpGet]
        public async Task<IActionResult> GetPhoto()
        {
            return Ok( await _photoServices.GetPhotos() );
        }

        [HttpPut]
        [Route( "{id}" )]
        public async Task<IActionResult> UpdatePhoto( int id, PhotoDTO photoDto )
        {
            await _photoServices.UpdatePhoto( id, photoDto );
            return Ok();
        }
    }
}
