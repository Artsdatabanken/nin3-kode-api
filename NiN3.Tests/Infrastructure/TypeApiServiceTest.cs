using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NiN.Infrastructure.Services.LoaderService;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using NiN3.Infrastructure.DbContexts;
using NiN3.Infrastructure.Services;
using AutoMapper;
using Castle.Core.Logging;
using Microsoft.Extensions.Logging;
using Moq;
using NiN.Infrastructure.Services;

namespace NiN3.Tests.Infrastructure
{
    public class TypeApiServiceTest
    {



        private IMapper _mapper;
        private ILogger<TypeApiService> _logger;

        public TypeApiServiceTest()
        {
            _logger = new Mock<ILogger<TypeApiService>>().Object;
        }

        private static NiN3DbContext GetInMemoryDb()//out SqliteConnection connection, out DbContextOptions<NiN3DbContext> options)
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            var options = new DbContextOptionsBuilder<NiN3DbContext>()
            .UseSqlite(connection)
            .Options;
            var context = new NiN3DbContext(options);
            context.Database.EnsureCreated();
            return context;
        }

        private void rigMapper()
        {
            var mappingProfile = new NiN3.Infrastructure.Mapping.Profiles.AllProfiles();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(mappingProfile);
            });
            _mapper = new Mapper(config);

        }

        [Fact]
        public void TestAllCodesVersjon()
        {
            rigMapper();
            var inmemorydb = GetInMemoryDb();
            var loader = new LoaderService(null, inmemorydb, new Mock<ILogger<LoaderService>>().Object);
            var service = new TypeApiService(_mapper, inmemorydb, _logger);
            loader.LoadTypeData();
            //loader.LoadHovedtypeData();
            // q: assert that v3alleCodes is not null
            var v3allCodes = serice.AllCodes("3.0");
            Assert.NotNull(v3allCodes);
            //Assert.Null(v3alleCodes.Typer);
            Assert.Equal(10, v3allCodes.Typer.Count);
            var firstType = v3allCodes.Typer.First();
            Assert.Equal("A-LV-BM", firstType.Kode.Id);
            //q: assert that v3alleCodes.navn is '3.0'
            Assert.Equal("3.0", v3allCodes.Navn);
        }
    }
}

