using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CateringLarissa2.Models;

namespace CateringLarissa2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CateringLarissa2.Models.Review> Review { get; set; }
        public DbSet<CateringLarissa2.Models.Menu> Menu { get; set; }
    }
}