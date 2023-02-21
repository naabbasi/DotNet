using DBLocalizationSupport.DBContext;
using DBLocalizationSupport.Models;

namespace DBLocalizationSupport.Services
{
    public class LocalizationService : ILocalizationService
    {
        private readonly QRoasterDBContext _qroasterDBContext;

        public LocalizationService(QRoasterDBContext qroasterDBContext)
        {
            _qroasterDBContext = qroasterDBContext;
        }

        public CultureMessage GetStringResource(string resourceKey, long languageId)
        {
            return _qroasterDBContext.CultureMessages.FirstOrDefault(x =>
                    x.Key.Trim().ToLower() == resourceKey.Trim().ToLower()
                    && x.LanguageGkey == languageId);
        }
    }
}
