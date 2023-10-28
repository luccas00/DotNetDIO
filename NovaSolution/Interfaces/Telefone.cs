using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Telefone
    {
        internal string Numero { get; set; }
        internal string Modelo { get; private set; }
        internal string IMEI { get; private set; }
        internal int Memoria { get; private set; }

        internal Telefone(string numero, string modelo, int memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.Memoria = memoria;
            this.IMEI = Guid.NewGuid().ToString().ToUpper();
        }

        public abstract void InstalarAplicativo(string app);

        public abstract void GetInfo();

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
    
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo Ligacao..."); ;
        }
    }
}
