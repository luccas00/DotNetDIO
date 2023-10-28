namespace Common
{
    public class Pessoa
    {
        public string nome { get; private set; }
        public int idade { get; private set; }

        public Pessoa() { }
        public Pessoa(string nome)
        {
            this.nome = nome;
        }
        public Pessoa(int idade)
        {
            this.idade = idade;
        }
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public virtual void Apresentar()
        {
            Console.WriteLine($"\nNome: {this.nome}\nIdade: {this.idade}");
        }

    }





}