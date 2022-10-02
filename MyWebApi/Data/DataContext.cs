using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;

namespace MyWebApi.Data
{
    public class DataContext: DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Table_File> files { get; set; }

        public DbSet<User> users { get; set; }

        public DbSet<Server> servers { get; set; }

        public DbSet<Location> locations { get; set; }

        public DbSet<Comment> comments { get; set; }

        public DbSet<MyWebApi.Models.UserType> UserType { get; set; }
    }
}
