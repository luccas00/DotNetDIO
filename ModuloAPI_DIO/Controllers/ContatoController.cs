using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModuloAPI_DIO.Context;
using ModuloAPI_DIO.Entities;

namespace ModuloAPI_DIO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext Context;

        public ContatoController(AgendaContext _context)
        {
            Context = _context;
        }

        /// <summary>
        /// Cria um Contato recebido por parametro
        /// </summary>
        /// <param name="contato">Contato a ser criado</param>
        /// <returns></returns>
        [HttpPost("Create")]
        public IActionResult Create(Contato contato)
        {
            Context.Add(contato);
            Context.SaveChanges();
            return Ok(contato);
        
        }
        
        /// <summary>
        /// Criar novo contato definindo nome e telefone
        /// </summary>
        /// <param name="nome">Nome do Contato</param>
        /// <param name="telefone">Telefone do Contato</param>
        /// <returns>Contato Criado</returns>
        [HttpPost("CreateNew/{nome};{telefone}")]
        public IActionResult CreateNewContato(string nome, string telefone)
        {
            Contato c1 = new Contato(nome, telefone);
            Context.Add(c1);
            Context.SaveChanges();
            return CreatedAtAction(nameof(BuscarContato), new { id = c1.Id }, c1);

        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("GetContato/{Id}")]
        public IActionResult BuscarContato(int Id)
        {
            var contato = Context.Contatos.Find(Id);

            if(contato == null)
            {
                return NotFound();
            }
            return Ok(contato);
        }

        /*Popula o bando de dados com 1000 registros com nome e telefone sequencial*/
        [HttpPost("PopulateTable")]
        public IActionResult PopulateTable()
        {
            List<Contato> lista = new List<Contato>();
            for (int i = 0; i < 1000; i++)
            {
                Contato c = new Contato(i.ToString(), i.ToString());
                lista.Add(c);
                Context.Add(c);
            }

            Context.SaveChanges();
            return Ok(lista);
        }

        /// <summary>
        /// Atualiza um registro do banco de dados
        /// </summary>
        /// <param name="id">Id do Resgistro a ser atualizado</param>
        /// <param name="contato"></param>
        /// <returns></returns>
        [HttpPut("Atualizar/{id}")]
        public IActionResult Atualizar(int id, Contato contato)
        {
            var contatoBanco = Context.Contatos.Find(id);

            if(contatoBanco == null)
            {
                return NotFound();
            }

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            Context.Contatos.Update(contatoBanco);
            Context.SaveChanges();

            return Ok(contatoBanco);

        }

        [HttpDelete("Deletar/{id}")]
        public IActionResult Deletar(int id)
        {
            var contatoBanco = Context.Contatos.Find(id);

            if (contatoBanco == null)
            {
                return NotFound();
            }

            Context.Contatos.Remove(contatoBanco);
            Context.SaveChanges();
            return NoContent();
        }

        [HttpGet("ObterPrimeiros10")]
        public IActionResult ObterPrimeiros10()
        {
            return Ok(Context.Contatos.Take(10));
        }
        
        [HttpGet("ContemNome/{nome}")]
        public IActionResult ObterContemNome(string nome)
        {
            var contatos = Context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }
        
        [HttpGet("NovoObterContemNome/{nome}")]
        public IActionResult NovoObterObterContemNome(string nome)
        {
            var contatos = Context.Contatos.Where(
                x => x.Nome.Contains(nome) &&
                x.Ativo.Equals(true));
            return Ok(contatos);
        }

    }
}
