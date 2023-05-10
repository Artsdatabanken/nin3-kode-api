global using NiN3KodeAPI.Entities;
global using Microsoft.EntityFrameworkCore;
using NiN3KodeAPI.DbContexts;
using NiN3KodeAPI.Services;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<NiN3DbContext>(options =>
{
    //options.UseSqlServer(builder.Configuration.GetConnectionString("default"));
    options.UseSqlite(builder.Configuration.GetConnectionString("default"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddScoped<DataImportHelper>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddSingleton<ISService, SService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.EnvironmentName == "Test")
{
    app.UseSwagger();
    app.UseSwaggerUI();
    var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetService<NiN3DbContext>();
    //if (db != null) { db.Database.Migrate(); };
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
var SService = app.Services.GetRequiredService<ISService>();
SService.Startup();
//var tokenService = host.Services.GetRequiredService<ITokenService>();
//tokenService.DoSomething();

app.Run();