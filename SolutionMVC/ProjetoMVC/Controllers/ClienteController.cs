using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Context;
using ProjetoMVC.Entities;

namespace ProjetoMVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly MyContext _context;

        public ClienteController(MyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var clientes = _context.Clientes.ToList();
            return View(clientes);
        }
    }
}
