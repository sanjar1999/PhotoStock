using DAL.Models;

namespace DTOs.Models
{
    public class GetTextsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TextOfText { get; set; }
        public DateTime DateOfCreation { get; set; }
        public int Cost { get; set; }
        public int AuthorId { get; set; }
        public int NumberOfSales { get; set; }
        public Author Author { get; set; }
    }
}
