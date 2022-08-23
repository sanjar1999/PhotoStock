#pragma warning disable

namespace DTOs.Models
{
    public class PhotoDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public int OriginalSize { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string NameOfAuthor { get; set; }
        public string NicknameOfAuthor { get; set; }
        public int Cost { get; set; }
        public int NumberOfSales { get; set; }
        public int AuthorId { get; set; }
    }
}
