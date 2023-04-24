
using Microsoft.AspNetCore.Mvc;
using NiN3KodeAPI.Entities;
using NiN3KodeAPI.Services;

namespace NiN3KodeAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        //private readonly IAdminService _adminService;
        private readonly ILogger<AdminController> _logger;
        private readonly IAdminService _adminService;
        public AdminController(IAdminService adminService, ILogger<AdminController> logger)
        {
            _adminService = adminService ?? throw new ArgumentNullException(nameof(adminService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet(Name = "HentDomener")]
        public async Task<ActionResult<IEnumerable<Domene>>> HentDomener()
        {
            //var domener = new Domene() {Id = Guid.NewGuid(), Navn="hardcoded" };
            var domener = await _adminService.HentDomenerAsync();
            if (domener == null)
            {
                //_logger.LogInformation($"City with id {cityid} wasn't found when accessing points of interest");
                return NotFound();
            }
            return Ok(domener);
        }

        [HttpGet(Name = "LogHello")]
        public string LogHello() {
            _logger.LogError("Hello from error level!!!");
            return "Hello was logged";
        }
    }
}
