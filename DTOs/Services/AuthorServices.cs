using DAL;
using DTOs.Models;
using Microsoft.EntityFrameworkCore;

namespace DTOs.Services
{
    public class AuthorServices : IAuthorServices
    {
        private readonly ApplicationContext _db;
        public AuthorServices( ApplicationContext applicationContext )
        {
            _db = applicationContext;
        }

        public async Task<List<GetAuthorsDTO>> GetAuthors()
        {
            try
            {
                var listOfAuthors = await _db.Authors.Select( x => new GetAuthorsDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    LastName = x.LastName,
                    NickName = x.NickName,
                    DateOfBirth = x.DateOfBirth,
                    DateOfRegistration = x.DateOfRegistration,
                } ).ToListAsync();

                return listOfAuthors;
            }
            catch ( Exception e )
            {
                throw new ArgumentException( nameof( e ) );
            }
        }
    }
}
