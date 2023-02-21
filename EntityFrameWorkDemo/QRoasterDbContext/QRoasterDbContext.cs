using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EntityFrameWorkDemo.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace EntityFrameWorkDemo.Contexts
{
    public partial class QRoasterDbContext : DbContext
    {
        private IConfiguration _configuration;

        public QRoasterDbContext()
        {
        }

        /**
         * Configure DBContext by injecting IConfiguration and read ConnectionString in OnConfiguring method
         **/
        /*public QRoasterDbContext(IConfiguration configuration)            
        {
            this._configuration = configuration;
        }*/

        /**
         * This construct is required when setting up the DB Context via Generic Host
         */
        public QRoasterDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<CultureMessage> CultureMessages { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                Console.WriteLine(this._configuration.GetConnectionString("QRoasterDBConnection"));

                optionsBuilder
                    LogTo(Console.WriteLine, LogLevel.Information)
                    //.EnableSensitiveDataLogging()
                    .UseMySql(this._configuration.GetConnectionString("QRoasterDBConnection"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.26-mysql"));
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<CultureMessage>(entity =>
            {
                entity.HasKey(e => e.CultureMessageGkey)
                    .HasName("PRIMARY");

                entity.Property(e => e.CultureMessageGkey).ValueGeneratedOnAdd();

                entity.HasOne(d => d.CultureMessageGkeyNavigation)
                    .WithOne(p => p.CultureMessage)
                    .HasForeignKey<CultureMessage>(d => d.CultureMessageGkey)
                    .HasConstraintName("culture_messages_FK");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasKey(e => e.LangGkey)
                    .HasName("PRIMARY");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserGkey)
                    .HasName("PRIMARY");

                entity.HasOne(d => d.LanguageGkeyNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.LanguageGkey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("users_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
