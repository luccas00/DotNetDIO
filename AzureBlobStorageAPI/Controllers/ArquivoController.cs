using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureBlobStorageAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArquivoController : Controller
    {

        private readonly string _connectionString;
        private readonly string _containerName;

        public ArquivoController(IConfiguration configuration)
        {
            
            _connectionString = configuration.GetValue<string>("BlobConnectionString");
            _containerName = configuration.GetValue<string>("BlobContainerName");
        }

        [HttpPost("UploadArquivo")]
        public IActionResult UploadArquivo(IFormFile arquivo)
        {
            //BLOB = Bynary Large Object
            BlobContainerClient container = new (_connectionString, _containerName);
            BlobClient blob = container.GetBlobClient(arquivo.FileName);

            using var data = arquivo.OpenReadStream();
            blob.Upload(data, new BlobUploadOptions
            {
                HttpHeaders = new BlobHttpHeaders { ContentType = arquivo.ContentType }
            });

            return Ok(blob.Uri.ToString());

        }

        [HttpGet("GetArquivo/{nome}")]
        public IActionResult DownloadArquivo(string nome)
        {
            //BLOB = Bynary Large Object
            BlobContainerClient container = new(_connectionString, _containerName);
            BlobClient blob = container.GetBlobClient(nome);

            if (!blob.Exists())
            {
                return BadRequest();
            }

            var retorno = blob.DownloadContent();
            return File(retorno.Value.Content.ToArray(), retorno.Value.Details.ContentType, blob.Name);

        }

        [HttpDelete("Delete/{nome}")]
        public IActionResult DeletarArquivo(string nome)
        {
            //BLOB = Bynary Large Object
            BlobContainerClient container = new(_connectionString, _containerName);
            BlobClient blob = container.GetBlobClient(nome);

            
            if(blob.DeleteIfExists())
            {
                return NoContent();
            }
            else
            {
                return Ok("Arquivo não existe");
            }
        }

        [HttpGet("AllFiles")]
        public IActionResult AllFiles()
        {
            List<BlobDto> blobsDto = new List<BlobDto>();
            BlobContainerClient container = new(_connectionString, _containerName);

            foreach(var blob in container.GetBlobs())
            {
                blobsDto.Add(new BlobDto
                {
                    Nome = blob.Name,
                    Tipo = blob.Properties.ContentType,
                    Uri = container.Uri.AbsoluteUri + "/" + blob.Name

                });
            }

            return Ok(blobsDto);

        }

    }
}
