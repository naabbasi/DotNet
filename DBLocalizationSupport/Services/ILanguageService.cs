using DBLocalizationSupport.Models;

namespace DBLocalizationSupport.Services
{
    public interface ILanguageService
    {
        IEnumerable<Language> GetLanguages();
        Language GetLanguageByCulture(string culture);
    }
}
