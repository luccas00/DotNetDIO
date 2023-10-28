 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ClassesBancarias
{
    public sealed class ContaPoupanca : Conta
    {
        public static decimal Aliquota = 0.03M;
        public ContaPoupanca() { }
        internal ContaPoupanca(string id) : base(id) { }

        public ContaPoupanca(decimal saldoInicial)
        {
            this.saldo = saldoInicial;
        }

        public override void Depositar(decimal valor)
        {
            this.saldo += valor;
        }

        public override void GetExtrato()
        {
            Console.WriteLine($"\n- - - - -\n" +
                $"Conta Poupança\n" +
                $"Saldo R$ {this.saldo}\n" +
                $"Id Conta: {this.idConta}\n" +
                $"Aliquota Anual {Aliquota*100}%");
        }

        public override void Sacar(decimal valor)
        {
            this.saldo -= valor;
        }

        public override string ToString()
        {
            return $"\nConta Poupança" +
                $"Saldo R$ {this.saldo}\n" +
                $"Id Conta: {this.idConta}\n" +
                $"Aliquota: {Aliquota}";
        }
    }
}
