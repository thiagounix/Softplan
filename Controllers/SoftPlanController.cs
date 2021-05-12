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
        public ActionResult<decimal> CalculaJuros(decimal valorInicial, int meses)
        {
            var result = TaxaJuros();
            if (result.Equals(null))
            {
                return NotFound();
            } 
                
            return decimal.Round(valorInicial * (decimal)Math.Pow(1.0 + (double)result, meses),2);
        }
        
        [HttpGet("showmethecode")]
        public void showmethecode()
        {
            Response.Redirect("https://github.com/thiagounix/Softplan");
          
        }
    }
}
