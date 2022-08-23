using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#pragma warning disable

namespace DAL.Models
{
    public class Text
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string TextOfText { get; set; }
        [Required]
        public DateTime DateOfCreation { get; set; }
        [Required]
        public int Cost { get; set; }
        [Required]
        [ForeignKey( "Author" )]
        public int AuthorId { get; set; }
        [Required]
        public int NumberOfSales { get; set; }
        public Author Author { get; set; }
    }
}
