using DAL;
using DTOs.Models;
using Microsoft.EntityFrameworkCore;

#pragma warning disable

namespace DTOs.Services
{
    public class PhotoServices : IPhotoServices
    {
        private readonly ApplicationContext _db;

        public PhotoServices( ApplicationContext applicationContext )
        {
            _db = applicationContext;
        }
        
        public async Task<PhotoDTO> GetPhotoById( int id )
        {
            try
            {
                var dbData = await _db.Photos
                    .Include(x => x.Author)
                    .FirstOrDefaultAsync( x => x.Id == id );

                if ( dbData == null )
                {
                    throw new ArgumentNullException( nameof( dbData ) );
                }

                var res = new PhotoDTO
                {
                    Id = dbData.Id,
                    Name = dbData.Name,
                    Link = dbData.Link,
                    OriginalSize = dbData.OriginalSize,
                    DateOfCreation = dbData.DateOfCreation,
                    AuthorId = dbData.AuthorId,
                    NameOfAuthor = dbData.Author.Name,
                    NicknameOfAuthor = dbData.Author.NickName,
                    Cost = dbData.Cost,
                    NumberOfSales = dbData.NumberOfSales
                };

                if ( res == null )
                {
                    throw new ArgumentException( "Photo not found" );
                }

                return res;
            }
            catch ( Exception e )
            {
                throw new ArgumentException( nameof( e ) );
            }
        }

        public async Task<List<GetPhotosDTO>> GetPhotos()
        {
            try
            {
                var listOfPhotos = await _db.Photos.Select( x => new GetPhotosDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    Link = x.Link,
                    OriginalSize = x.OriginalSize,
                    DateOfCreation = DateTime.Now,
                    Author = x.Author,
                    AuthorId = x.AuthorId,
                    Cost = x.Cost,
                    NumberOfSales = x.NumberOfSales
                } ).ToListAsync();

                return listOfPhotos;
            }
            catch ( Exception e)
            {
                throw new ArgumentException(nameof(e));
            }
        }

        public async Task<List<PhotoDTO>> GetPhotosDTO()
        {
            try
            {
                var listOfPhotos =  await _db.Photos.Select( x => new PhotoDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    Link = x.Link,
                    OriginalSize = x.OriginalSize,
                    DateOfCreation = x.DateOfCreation,
                    AuthorId = x.AuthorId,
                    NameOfAuthor = x.Author.Name,
                    NicknameOfAuthor = x.Author.NickName,
                    Cost = x.Cost,
                    NumberOfSales = x.NumberOfSales
                } ).ToListAsync();

                return listOfPhotos;
            }
            catch ( Exception e )
            {
                throw new ArgumentException( nameof( e ) );
            }
        }

        public async Task UpdatePhoto( int id, PhotoDTO photoDto )
        {
            try
            {
                var photoUpdate = await _db.Photos.FirstOrDefaultAsync( x => x.Id == id );

                if ( photoUpdate == null )
                {
                    throw new ArgumentException($"Photo with '{photoDto.Id}' id was not Found");
                }

                photoUpdate.Name = photoDto.Name;
                photoUpdate.DateOfCreation = DateTime.Now;
                photoUpdate.Cost = photoDto.Cost;
                photoUpdate.NumberOfSales = photoDto.NumberOfSales;
                photoUpdate.AuthorId = photoDto.AuthorId;
                photoUpdate.Link = photoDto.Link;
                photoUpdate.OriginalSize = photoDto.OriginalSize;

                await _db.SaveChangesAsync();
            }
            catch ( Exception e )
            {
                throw new ArgumentException( nameof(e) );
            }
        }
    }
}
