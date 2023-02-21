
using Microsoft.Extensions.Configuration;

namespace LearnEntityFramework.AppConfiguration
{
    public class AppConfig
    {
        private static IConfiguration configuration;

        public IConfiguration GetConfiguration()
        {
            if(configuration == null)
            {
                configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile($"appsettings.json", optional: true, reloadOnChange: true)
                 .Build();
            }
            
            return configuration;
        }

        public string GetAppConfig(string key)
        {
            IConfigurationSection appSettingSection = GetConfiguration().GetSection("AppSettings:" + key);
            return appSettingSection.Value;
        }
    }
}
