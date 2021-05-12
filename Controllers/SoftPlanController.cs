using Microsoft.AspNetCore.Mvc;
using System;

namespace SoftPLan.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SoftPlanController : ControllerBase
    {
        [HttpGet("taxajuros")]
        public decimal TaxaJuros()
        {
            return 0.01M;
        }

        [HttpGet("calculajuros")]
        public decimal CalculaJuros(decimal valorInicial, int meses)
        {
            return decimal.Round(valorInicial * (decimal)Math.Pow(1.0 + (double)TaxaJuros(), meses),2);
        }
        
        [HttpGet("showmethecode")]
        public string showmethecode()
        {
            return "https://github.com/thiagounix/Softplan";
        }
    }
}
