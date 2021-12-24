using Microsoft.EntityFrameworkCore;

namespace Internship.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Intenship.Domain.Models.Task> Tasks { get; set; }
        public DbSet<Intenship.Domain.Models.Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
