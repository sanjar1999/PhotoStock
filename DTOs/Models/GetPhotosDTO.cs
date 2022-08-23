using DAL.Models;

namespace DTOs.Models
{
    public class GetPhotosDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public int OriginalSize { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int AuthorId { get; set; }
        public int Cost { get; set; }
        public int NumberOfSales { get; set; }
        public Author Author { get; set; }
    }
}
