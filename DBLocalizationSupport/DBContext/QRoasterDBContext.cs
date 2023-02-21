using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DBLocalizationSupport.Models;
using DBLocalizationSupport.AppConfiguration;

namespace DBLocalizationSupport.DBContext
{
    public partial class QRoasterDBContext : DbContext
    {
        private readonly AppConfig appConfig;

        public QRoasterDBContext(AppConfig appConfig)
        {
            this.appConfig = appConfig;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ServerVersion serverVersion = ServerVersion.AutoDetect(this.appConfig.GetConnectionString("QRoasterDBConnection"));
            //ServerVersion serverVersion = new MySqlServerVersion(new Version(8, 0, 26));
            optionsBuilder.UseMySql(this.appConfig.GetConnectionString("QRoasterDBConnection"), serverVersion);
        }

        public virtual DbSet<CultureMessage> CultureMessages { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

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
