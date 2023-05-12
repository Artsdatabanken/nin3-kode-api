
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NiN3KodeAPI.Entities;
using NiN3KodeAPI.Services;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace NiN3KodeAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        //private readonly IAdminService _adminService;
        private readonly ILogger<AdminController> _logger;
        private readonly IAdminService _adminService;
        private readonly ISService _sservice;
        public AdminController(ISService SService, IAdminService adminService, ILogger<AdminController> logger)
        {
            _adminService = adminService ?? throw new ArgumentNullException(nameof(adminService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _sservice = SService ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet(Name = "HentDomener")]
        public async Task<ActionResult<IEnumerable<Domene>>> HentDomener([FromHeader(Name = "admintoken")][Required] string admintokenHeader)
        {
            if (!CheckAuth(admintokenHeader)) {
                return StatusCode(401);
            }
            var domener = await _adminService.HentDomenerAsync();
            if (domener == null)
            {
                return NotFound();
            }
            return Ok(domener);
        }

        /*
        [HttpGet(Name = "LogHello")]
        public string LogHello()
        {
            _logger.LogError("Hello from error level!!!");
            return "Hello was logged";
        }*/

        [HttpGet(Name = "return_env")]
        public string return_env()
        {
            return Environment.GetEnvironmentVariable("nin3kodeKV");
        }

        /*
        [HttpGet(Name = "st")]
        public string st()
        {
            return _sservice.Admintoken;
        }*/

        [HttpGet(Name = "OppdaterDatabasestruktur")]
        public string OppdaterDatabasestruktur()
        {
            _adminService.DoMigrations();
            _logger.LogInformation("Migration was attempted!");
            return "Migration was attempted!";
        }

        [HttpGet(Name = "LoadInitDB")]
        public async Task<ActionResult<string>> LoadInitDB()
        {

            var ok = _adminService.OpprettInitDbAsync();
            if (ok)
            {
                _logger.LogInformation("DB was loaded!");
                return Ok("DB was loaded!");
            }
            else
            {
                _logger.LogError("Something went sideways!");
                return StatusCode(500);
            }
            return "DB was loaded";
        }


        [HttpGet("Tabelliste")]
        public async Task<ActionResult<string>> ShowTables()
        {
            return Ok(_adminService.Tabeller());
        }

        [HttpGet("Tabelldata")]
        public async Task<IActionResult> Tabelldata(string tabellnavn)
        {
            var tdr = _adminService.Tabelldata(tabellnavn);
            //
            var c = ((JArray)JsonConvert.DeserializeObject(tdr)).Count;
            Response.Headers.Add("Recordcount", c.ToString());
            return Content(tdr, "application/json");
        }

        /*
        [HttpGet(Name = "test2")]
        public async Task<ActionResult<string>> Test2()
        {
            return Ok("En liten response fra test2.2");
        }*/

        private Boolean CheckAuth(string inputtoken) {
            if (inputtoken != _sservice.Admintoken)
            {
                return false;
            }
            else {
                return true;
            }
        }
    }
}
