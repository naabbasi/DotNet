using DBLocalizationSupport.AppConfiguration;
using DBLocalizationSupport.DBContext;
using DBLocalizationSupport.Models;
using DBLocalizationSupport.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Net.Mime;
using System.Text.RegularExpressions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<QRoasterDBContext>();
builder.Services.AddSingleton<AppConfig>();
builder.Services.AddScoped<ILanguageService, LanguageService>();
builder.Services.AddScoped<ILocalizationService, LocalizationService>();
builder.Services.AddLocalization();

var serviceProvider = builder.Services.BuildServiceProvider();
var languageService = serviceProvider.GetRequiredService<ILanguageService>();
var languages = languageService.GetLanguages();
var cultures = languages.Select(x => new CultureInfo(x.Culture)).ToArray();

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var englishCulture = cultures.FirstOrDefault(x => x.Name == "en-US");
    options.DefaultRequestCulture = new RequestCulture(englishCulture?.Name ?? "en-US");

    options.SupportedCultures = cultures;
    options.SupportedUICultures = cultures;
});

builder.Services.Configure<QueryStringRequestCultureProvider>(options =>
{    
});

builder.Services.Configure<AcceptLanguageHeaderRequestCultureProvider>(options => { });

var app = builder.Build();
app.UseRequestLocalization();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

//https://phrase.com/blog/posts/all-you-need-to-know-about-cultureinfo-in-net-applications/
app.MapGet("/weatherforecast", (HttpRequest httpRequest, HttpResponse httpResponse, [FromServices]ILanguageService languageService, [FromServices] ILocalizationService localizationService, [FromServices] QRoasterDBContext qroasterDbContext) =>
{
    var currentCulture = Thread.CurrentThread.CurrentUICulture.Name;
    var language = languageService.GetLanguageByCulture(currentCulture);

    var cookie = httpRequest.Cookies.FirstOrDefault(cookie => cookie.Key.Equals(CookieRequestCultureProvider.DefaultCookieName));
    if(cookie.Key != null)
    {
        string locale = (cookie.Value.Split("|")[0]).Split("=")[1];
        string parsedCookie = CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture: locale, uiCulture: locale));
        Console.WriteLine($"Cookie: {cookie}, Parsed Cookie: {parsedCookie}");
    }

    CultureMessage cultureMessage = localizationService.GetStringResource("username.message", language.LangGkey);
    Console.WriteLine(cultureMessage);

    List<User> users = qroasterDbContext
    .Users
    .OrderBy(user => user.LanguageGkey)
    .ToList<User>();

    Console.WriteLine(users);

    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.MapPost("/change-locale", (HttpResponse httpResponse, string culture) =>
{
    /*
     * CookieRequestCultureProvider
     * QueryStringRequestCultureProvider
     * AcceptLanguageHeaderRequestCultureProvider
    */
    httpResponse.Cookies.Append(
        CookieRequestCultureProvider.DefaultCookieName,
        CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
        new CookieOptions
        {
            Expires = DateTimeOffset.UtcNow.AddDays(7)
        });


    return Task.FromResult(Results.Ok("Locale has been saved"));
})
//.Accepts<string>(MediaTypeNames.Application.Json)
.WithName("ChangeLocale");

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}