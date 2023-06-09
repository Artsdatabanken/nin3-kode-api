global using NiN3KodeAPI.Entities;
global using Microsoft.EntityFrameworkCore;
using NiN3KodeAPI.DbContexts;
using NiN3KodeAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddScoped<DataImportHelper>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment()){
    builder.Services.AddDbContext<NiN3DbContext>(options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("default"));
    });
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.EnvironmentName=="Test")
{
    app.UseSwagger();
    app.UseSwaggerUI();
    var scope = app.Services.CreateScope();
    var db = scope.ServiceProvider.GetService<NiN3DbContext>();
    // (db != null) { db.Database.Migrate(); };
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();