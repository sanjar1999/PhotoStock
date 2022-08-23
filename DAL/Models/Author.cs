using System.ComponentModel.DataAnnotations;
#pragma warning disable


namespace DAL.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string NickName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public DateTime DateOfRegistration { get; set; }
    }
}
