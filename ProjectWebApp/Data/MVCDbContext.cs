using Microsoft.EntityFrameworkCore;
using ProjectWebApp.Models.Domain;

namespace ProjectWebApp.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> students { get; set; }
    }
}
