using Microsoft.EntityFrameworkCore;
using QRoaster.Infrastructure.Entities;

namespace QRoaster.Infrastructure.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserGkey)
                    .HasName("PRIMARY");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
