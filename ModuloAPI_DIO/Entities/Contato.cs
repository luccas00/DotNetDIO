using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ModuloAPI_DIO.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set;}
        public bool Ativo { get; set;}

        public Contato() { }
        public Contato(string nome, string telefone)
        {
            this.Nome = nome;
            this.Telefone = telefone;
        }

    }
}
