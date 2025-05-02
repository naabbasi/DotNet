namespace LearnEntityFramework.DBContext;

using LearnEntityFramework.Models;
using log4net;
using Microsoft.EntityFrameworkCore;

public class UserDBContext : DbContext
{
    private const string connectionString = @"server=localhost;port=3306;database=qtime;user=qbill_dev;password=Qt@DeV";
    private static readonly ILog log = LogManager.GetLogger(typeof(UserDBContext));

    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        ServerVersion serverVersion = ServerVersion.AutoDetect(connectionString);
        //ServerVersion serverVersion = new MySqlServerVersion(new Version(8, 0, 26));
        optionsBuilder.UseMySql(connectionString, serverVersion);
        log.Info("DB configuration has been completed.");
    }
}
