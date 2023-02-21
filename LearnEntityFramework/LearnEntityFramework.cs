using LearnEntityFramework.DBContext;
using LearnEntityFramework.Models;

internal class LaunchApp
{
    private static readonly ILog log = LogManager.GetLogger(typeof(LaunchApp));

    private static void Main(string[] args)
    {
        LaunchApp launchApp = new LaunchApp();
        using var userContext = new UserDBContext();
        List<User> users = userContext
            .Users
            .OrderBy(user => user.UserGkey)
            .ToList();

        log.Info("Fetching first user from Collection");
        log.Info(users.First());
        Console.WriteLine("Program will be shutdown");
    }
}