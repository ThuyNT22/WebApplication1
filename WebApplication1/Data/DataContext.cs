using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace WebApplication1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base (options) 
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DataContext>().ToTable("Department");
            modelBuilder.Entity<DataContext>().ToTable("Employee");
        }
        DbSet<DataContext> DataContexts;
    }
}
