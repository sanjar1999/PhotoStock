#pragma warning disable

namespace DTOs.Models
{
    public class TextDTO
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int Cost { get; set; }
        public string NameOfAuthor { get; set; }
        public string NicknameOfAuthor { get; set; }
        public int NumberOfSales { get; set; }
    }
}
