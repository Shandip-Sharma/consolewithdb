using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Sand_webApi.Models;

namespace Sand_webApi
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Contact> contacts { get; set; }
    }
   
}
