using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ProjetoMVC.Entities
{
    public class Banco
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Investimento>? Ofertas { get; set; }
        public List<Cliente>? Clientes { get; set; }

        public Banco()
        {
            this.Ofertas = new List<Investimento>();
            this.Clientes = new List<Cliente>();
        }

    }
}
