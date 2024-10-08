using Microsoft.EntityFrameworkCore;

namespace MassPersona.RazorPageApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options) {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        public DbSet<Review> Reviews => Set<Review>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasData(
                new Review
                {
                    ReviewID = 1,
                    Title = "Dune 2",
                    Category = "Movie",
                    ReviewText = "I enjoyed it more than the first one.",
                    Rating = 4,
                    DateReviewed = DateTime.UtcNow,
                },
                 new Review
                 {
                     ReviewID = 2,
                     Title = "Warcraft Classic",
                     Category = "Game",
                     ReviewText = "Brough back nostalgia as I played it when it first came out.",
                     Rating = 4,
                     DateReviewed = DateTime.UtcNow,
                 },
                 new Review
                 {
                     ReviewID = 3,
                     Title = ".NET Microservices: Architecture for containerized .NET Applications",
                     Category = "Book",
                     ReviewText = "A little difficult to understand, but peaked my interest to create Microservice solutions. For example https://github.com/ponssong/EShopMicSer",
                     Rating = 2,
                     DateReviewed = DateTime.UtcNow,
                 },
                 new Review
                 {
                     ReviewID = 4,
                     Title = "Rings of Power",
                     Category = "Show",
                     ReviewText = "I enjoyed the first season so i will continue to watch.",
                     Rating = 3,
                     DateReviewed = DateTime.UtcNow,
                 },
                 new Review
                 {
                     ReviewID = 5,
                     Title = "Solo Leveling",
                     Category = "Show",
                     ReviewText = "I read the manhua. So I wanted to see the anime.",
                     Rating = 5,
                     DateReviewed = DateTime.UtcNow,
                 }
            );
        }
    }
}
