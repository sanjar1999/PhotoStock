using DTOs.Models;

namespace DTOs.Services
{
    public interface IPhotoServices
    {
        public Task<List<PhotoDTO>> GetPhotosDTO();
        public Task UpdatePhoto( int id, PhotoDTO photoDto );
        public Task<PhotoDTO> GetPhotoById( int id );
        public Task<List<GetPhotosDTO>> GetPhotos();
    }
}
