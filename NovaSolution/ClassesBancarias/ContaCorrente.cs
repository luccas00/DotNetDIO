using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ClassesBancarias
{
    public sealed class ContaCorrente : Conta
    {
        public bool? creditoAtivo { get; private set; }
        public List<Investimento> investimentos { get; private set; }
        public ContaPoupanca? poupanca { get; private set; }

        public ContaCorrente() : base()
        {
            creditoAtivo = false;
            investimentos = new List<Investimento>();
            poupanca = new ContaPoupanca(this.idConta);
        }

        public override void Depositar(decimal valor)
        {
            Console.WriteLine($"\nDigite a opção desejada\n1 - Depositar Conta Poupança\n2 - Depositar Conta Corrente\n[-1] - Sair\n");
            string option = Console.ReadLine();
            do
            {
                switch (option)
                {
                    case "-1":
                        break;

                    case "1":
                        this.poupanca.Depositar(valor);
                        break;

                    case "2":
                        this.saldo += valor;
                        break;

                    default:
                        Console.WriteLine("\nInvalido");
                        option = "";
                        break;
                }

            } while (option.Equals("-1"));
        }

        public override void GetExtrato()
        {
            Console.WriteLine($"\n- - - - -\n" +
                $"Conta Corrente\n" +
                $"Saldo R$ {this.saldo}\n" +
                $"Id Conta: {this.idConta}\n" +
                $"Credito Ativo: {this.creditoAtivo}\n");
            this.poupanca.GetExtrato();
            ImprimirTodosInvestimentos();
        }

        public override void Sacar(decimal valor)
        {
            Console.WriteLine($"\nDigite a opção desejada\n1 - Sacar Conta Poupança\n2 - Sacar Conta Corrente\n[-1] - Sair\n");
            string option = Console.ReadLine();
            do
            {
                switch (option)
                {
                    case "-1":
                        break;

                    case "1":
                        this.poupanca.Sacar(valor);
                        break;

                    case "2":
                        this.saldo -= valor;
                        break;

                    default:
                        Console.WriteLine("\nInvalido");
                        option = "";
                        break;
                }

            } while (option.Equals("-1"));
        }
        
        public override string ToString()
        {
            return $"\nConta Corrente" +
                $"Saldo R$ {this.saldo}\n" +
                $"Id Conta: {this.idConta}\n" +
                $"Credito Ativo: {this.creditoAtivo}\n" +
                $"{this.poupanca.ToString}";
                
        }
        public void ImprimirTodosInvestimentos()
        {
            foreach(Investimento i in this.investimentos)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
