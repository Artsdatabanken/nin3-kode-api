using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NiN3.Infrastructure.Services;
using System.Text;

namespace NiN3.WebApi.Controllers
{
    [ApiController]
    [Route("v3.0/rapporter"), Tags("Rapporter")]
    public class RapportController : ControllerBase
    {
        private readonly IRapportService _rapportService;
        private readonly IConfiguration _configuration;

        public RapportController(IRapportService rapportService, IConfiguration configuration)
        {
            _rapportService = rapportService;
            _configuration = configuration;
        }


        [HttpGet("kodeoversikt")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Kodeoversikt()
        {
            //var csvString = "Column1,Column2\nValue1,Value2"; // Your CSV string here
            string kodeoversiktcsv = _rapportService.MakeKodeoversiktCSV("3.0");
            //System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //var result = new FileContentResult(Encoding.GetEncoding("Windows-1252").GetBytes(kodeoversiktcsv), "text/csv")

            /*
            var result = new FileContentResult(Encoding.UTF8.GetBytes(kodeoversiktcsv), "text/csv")
            {
                FileDownloadName = "kodeoversikt.csv"
            };        
            return result;*/

            byte[] csvBytes = Encoding.UTF8.GetBytes(kodeoversiktcsv);
            byte[] bom = Encoding.UTF8.GetPreamble();
            var result = bom.Concat(csvBytes).ToArray();
            return File(result, "text/csv; charset=utf-8", "kodeoversikt.csv");
        }

    }
}
