using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.AspNetCore.ResponseCompression;
using NiN3.Core.Models.DTOs;
using NiN3.Infrastructure.Services;

namespace NiN3.WebApi.Controllers
{
    //[ApiVersion("3.0")]
    [ApiController]
    [Route("v3.0/typer"), Tags("Typekoder")]
    public class TypeApiController : Controller
    {
        private readonly ITypeApiService _typeApiService;
        /*private readonly ILogger _logger;*/
        private readonly IConfiguration _configuration;

        // This constructor initializes the TypeApiController class with the necessary services,
        // logger, and configuration. The ITypeApiService, ILogger,
        // and IConfiguration parameters are injected into the constructor
        // and assigned to the corresponding private fields. 
        // This allows the TypeApiController to access the services, logger, and configuration when needed.
        
        public TypeApiController(ITypeApiService typeApiService, /*ILogger logger,*/ IConfiguration configuration)
        {
            _typeApiService = typeApiService;
            /*_logger = logger;*/
            _configuration = configuration;
        }

        //This code is a method that is used to get all 'Type'-codes from a service.
        [HttpGet]
        [Route("allekoder")]
        //[OutputCache(Duration = 86400)]// 24 timer
        [ProducesResponseType(typeof(IEnumerable<VersjonDto>), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            var versjon = _typeApiService.AllCodes("3.0");
            Response.Headers.Add("Cache-Control", "max-age=3600");
            return Ok(versjon);
        }
    }
}
