//global using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using NiN.Infrastructure.Services;
using NiN3.Infrastructure.DbContexts;
using NiN3.Infrastructure.Mapping;
using NiN3.Infrastructure.Mapping.Profiles;
using NiN3.Infrastructure.Services;
using NiN3.WebApi;
using System.Collections;
using System.Text.Json.Serialization;
using System.Xml.Linq;


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
}).AddJsonOptions(options =>
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
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
builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddScoped<IVariabelApiService, VariabelApiService>();
builder.Services.AddScoped<IRapportService, RapportService>();
//builder.Services.AddSingleton<ISService, SService>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton(x => XDocument.Load("NiN3.WebApi.xml"));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "NiN3 API", Version = "v3.0" });
    var xmlFile = "NiN3.WebApi.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
    //c.SchemaFilter<EnumDescriptionSchemaFilter>();
    //c.SchemaFilter<EnumSummarySchemaFilter>();
});

//Trying to use gzip to help with performance on large responses
builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
    options.Providers.Add<GzipCompressionProvider>();
});
builder.Services.AddResponseCompression(options =>
{
    options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "text/html", "application/json" });
});

var app = builder.Build();
app.UseResponseCompression();
app.UseOutputCache();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
{
    app.UseSwagger();
    app.UseSwaggerUI(config => config.ConfigObject.AdditionalItems["syntaxHighlight"] = new Dictionary<string, object>
    {
        ["activated"] = false
    });
    //var scope = app.Services.CreateScope();
    //var db = scope.ServiceProvider.GetService<NiN3DbContext>();
    //db.Database.EnsureCreated();
    //if (db != null) { db.Database.Migrate(); };
}


app.UseAuthorization();


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
