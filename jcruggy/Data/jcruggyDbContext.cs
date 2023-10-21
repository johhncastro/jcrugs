using jcruggy.Models;
using Microsoft.EntityFrameworkCore;

namespace jcruggy.Data
{
    public class jcruggyDbContext : DbContext
    {
        public jcruggyDbContext(DbContextOptions<jcruggyDbContext>options) : base(options)
        {    
        }
        public DbSet<Product> Products { get; set; }
    }
}
