using System;
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

namespace LuccasFunctionN
{
    public class AreaCirculo
    {
        private readonly ILogger<AreaCirculo> _logger;

        public AreaCirculo(ILogger<AreaCirculo> log)
        {
            _logger = log;
        }

        [FunctionName("AreaCirculo")]
        [OpenApiOperation(operationId: "Run", tags: new[] { "AreaCirculo" })]
        [OpenApiParameter(name: "raio", In = ParameterLocation.Path, Required = true, Type = typeof(double), Description = "Raio do Circulo")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "Dados do Circulo")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "AreaCirculo/{raio}")] HttpRequest req,
            double raio)
        {
            _logger.LogInformation($"Raio: {raio}", raio);

            double area = Math.PI * Math.Pow(raio,2);
            double perimetro = Math.PI * 2 * raio;

            var circulo = new { Nome = "Circulo", Area = area, Perimetro = perimetro };

            return new OkObjectResult(JsonConvert.SerializeObject(circulo, Formatting.Indented));
        }
    }
}

