using ProjetoMVC.Entities;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Context;

namespace ProjetoMVC.Controllers
{
    public class InvestimentoController : Controller
    {
        private readonly MyContext _context;

        public InvestimentoController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var investimentos = _context.Investimentos.ToList();
            return View(investimentos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Investimento investimento)
        {
            if(ModelState.IsValid)
            {
                investimento.Ativo = true;
                _context.Investimentos.Add(investimento);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(investimento);
        }

        public IActionResult Editar(int id)
        {
            var investimento = _context.Investimentos.Find(id);

            if(investimento == null)
            {
                return NotFound();
            }

            return View(investimento);

        }

        [HttpPost]
        public IActionResult Editar(Investimento investimento)
        {
            var result = _context.Investimentos.Find(investimento.Id);

            result.Nome = investimento.Nome;
            result.Montante = investimento.Montante;
            result.Taxa = investimento.Taxa;
            result.DataInicio = investimento.DataInicio;
            result.DataFim = investimento.DataFim;

            _context.Investimentos.Update(result);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));

        }

        public IActionResult Detalhes(int id)
        {
            var investimento = _context.Investimentos.Find(id);

            if (investimento == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(investimento);
        }


        [HttpPost("AdicionarNovo")]
        public IActionResult AdicionarNovo(int valor)
        {
            Investimento i = new Investimento();
            _context.Investimentos.Add(i);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Deletar(int id)
        {
            var investimento = _context.Investimentos.Find(id);

            if (investimento == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(investimento);
        }

        [HttpPost]
        public IActionResult Deletar(Investimento investimento)
        {
            var result = _context.Investimentos.Find(investimento.Id);

            result.Ativo = false;

            _context.Investimentos.Update(result);
            _context.SaveChanges();


            return RedirectToAction(nameof(Index));

        }

    }
}
