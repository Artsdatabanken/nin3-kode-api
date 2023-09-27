using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.AspNetCore.ResponseCompression;
using NiN3.Core.Models.DTOs;
using NiN3.Core.Models.DTOs.type;
using NiN3.Infrastructure.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NiN3.Core.Models.Enums;

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
        //<summary>
        // This constructor initializes the TypeApiController class with the necessary services,
        // logger, and configuration. The ITypeApiService, ILogger,
        // and IConfiguration parameters are injected into the constructor
        // and assigned to the corresponding private fields. 
        // This allows the TypeApiController to access the services, logger, and configuration when needed.
        //</summary>
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
        public async Task<IActionResult> GetAllAsync()
        {
            var versjon = await _typeApiService.AllCodesAsync("3.0");
            Response.Headers.Add("Cache-Control", "max-age=3600");
            return Ok(versjon);
        }

        [HttpGet]
        [Route("hentklasse")]
        //[OutputCache(Duration = 86400)]// 24 timer
        [ProducesResponseType(typeof(IEnumerable<TypeKlasseDto>), StatusCodes.Status200OK)]
        public TypeKlasseDto HentType(string kortkode)
        {
            //var versjon = _typeApiService.HentKlasse(kortkode);
            //Response.Headers.Add("Cache-Control", "max-age=3600");
            //return Ok("Not yet implemented");
            //return NOT
            Console.WriteLine(kortkode);
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("hentkodeforType")]
        //[OutputCache(Duration = 86400)]// 24 timer
        [ProducesResponseType(typeof(IEnumerable<TypeDto>), StatusCodes.Status200OK)]
        public TypeDto hentkodeForType(string kortkode)
        {
            //var versjon = _typeApiService.HentKlasse(kortkode);
            //Response.Headers.Add("Cache-Control", "max-age=3600");
            //return Ok("Not yet implemented");
            //return NOT
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("hentkodeforHovedtypegruppe")]
        //[OutputCache(Duration = 86400)]// 24 timer
        [ProducesResponseType(typeof(IEnumerable<HovedtypegruppeDto>), StatusCodes.Status200OK)]
        public HovedtypegruppeDto hentkodeForHovedtypegruppe(string kortkode)
        {
            //var versjon = _typeApiService.HentKlasse(kortkode);
            //Response.Headers.Add("Cache-Control", "max-age=3600");
            //return Ok("Not yet implemented");
            //return NOT
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("hentkodeforHovedtype")]
        //[OutputCache(Duration = 86400)]// 24 timer
        [ProducesResponseType(typeof(IEnumerable<HovedtypeDto>), StatusCodes.Status200OK)]
        public HovedtypeDto hentkodeForHovedtype(string kortkode)
        {
            //var versjon = _typeApiService.HentKlasse(kortkode);
            //Response.Headers.Add("Cache-Control", "max-age=3600");
            //return Ok("Not yet implemented");
            //return NOT
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("hentkodeforGrunntype")]
        //[OutputCache(Duration = 86400)]// 24 timer
        [ProducesResponseType(typeof(IEnumerable<GrunntypeDto>), StatusCodes.Status200OK)]
        public GrunntypeDto hentkodeForGrunntype(string kortkode)
        {
            //var versjon = _typeApiService.HentKlasse(kortkode);
            //Response.Headers.Add("Cache-Control", "max-age=3600");
            //return Ok("Not yet implemented");
            //return NOT
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("hentkodeforKartleggingsenhet")]
        //[OutputCache(Duration = 86400)]// 24 timer
        [ProducesResponseType(typeof(IEnumerable<KartleggingsenhetDto>), StatusCodes.Status200OK)]
        public KartleggingsenhetDto hentkodeForKartleggingsenhet(string kortkode)
        {
            //var versjon = _typeApiService.HentKlasse(kortkode);
            //Response.Headers.Add("Cache-Control", "max-age=3600");
            //return Ok("Not yet implemented");
            //return NOT
            throw new NotImplementedException();
        }
    }
}
