using basic_element_database.Elements;
using Microsoft.EntityFrameworkCore;

namespace basic_element_database
{
    public class BasicElementDbContext : DbContext
    {
        public DbSet<Element> Elements { get; set; }
        public BasicElementDbContext(DbContextOptions<BasicElementDbContext> options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Element>().ToTable("Elements")
                .HasKey(x => x.ID);
        }
    }
}
