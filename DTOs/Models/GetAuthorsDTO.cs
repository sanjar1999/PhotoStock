namespace DTOs.Models
{
    public class GetAuthorsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfRegistration { get; set; }
    }
}
