using Microsoft.EntityFrameworkCore;

namespace EFAndLinqPractice_SchoolAPI.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        //Specify n : n Relationship and set decimal value of Height precision
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students);


            modelBuilder.Entity<Student>().Property( e => e.Height ).HasPrecision(38, 18);
        }
    }
}