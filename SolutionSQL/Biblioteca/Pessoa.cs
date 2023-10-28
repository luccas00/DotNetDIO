using System;
using Newtonsoft.Json;

namespace Biblioteca
{
    public abstract class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        public Pessoa(string nome)
        {
            this.nome = nome;
            this.idade = 0;
        }
        public abstract void GetInfo();

    }
}


