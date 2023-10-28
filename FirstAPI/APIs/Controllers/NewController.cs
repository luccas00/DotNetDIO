using Microsoft.AspNetCore.Mvc;
using Biblioteca;

namespace APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewController : ControllerBase
    {
        [HttpGet("ObterDataLuccas")]
        public IActionResult ObterData()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);

        }

        [HttpGet("ObterAniversario")]
        public IActionResult Aniversario()
        {
            var obj = new
            {
                Data = new DateTime(1998, 11, 17)
            };

            return Ok(obj);

        }

        [HttpGet("Fatorial/{number}")]
        public IActionResult FatoriaDeN(double number)
        {

            double result = Class1.FatorialInterno(number);

            return Ok(new { result });

        }

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Ola!, {nome}, Seja bem vindo!!!";

            return Ok(new { mensagem });
        }
    }
}
