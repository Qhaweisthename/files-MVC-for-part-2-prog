using Microsoft.EntityFrameworkCore;

using FilesMvcs.Models;

namespace FilesMvcs.Data
{
    public class ApplicationDbContext : DbContext
    {
        //ctor 
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        //create your data set here 
        public DbSet<Files> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
