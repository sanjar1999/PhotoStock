using DAL.Models;
using Microsoft.EntityFrameworkCore;
#pragma warning disable

namespace DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext( DbContextOptions<ApplicationContext> options )
            : base( options )
        {
        }
        public ApplicationContext() { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Text> Texts { get; set; }
    }
}
