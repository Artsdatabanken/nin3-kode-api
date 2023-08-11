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
using NiN3.Infrastructure.Mapping.Profiles;
using Microsoft.Extensions.DependencyInjection;
using Azure;
using NiN3.Infrastructure.Mapping;


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


var controllers_to_exclude_from_prod = new ArrayList() { "Admin", "Meta" };

// Add services to the container.
builder.Services.AddOutputCache();
builder.Services.AddControllers(o =>
{
    //if (builder.Environment.IsDevelopment())
    if (builder.Environment.IsProduction() || builder.Environment.IsStaging())
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
    //options.UseSqlite(builder.Configuration.GetConnectionString("memory"));    // Assuming this is the method the developer wants to use inside the LoaderService class.

    //options.UseSqlite("../NiN3.Infrastructure/Database/nin3kapi.db");
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddAutoMapper(typeof(NiN3.Infrastructure.Mapping.Profiles.AllProfiles));
//builder.Services.AddScoped<AllProfiles>();
builder.Services.AddAutoMapper(typeof(AllProfiles));
builder.Services.AddScoped<ILoaderService, LoaderService>();
builder.Services.AddScoped<ITypeApiService, TypeApiService>();
builder.Services.AddScoped<IVariabelApiService, VariabelApiService>();
//builder.Services.AddSingleton<ISService, SService>();
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseOutputCache();
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
//redirect to swagger ui

//app.MapGet("/", () => $"Hello World! (env. : {app.Environment.EnvironmentName})");

app.MapControllers();
app.Use(async (context, next) =>
{
    if (context.Request.Path == "/")
    {
        context.Response.Headers.Add("env", app.Environment.EnvironmentName);
        context.Response.Redirect("/swagger/index.html");
        return;
    }

    await next();
});
////* One way to get key vault secrets */
//var SService = app.Services.GetRequiredService<ISService>();
////SService.Startup();


////var tokenService = host.Services.GetRequiredService<ITokenService>();
////tokenService.DoSomething();
/// todo-sat: instantiate mapper singleton Infrastucture.Mapping.NiN3Mapper and set config.
var mapper = NiNkodeMapper.Instance;
mapper.SetConfiguration(builder.Configuration);

// Used if db is memory database, but had som problem with dissapearing tables.
/*
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetService<NiN3DbContext>();
    db.Database.EnsureCreated();
    var loaderService = scope.ServiceProvider.GetService<ILoaderService>();
    loaderService.load_all_data();
}*/
app.Run();
