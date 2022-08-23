using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#pragma warning disable

namespace DAL.Models
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Link { get; set; }
        [Required]
        public int OriginalSize { get; set; }
        [Required]
        public DateTime DateOfCreation { get; set; }
        [Required]
        [ForeignKey( "Author" )]
        public int AuthorId { get; set; }
        [Required]
        public int Cost { get; set; }
        [Required]
        public int NumberOfSales { get; set; }

        public Author Author { get; set; }
    }
}
