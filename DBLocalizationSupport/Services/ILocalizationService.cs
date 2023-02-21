using DBLocalizationSupport.Models;

namespace DBLocalizationSupport.Services
{
    public interface ILocalizationService
    {
        CultureMessage GetStringResource(string resourceKey, long languageId);
    }
}
