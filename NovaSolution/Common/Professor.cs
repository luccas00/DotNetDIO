using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Professor : Pessoa
    {
        public double salario { get; private set; }

        public Professor() { }
        public Professor(double salario, string nome) : base(nome)
        {
            this.salario = salario;
        }

        public override void Apresentar()
        {
            Console.WriteLine($"\nNome: {this.nome}\nIdade: {this.idade}\nSalario R$ {this.salario}");
        }
    }
}
