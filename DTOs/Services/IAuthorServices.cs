using DTOs.Models;

namespace DTOs.Services
{
    public interface IAuthorServices
    {
        public Task<List<GetAuthorsDTO>> GetAuthors();
    }
}
