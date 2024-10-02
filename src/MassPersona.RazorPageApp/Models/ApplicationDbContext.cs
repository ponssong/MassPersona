using Microsoft.EntityFrameworkCore;

namespace MassPersona.RazorPageApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options) { }
        public DbSet<Review> Reviews => Set<Review>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                    ReviewID = 1,
                    Title = "Test Title",
                    Category = "Test Category",
                    ReviewText = "Test Review",
                    Rating = 1,
                    DateReviewed = DateTime.Now,
                }
            );
        }
    }
}
