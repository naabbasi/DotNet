using DBLocalizationSupport.DBContext;
using DBLocalizationSupport.Models;

namespace DBLocalizationSupport.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly QRoasterDBContext _qRoasterDBContext;

        public LanguageService(QRoasterDBContext qRoasterDBContext)
        {
            _qRoasterDBContext = qRoasterDBContext;
        }

        public IEnumerable<Language> GetLanguages()
        {
            return _qRoasterDBContext.Languages.ToList();
        }

        public Language GetLanguageByCulture(string culture)
        {
            return _qRoasterDBContext.Languages.FirstOrDefault(x =>
                x.Culture.Trim().ToLower() == culture.Trim().ToLower());
        }
    }
}
