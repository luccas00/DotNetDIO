using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Apple : Telefone
    {
        internal List<string> Aplicativos;

        public Apple(string numero, string modelo, int memoria) : base(numero, modelo, memoria)
        {
            Aplicativos = new List<string>();
        }
        public override void GetInfo()
        {
            int contador = 1;
            Console.WriteLine($"\n- - - - -\n" +
                $"Apple\n" +
                $"Numero: {this.Numero}\n" +
                $"IMEI: {this.IMEI}\n" +
                $"Modelo: {this.Modelo}\n" +
                $"Memoria: {this.Memoria}\n" +
                $"- Aplicativos -\n");
            foreach(string s in Aplicativos)
            {
                Console.WriteLine($"App {contador} - {s}");
                contador++;
            }
        }
        public override void InstalarAplicativo(string app)
        {
            Aplicativos.Add(app);
        }
    }
}
