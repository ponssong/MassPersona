using Microsoft.EntityFrameworkCore;

namespace MassPersona.RazorPageApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options) { }
        public DbSet<Review> Reviews => Set<Review>();
    }
}
