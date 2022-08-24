using DAL.Models;
using DTOs.Models;

namespace DTOs.Services
{
    public interface ITextServices
    {
        public Task CreateText( CreateTextDTO text );
        public Task<List<GetTextsDTO>> GetTextDTO();
        public Task<List<TextDTO>> GetTexts();
    }
}
