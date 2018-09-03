using Microsoft.EntityFrameworkCore;

namespace API.Domain
{
    public class APIDbContext : DbContext
    {
        public APIDbContext()
        {  
        }
		
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
