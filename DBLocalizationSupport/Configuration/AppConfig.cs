
using Microsoft.Extensions.Configuration;

namespace DBLocalizationSupport.AppConfiguration
{
    public class AppConfig
    {
        private static IConfiguration configuration;

        public AppConfig()
        {
            GetConfiguration();
        }

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

        public string GetConnectionString(string key)
        {
            return GetConfiguration().GetConnectionString(key);
        }
    }
}
