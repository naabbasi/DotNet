using Microsoft.Extensions.Localization;
using WebMinimalApi.Localization;

namespace WebMinimalApi.Services;

public interface IService
{
    public string GetLocalizedMessage(string messageKey);
}
