using System;
using Newtonsoft.Json;

namespace Biblioteca
{
    public sealed class Aluno : Pessoa
    {
        public List<double> notas { get; set; }
        public Aluno(string nome, int idade) : base(nome, idade) { notas = new List<double>(); }
        public Aluno(string nome) : base(nome) { notas = new List<double>(); }

        public override void GetInfo()
        {
            Console.WriteLine($"- - - - -\n" +
                $"Aluno\n" +
                $"Nome: {this.nome}\n" +
                $"Idade: {this.idade}\n" +
                $"- Notas -\n");
            foreach(double d in notas)
            {
                Console.WriteLine($"[{d}]");
            }
        }
    }
}
