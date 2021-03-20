using EfDataAccessLibrary.Model;
using Microsoft.EntityFrameworkCore;

namespace EfDataAccessLibrary.DataAccess
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}