using EntityFrameWorkDemo.Models;
using EntityFrameWorkDemo.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using EntityFrameWorkDemo.Services;
using log4net;

var log = LogManager.GetLogger(name: "Program");

IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((context, config) => config
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true))
    .ConfigureServices((hostContext, services) =>
    {
        var connectionString = hostContext.Configuration.GetConnectionString("QRoasterDBConnection");

        services
        .AddDbContext<QRoasterDbContext>(options =>
        {
            log.Info($"Connection String {connectionString}");

            options
            .LogTo(Console.WriteLine, LogLevel.Debug)
            .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        })
        .AddScoped<IUserService, UserService>();
    }); 
      

using IHost host = hostBuilder.Build();

using (var scope = host.Services.CreateScope())
{
    var userService = scope.ServiceProvider.GetRequiredService<IUserService>();
    var listofUsers = userService.Users();

    foreach (User user in listofUsers)
    {
        Console.WriteLine($"Display user information using ToString: {user}");
        Console.WriteLine($"Display user information from Partial class: {user.UserWithId}");
    }
}

host.Run();