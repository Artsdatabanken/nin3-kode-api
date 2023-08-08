/*
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NiN3.Core.Models;
using NiN3.Infrastructure.Services;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace NiN3.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class XMetaController : ControllerBase
    {
        //private readonly ILoaderService _metaService;
        private readonly ILogger<XMetaController> _logger;
        private readonly ILoaderService _metaService;
        //private readonly ISService _sservice;
        private readonly IConfiguration _conf;
        //public MetaController(IConfiguration configuration, ISService SService, ILoaderService metaService, ILogger<MetaController> logger)
        public XMetaController(IConfiguration configuration, ILoaderService metaService, ILogger<XMetaController> logger)
        {
            _metaService = metaService ?? throw new ArgumentNullException(nameof(metaService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            //_sservice = SService ?? throw new ArgumentNullException(nameof(logger));
            _conf = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        [HttpGet("Tabelliste")]
        public async Task<ActionResult<string>> ShowTables()
        {
            return Ok(_metaService.Tabeller());
        }

        /*
        [HttpGet("Tabelldata")]
        public ActionResult<List<object>> Get(string tabellnavn)
        {
            List<object> tdr = _metaService.Tabelldata(tabellnavn);
            //get count of arr
            //JArray a = JArray.Parse(trd);
            if (tdr==null) {
                return NotFound();
            }
            var c = tdr.Count;
            //var c = arr.Length;
            Response.Headers.Add("Recordcount", c.ToString());
            return tdr;
        }
        */
    /*}*/
    /*
    [HttpGet(Name = "HentDomener")]
    public async Task<ActionResult<IEnumerable<Versjon>>> HentDomener([FromHeader(Name = "admintoken")][Required] string admintokenHeader)
    {
        if (!CheckAuth(admintokenHeader))
        {
            return StatusCode(401);
        }
        //var domener = await _metaService.HentDomener();
        var domener = _metaService.HentDomener();
        if (domener == null)
        {
            return NotFound();
        }
        return Ok(domener);
    }*/

    /*
    [HttpGet(Name = "LogHello")]
    public string LogHello()
    {
        _logger.LogError("Hello from error level!!!");
        return "Hello was logged";
    }*/
    /*
    [HttpGet(Name = "return_env")]
    public string return_env()
    {
        return Environment.GetEnvironmentVariable("nin3kodeKV");
    }*/

    /*
    [HttpGet(Name = "st")]
    public string st()
    {
        return _sservice.Admintoken;
    }*/
    /*
    [HttpGet(Name = "st")]
    public string st()
    {
        return _conf.GetValue<string>("admintoken");
    }*/
    /*
    [HttpGet(Name = "OppdaterDatabasestruktur")]
    public string OppdaterDatabasestruktur()
    {
        _metaService.DoMigrations();
        _logger.LogInformation("Migration was attempted!");
        return "Migration was attempted!";
    }*/
    /*
    [HttpGet(Name = "LoadInitDB")]
    public async Task<ActionResult<string>> LoadInitDB()
    {

        //var ok = _metaService.OpprettInitDbAsync();
        var ok = _metaService.OpprettInitDb();
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
    */



    /*
    [HttpGet(Name = "test2")]
    public async Task<ActionResult<string>> Test2()
    {
        return Ok("En liten response fra test2.2");
    }*/

    /*
    private Boolean CheckAuth(string inputtoken)
    {
        //if (inputtoken != _sservice.Admintoken)
        if (inputtoken != _conf.GetValue<string>("admintoken"))
        {
            return false;
        }
        else
        {
            return true;
        }
    }*/
/*}*/
