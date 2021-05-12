using Microsoft.AspNetCore.Mvc;
using System;

namespace SoftPLan.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JurosController : ControllerBase
    {
        [HttpGet("taxajuros")]
        public decimal TaxaJuros()
        {
            return 0.01M;
        }

        [HttpGet("calculajuros")]
        public ActionResult<decimal> CalculaJuros(decimal valorInicial, int meses)
        {
            var result = TaxaJuros();
            if (result.Equals(null))
            {
                return NotFound();
            } 
                
            return decimal.Round(valorInicial * (decimal)Math.Pow(1.0 + (double)result, meses),2);
        }
        
      
    }
}
