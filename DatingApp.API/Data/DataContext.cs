using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    // DataContext is derived class of Dbcontext
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        // Conventional to pluralize the name of the entities because this is the table 
        // name once the database is created.
        public DbSet<Value> Values { get; set; }
    }
}