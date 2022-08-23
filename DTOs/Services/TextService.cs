using DAL;
using DAL.Models;
using DTOs.Models;
using Microsoft.EntityFrameworkCore;
#pragma warning disable

namespace DTOs.Services
{
    public class TextService : ITextServices
    {
        private readonly ApplicationContext _db;

        public TextService( ApplicationContext applicationContext )
        {
            _db = applicationContext;
        }

        public async Task CreateText( CreateTextDTO text )
        {
            try
            {
                var newText = new Text()
                {
                    Name = text.Name,
                    TextOfText = text.TextOfText,
                    DateOfCreation = text.DateOfCreation,
                    Cost = text.Cost,
                    AuthorId = text.AuthorId,
                    NumberOfSales = text.NumberOfSales
                };

                await _db.Texts.AddAsync( newText );
                await _db.SaveChangesAsync();
            }
            catch ( Exception e )
            {
                throw new ArgumentException( nameof( e ) );
            }
        }

        public async Task<List<GetTextsDTO>> GetTexts()
        {
            try
            {
                var listOfText = await _db.Texts.Select( x => new GetTextsDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    TextOfText = x.TextOfText,
                    Cost = x.Cost,
                    DateOfCreation = DateTime.Now,
                    NumberOfSales = x.NumberOfSales,
                    AuthorId = x.AuthorId,
                    Author = x.Author
                } ).ToListAsync();

                return listOfText;
            }
            catch ( Exception e )
            {

                throw new ArgumentException( nameof( e ) );
            };
        }
    }
}
