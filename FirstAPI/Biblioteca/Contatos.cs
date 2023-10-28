using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Contatos
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
        public decimal Fatura { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
