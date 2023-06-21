global using NiN3.Core.Models;
//global using Microsoft.EntityFrameworkCore;
using NiN3.Infrastructure.DbContexts;
using NiN3.Infrastructure.Services;
using System.Collections;
using Azure.Identity;
using NiN3.WebApi;
using Microsoft.EntityFrameworkCore;
using NiN.Infrastructure.Services;
using NLog;


/*Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Verbose()
    .WriteTo.Console()
    .WriteTo.File("logs/NiN3kapinfo.log", rollingInterval: RollingInterval.Day)
    .CreateLogger();*/


var builder = WebApplication.CreateBuilder(args);
//if (builder.Environment.IsProduction() || builder.Environment.IsStaging() || builder.Environment.IsDevelopment())
/*
if (builder.Environment.IsProduction() || builder.Environment.IsStaging())
{
    builder.Configuration.AddAzureKeyVault(
        new Uri($"https://{builder.Configuration["KeyVault:Name"]}.vault.azure.net/"),
        new DefaultAzureCredential());
}*/


var controllers_to_exclude_from_prod = new ArrayList() {"Admin", "Meta"};

// Add services to the container.
//var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
builder.Services.AddControllers(o =>
{
    if (builder.Environment.IsDevelopment())
    //if (builder.Environment.IsProduction())
    {
        o.Conventions.Add(new ActionHidingConvention(controllers_to_exclude_from_prod));
    }
});
builder.Services.AddDbContext<NiN3DbContext>(options =>
{
    /*
    if (builder.Configuration.GetValue<bool>("useMssql"))
    {
         options.UseSqlServer(builder.Configuration.GetConnectionString("default"));
    }
    else
    {
        options.UseSqlite(builder.Configuration.GetConnectionString("default"));
    }*/

    options.UseSqlite(builder.Configuration.GetConnectionString("default"));
    //options.UseSqlite("../NiN3.Infrastructure/Database/nin3kapi.db");
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddAutoMapper(typeof(NiN3.Infrastructure.Mapping.Profiles.AllProfiles));
builder.Services.AddScoped<ILoaderService, LoaderService>();
builder.Services.AddScoped<ITypeApiService, TypeApiService>();
//builder.Services.AddSingleton<ISService, SService>();
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetService<NiN3DbContext>();
    db.Database.EnsureCreated();
    //if (db != null) { db.Database.Migrate(); };
}

//app.UseHttpsRedirection();

app.UseAuthorization();
app.MapGet("/", () => "Hello World!");
app.MapControllers();
////* One way to get key vault secrets */
//var SService = app.Services.GetRequiredService<ISService>();
////SService.Startup();


////var tokenService = host.Services.GetRequiredService<ITokenService>();
////tokenService.DoSomething();

app.Run();