using Azure.Data.Tables;
using AzureTableWebAPI.Tabelas;
using Microsoft.AspNetCore.Mvc;

namespace AzureTableWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagemController : Controller
    {
        private readonly string _connectionString;

        private readonly string _tableName;

        public PersonagemController(IConfiguration configuration)
        {
            _connectionString = configuration.GetValue<string>("SAConnectionString");
            _tableName = configuration.GetValue<string>("AzureTableName");
        }

        private TableClient GetTableClient()
        {
            var serviceClient = new TableServiceClient(_connectionString);
            var tableClient = serviceClient.GetTableClient(_tableName);

            tableClient.CreateIfNotExists();
            return tableClient;
        }

        [HttpPost]
        public IActionResult Criar(Personagem personagem)
        {
            var tableClient = GetTableClient();

            personagem.RowKey = Guid.NewGuid().ToString();
            personagem.PartitionKey = personagem.RowKey;

            tableClient.UpsertEntity(personagem);

            return Ok(personagem);

        }

        [HttpPost("CriarNovo/{nome}")]
        public IActionResult CriarNovo(string nome)
        {
            var tableClient = GetTableClient();

            Personagem personagem = new Personagem(nome);

            tableClient.UpsertEntity(personagem);

            return Ok(personagem);

        }

        [HttpPut("Atualizar/{id}")]
        public IActionResult Atualizar(string id, Personagem personagem)
        {
            var tableClient = GetTableClient();
            var personagemTable = tableClient.GetEntity<Personagem>(id, id).Value;

            personagemTable.Nome = personagem.Nome;
            personagemTable.Sobrenome = personagem.Sobrenome;
            personagemTable.Idade = personagem.Idade;
            personagemTable.Regiao = personagem.Regiao;
            personagemTable.Especie = personagem.Especie;
            personagemTable.Imortal = personagem.Imortal;

            tableClient.UpsertEntity(personagemTable);
            return Ok();

        }

        [HttpGet("ListAll")]
        public IActionResult ObterTodos()
        {
            var tableClient = GetTableClient();
            var list = tableClient.Query<Personagem>().ToList();
            return Ok(list);

        }

        [HttpGet("ObterPorNome/{nome}")]
        public IActionResult Obter(string nome)
        {
            var tableClient = GetTableClient();
            var list = tableClient.Query<Personagem>(x => x.Nome.Equals(nome)).ToList();
            return Ok(list);

        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Deletar(string id)
        {
            var tableClient = GetTableClient();
            tableClient.DeleteEntity(id, id);
            return NoContent();

        }

    }
}
