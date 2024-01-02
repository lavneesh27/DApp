using DApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}
