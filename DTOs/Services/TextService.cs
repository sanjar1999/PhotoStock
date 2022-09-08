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
                if ( text == null )
                {
                    throw new ArgumentNullException( nameof( text ) );
                }

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

        public async Task<List<GetTextsDTO>> GetTextDTO()
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

        public async Task<List<TextDTO>> GetTexts()
        {
            try
            {
                var list = await _db.Texts.Select( x => new TextDTO
                {
                    Name = x.Name,
                    Text = x.TextOfText,
                    DateOfCreation = x.DateOfCreation,
                    Cost = x.Cost,
                    NameOfAuthor = x.Author.Name,
                    NicknameOfAuthor = x.Author.NickName,
                    NumberOfSales = x.NumberOfSales
                } ).ToListAsync();

                return list;
            }
            catch ( Exception e )
            {
                throw new ArgumentException( nameof( e ) );
            }
        }
    }
}
