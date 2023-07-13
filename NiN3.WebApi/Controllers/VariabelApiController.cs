using Microsoft.AspNetCore.Mvc;
using NiN3.Core.Models.DTOs;
using NiN3.Infrastructure.Services;

namespace NiN3.WebApi.Controllers
{
    //[ApiVersion("3.0")]
    [ApiController]
    [Route("v3.0/variabler"), Tags("Variabelkoder")]
    public class VariabelApiController : Controller
    {



        private readonly IVariabelApiService _variabelApiService;
        private readonly IConfiguration _configuration;

        public VariabelApiController(IVariabelApiService variabelApiService, IConfiguration configuration)
        {
            _variabelApiService = variabelApiService;
            _configuration = configuration;
        }
        //This code is a method that is used to get all 'Variabel'-codes from a service.
        [HttpGet] //This is an attribute that indicates that this method will handle HTTP GET requests.
        [Route("allekoder")] //This is an attribute that specifies the route for the method.
        [ProducesResponseType(typeof(IEnumerable<VersjonDto>), StatusCodes.Status200OK)] //This is an attribute that specifies the type of response that will be returned from the method.
        public IActionResult GetAll() //This is the method that will handle the request.
        {
            var versjon = _variabelApiService.AllCodes("3.0"); //This line calls the AllCodes() method of the _typeApiService.
            return Ok(versjon); //This line returns an OK response with the data from the AllCodes() method.
        }
    }
}