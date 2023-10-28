using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Biblioteca
{
    public class Professor : Pessoa
    {
        public decimal salario { get; set; }
        public Professor(string nome, int idade, decimal salario) : base(nome, idade)
        {
            this.salario = salario;
        }
        public Professor(string nome, decimal salario) : base(nome)
        {
            this.salario = salario;
        }
        public Professor(string nome) : base(nome)
        {
            this.salario = 0;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"- - - - -\n" +
                $"Professor\n" +
                $"Nome: {this.nome}\n" +
                $"Idade: {this.idade}\n" +
                $"Salario R$ {this.salario}");
        }
    }
}
