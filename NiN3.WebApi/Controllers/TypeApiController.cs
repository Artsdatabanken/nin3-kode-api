using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.AspNetCore.ResponseCompression;
using NiN3.Core.Models.DTOs;
using NiN3.Core.Models.DTOs.type;
using NiN3.Infrastructure.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NiN3.Core.Models.Enums;
using System.Net;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;

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

        /// <summary> 
        /// This method gets all 'Type'-codes, arranged heir 
        /// </summary>
        /// <returns> 
        /// The list of 'Type'-codes. 
        /// </returns>
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
        //[ProducesResponseType(typeof(IEnumerable<TypeKlasseDto>), StatusCodes.Status200OK)]
        public ActionResult HentType([Required]string kortkode= "D-0-0")
        {
            //var versjon = _typeApiService.HentKlasse(kortkode);
            //Response.Headers.Add("Cache-Control", "max-age=3600");
            //return Ok("Not yet implemented");
            var typeklasseDto = _typeApiService.GetTypeklasse(kortkode);
            if (typeklasseDto != null)
            {
                return Ok(typeklasseDto);
            }
            else { 
                return NotFound();
            }  
        }

        [HttpGet]
        [Route("hentkodeforType")]
        //[OutputCache(Duration = 86400)]// 24 timer
        [ProducesResponseType(typeof(IEnumerable<TypeDto>), StatusCodes.Status200OK)]
        public IActionResult hentkodeForType([Required] string kortkode= "A-LV-EL")
        {
            //var versjon = _typeApiService.HentKlasse(kortkode);
            //Response.Headers.Add("Cache-Control", "max-age=3600");
            //return Ok("Not yet implemented");
            return StatusCode(501);
        }

        [HttpGet]
        [Route("hentkodeforHovedtypegruppe")]
        //[OutputCache(Duration = 86400)]// 24 timer
        [ProducesResponseType(typeof(IEnumerable<HovedtypegruppeDto>), StatusCodes.Status200OK)]
        public IActionResult hentkodeForHovedtypegruppe([Required] string kortkode= "FL-G")
        {
            //var versjon = _typeApiService.HentKlasse(kortkode);
            //Response.Headers.Add("Cache-Control", "max-age=3600");
            //return Ok("Not yet implemented");
            return StatusCode(501);
        }

        [HttpGet]
        [Route("hentkodeforHovedtype")]
        //[OutputCache(Duration = 86400)]// 24 timer
        [ProducesResponseType(typeof(IEnumerable<HovedtypeDto>), StatusCodes.Status200OK)]
        public IActionResult hentkodeForHovedtype([Required] string kortkode = "H-0-29")
        {
            //var versjon = _typeApiService.HentKlasse(kortkode);
            //Response.Headers.Add("Cache-Control", "max-age=3600");
            //return Ok("Not yet implemented");
            return StatusCode(501);
        }

        [HttpGet]
        [Route("hentkodeforGrunntype")]
        //[OutputCache(Duration = 86400)]// 24 timer
        [ProducesResponseType(typeof(IEnumerable<GrunntypeDto>), StatusCodes.Status200OK)]
        public IActionResult hentkodeForGrunntype([Required] string kortkode = "K-0-02-006")
        {
            //var versjon = _typeApiService.HentKlasse(kortkode);
            //Response.Headers.Add("Cache-Control", "max-age=3600");
            //return Ok("Not yet implemented");
            return StatusCode(501);
        }

        [HttpGet]
        [Route("hentkodeforKartleggingsenhet")]
        //[OutputCache(Duration = 86400)]// 24 timer
        [ProducesResponseType(typeof(IEnumerable<KartleggingsenhetDto>), StatusCodes.Status200OK)]
        public IActionResult hentkodeForKartleggingsenhet([Required] string kortkode = "LA01-M005-13")
        {
            //var versjon = _typeApiService.HentKlasse(kortkode);
            //Response.Headers.Add("Cache-Control", "max-age=3600");
            //return Ok("Not yet implemented");
            return StatusCode(501);
        }
    }
}
