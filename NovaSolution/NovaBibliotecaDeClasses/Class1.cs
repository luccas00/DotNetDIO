using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace NovaBibliotecaDeClasses
{
    /// <summary>
    /// Classe de treinamento dotNet DIO
    /// </summary>
    public class Class1
    {

        public int? number;
        public string? name;
        public int? age;
        public decimal? price;
        public string? description;
        public string? id;
        public DateTime? data;

        [JsonProperty("Nome_Teste")]
        public string? teste;

        /// <summary>
        /// Metodo Construtor Vazio
        /// </summary>
        public Class1(int number, string name, int age, decimal price, string description, string id)
        {
            this.number = number;
            this.name = name;
            this.age = age;
            this.price = price;
            this.description = description;
            this.id = id;
            DateTime data = DateTime.Now;
        }

        public Class1()
        {

        }

        public void Deconstruct(out int? _Result, out string _Nome)
        {
            _Result = number+100;
            _Nome = "Deconstruct";
        }

        public override string ToString()
        {
            return $"- - - - - - -\n" +
                $"Nome: {this.name}\n" +
                $"Valor: {this.price}\n" +
                $"Id: {this.id}\n" +
                $"Descrição: {this.description}\n" +
                $"Number: {this.number}\n" +
                $"Age: {this.age}\n" +
                $"Data: {this.data}\n" +
                $"Teste_ {this.teste}\n";
        }

        /// <summary>
        /// Realiza uma Soma de dois Numeros
        /// </summary>
        /// <param name="x">Primeiro Numero Inteiro</param>
        /// <param name="y">Segundo Numero Inteiro</param>
        /// <returns>Numero Inteiro</returns>
        public int Somar(int x, int y)
        {
            return x+y;
        }

    }
}

