using Sharprompt;
using System;
using System.IO;
using System.ComponentModel.Design.Serialization;
using NiN3.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using NiN.Infrastructure.Services;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
// See https://aka.ms/new-console-template for more information

//IConfiguration config;
NiN3DbContext db = null;

IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

void LoadDB() {
    var optionsBuilder = new DbContextOptionsBuilder<NiN3DbContext>();
    optionsBuilder.UseSqlite(config.GetConnectionString("Extract"));
    db = new NiN3DbContext(optionsBuilder.Options);
    db.Database.EnsureCreated();
}
var buildtDbFileName = config.GetValue<string>("bildtDbFileName");
var buildtDbFileFullPath = config.GetValue<string>("buildtDBFilePath");
using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder
        .AddFilter("Microsoft", LogLevel.Warning)
        .AddFilter("System", LogLevel.Warning)
        .AddFilter("NonHostConsoleApp.Program", LogLevel.Debug)
        .AddConsole();
});
ILogger logger = loggerFactory.CreateLogger<Program>();
ILogger<LoaderService> _logger = loggerFactory.CreateLogger<LoaderService>();



// api klient
var run = true;
var meny = @"Commands:
            wipe    : delete databasefile
            full    : Full import of datasets
            copy    : Move new db file to webproject
            exit    : Close program";
while (run)
{
    var input = Prompt.Input<string>("nin3console ");
    switch (input)
    {
        case "help":
            Console.WriteLine(meny);
            break;
        case "full":
            // ensure db is created
            LoadDB();
            db.Database.EnsureCreated();
            // run loader
            var loader = new LoaderService(config, db, _logger);
            loader.load_all_data();
            // then exit program
            break;
        case "exit":
            return;
            break;
       /* case "status":
            var tableNames = db.Model.GetEntityTypes()
                .Select(t => t.GetTableName())
                .Distinct()
                .ToList();

            var tableRowCounts = new Dictionary<string, int>();

            foreach (var tableName in tableNames)
            {
                var tableType = db.Model.GetEntityTypes().FirstOrDefault(t => t.GetTableName() == tableName).ClrType;
                var tableData = db.Set(tableType);
                var rowCount = tableData.Count();
                tableRowCounts.Add(tableName, rowCount);
            }

            foreach (var kvp in tableRowCounts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            break;*/
        case "wipe":
            if (db == null)
            {
                Console.WriteLine($"Running choice 'wipe'");
                var filename = config.GetValue<string>("buildtDBFilePath");
                //var droptablesquery = $"drop table if exists Domene Grunntype";
                FileInfo fi = new FileInfo(filename);
                if (fi.Exists)
                {
                    fi.Delete();
                }  
            }
            else
            {
                Console.WriteLine("Cannot delete db file while in use");
            }
            //File.Delete(filename);
            break;
        case "copy":
            //webapiDBpath // copy manually
            var arr = config.GetConnectionString("Extract").Split("=");
            var sourcepath = buildtDbFileFullPath;
            //var destinationfile = config.GetValue<string>("webapiDBpath");
            var path = config.GetValue<string>("webapiDBpath");
            try { 
            File.Copy(sourcepath, path, true); //not working fix later
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            };
            break;
        default:
            Console.WriteLine("No knows command, options:");
            Console.WriteLine(meny);
            break;
    }
}