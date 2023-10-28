using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ClassesBancarias
{
    public abstract class Conta
    {
        public decimal saldo { get; protected set; }
        public string? idConta { get; protected set; }

        public abstract void Depositar(decimal valor);
        public abstract void Sacar(decimal valor);
        public abstract void GetExtrato();

        public Conta()
        {
            this.idConta = Guid.NewGuid().ToString().ToUpper();
            this.saldo = 0;
        }
        internal Conta(string id)
        {
            this.idConta = id;
            this.saldo = 0;
        }
        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"\n- - -\nExibindo Saldo Base\nConta Nº: {this.idConta}\nSaldo R${this.saldo}");
        }


    }
}
