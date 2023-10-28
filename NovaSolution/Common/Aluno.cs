using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Aluno : Pessoa
    {
        public double nota { get; private set; }
        
        public Aluno() { }
        public Aluno(double nota, string nome) : base(nome)
        {
            this.nota = nota;
        }
        public override void Apresentar()
        {
            Console.WriteLine($"\nNome: {this.nome}\nIdade: {this.idade}\nNota: {this.nota}");
        }
    }
}
