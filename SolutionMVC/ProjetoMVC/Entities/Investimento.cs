using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace ProjetoMVC.Entities
{
    public class Investimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal? Montante { get; set; }
        public decimal? Taxa { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public bool? Ativo { get; set; }

        public Investimento()
        {
            Nome = string.Empty;
            DataInicio = DateTime.Now;
            DataFim = DateTime.Now;
            Ativo = true;
        }
        
    }
}
