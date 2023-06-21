/*
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NiN3.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;

namespace NiN3.Tests.Infrastructure
{
    public class UrlUtilServiceTests
    {
        [Fact]
        public async Task GetRootUrl_ReturnsRootUrl()
        {
            // Arrange
            var builder = new WebHostBuilder()
                .UseEnvironment("Testing")
                .ConfigureServices(services =>
                {
                    services.AddSingleton<IUrlUtilService, UrlUtilService>();
                })
                .Configure(app =>
                {
                    app.Run(async (context, RequestDelegate next) =>
                    {
                        var myService = context.RequestServices.GetRequiredService<IUrlUtilService>();
                        var rootUrl = myService.GetRootUrl();
                        await context.Response.WriteAsync(rootUrl);
                    });
                });

            var server = new TestServer(builder);
            var client = server.CreateClient();

            // Act
            var response = await client.GetAsync("/");

            // Assert
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Equal("https://localhost:5001/", responseString);
        }
    }
}
*/