using LearnEntityFramework.DBContext;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Net.Http.Headers;
using WebMinimalApi.Routes;
using WebMinimalApi.Services;

const string _policyName = "CorsPolicy";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<UserDBContext>();
builder.Services.AddLocalization();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddPolicy(_policyName, builder =>
{
    builder
    .WithOrigins("http://localhost:3000", "http://localhost:4200")
    .WithMethods("OPTION", "GET", "POST", "PUT", "DELETE")
    .WithHeaders(HeaderNames.ContentType, HeaderNames.AccessControlAllowOrigin)
    .WithExposedHeaders(HeaderNames.ContentDisposition)
    .AllowCredentials();
}));

builder.Services.AddDataProtection()
    .PersistKeysToFileSystem(new DirectoryInfo(@"C:\temp"))
    .SetApplicationName("SharedCookieApp");

builder.Services.ConfigureApplicationCookie(options => {
    options.Cookie.Name = ".AspNet.SharedCookie";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();

/**
 * Dependency can be injected by the following methods:
 * 1. Passing object into the constructor
 * 2. Use [FromServices] annotation as method parameter
 */
using (var scope = app.Services.CreateScope())
{
    var userService = scope.ServiceProvider.GetRequiredService<IUserService>();
    //UserRoutes userRoutes = new(userService);
    UserRoutes userRoutes = new();
    userRoutes.AddUserRoutes(app);
}


app.Run();

/*app.MapGet("/{id}", ([FromRoute] int id,
                     [FromQuery(Name = "p")] int page,
                     [FromServices] Service service,
                     [FromHeader(Name = "Content-Type")] string contentType)
                     => { });*/