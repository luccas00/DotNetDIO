using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace LuccasGeradorCPF
{
    public class FatorialN
    {
        private readonly ILogger<FatorialN> _logger;

        public FatorialN(ILogger<FatorialN> log)
        {
            _logger = log;
        }

        [FunctionName("FatorialN")]
        [OpenApiOperation(operationId: "Run", tags: new[] { "FatorialN" })]
        [OpenApiParameter(name: "number", In = ParameterLocation.Path, Required = true, Type = typeof(double), Description = "Valor de N")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "Fatorial de N")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "FatorialN/{number}")] HttpRequest req,
            double number)
        {
            _logger.LogInformation($"Number: {number}", number);

            var result = Fatorial(number);

            string responseMessage = $"Fatorial: {result}";

            _logger.LogInformation($"Fatorial: {result}", result);

            return new OkObjectResult(JsonConvert.SerializeObject(responseMessage, Formatting.Indented));
        }

        private double Fatorial(double number)
        {
            if(number <= 1)
            {
                return 1;
            }
            else
            {
                return number * Fatorial(number - 1);
            }
        }

    }
}

