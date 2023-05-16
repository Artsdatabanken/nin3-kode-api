global using NiN3KodeAPI.Entities;
global using Microsoft.EntityFrameworkCore;
using NiN3KodeAPI.DbContexts;
using NiN3KodeAPI.Services;
using NiN3KodeAPI;
using System.Collections;
using Azure.Identity;

var builder = WebApplication.CreateBuilder(args);
if (builder.Environment.IsProduction() || builder.Environment.IsStaging())
{
    builder.Configuration.AddAzureKeyVault(
        new Uri($"https://{builder.Configuration["KeyVault:Name"]}.vault.azure.net/"),
        new DefaultAzureCredential());
}


var controllers_to_exclude_from_prod = new ArrayList() {"WeatherForecast", "Admin"};

// Add services to the container.
//var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
builder.Services.AddControllers(o =>
{
    //if (environment == "Development")
    if (builder.Environment.IsProduction())
    {
        o.Conventions.Add(new ActionHidingConvention(controllers_to_exclude_from_prod));
    }
});
builder.Services.AddDbContext<NiN3DbContext>(options =>
{
    if (builder.Configuration.GetConnectionString("default").Contains("Server=tcp"))
    {
         options.UseSqlServer(builder.Configuration.GetConnectionString("default"));
    }
    else
    {
        options.UseSqlite(builder.Configuration.GetConnectionString("default"));
    }
   
    //options.UseSqlite(builder.Configuration.GetConnectionString("default"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddSingleton<ISService, SService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//    var scope = app.Services.CreateScope();
//    var db = scope.ServiceProvider.GetService<NiN3DbContext>();
//    //if (db != null) { db.Database.Migrate(); };
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();
app.MapGet("/", () => "Hello World!");
//app.MapControllers();
////* One way to get key vault secrets */
//var SService = app.Services.GetRequiredService<ISService>();
////SService.Startup();


////var tokenService = host.Services.GetRequiredService<ITokenService>();
////tokenService.DoSomething();

app.Run();