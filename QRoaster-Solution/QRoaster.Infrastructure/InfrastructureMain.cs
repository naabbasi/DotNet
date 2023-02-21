using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using QRoaster.Infrastructure.DBContext;
using QRoaster.Infrastructure.Entities;
using System.Security.Principal;

const string connectionString = @"server=172.27.84.156;port=3306;database=qtime;user=qbill_dev;password=Qt@DeV";

IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args);

hostBuilder.ConfigureServices((hostContext, services) =>
{
    services.AddDbContext<ApplicationDbContext>((serviceCollection, optionsAction) =>
    {
        ServerVersion serverVersion = ServerVersion.AutoDetect(connectionString);
        optionsAction
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging(true)
        .UseMySql(connectionString, serverVersion);
    });

    services.AddScoped<IRepository<User>, Repository<User>>();    
});

using var app = hostBuilder.Build();
using (var scope = app.Services.CreateScope())
{
    var userRepository = scope.ServiceProvider.GetRequiredService<IRepository<User>>();    
}

app.RunAsync();