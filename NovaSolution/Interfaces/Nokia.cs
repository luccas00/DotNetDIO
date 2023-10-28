using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Nokia : Telefone
    {
        internal string app1;
        internal string app2;
        internal string app3;

        public Nokia(string numero, string modelo) : base(numero, modelo, 32)
        {
            app1 = string.Empty;
            app2 = string.Empty;
            app3 = string.Empty;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"\n- - - - -\n" +
                $"Nokia\n" +
                $"Numero: {this.Numero}\n" +
                $"IMEI: {this.IMEI}\n" +
                $"Modelo: {this.Modelo}\n" +
                $"Memoria: {this.Memoria}\n" +
                $"- Aplicativos -\n" +
                $"App1: {this.app1}\n" +
                $"App2: {this.app2}\n" +
                $"App3: {this.app3}\n");
        }

        public override void InstalarAplicativo(string app)
        {
            if (this.app1.Equals(string.Empty))
            {
                app1 = app;
            }
            else if (app2.Equals(string.Empty))
            {
                app2 = app;
            }
            else if (app3.Equals(string.Empty))
            {
                app3 = app;
            }
            else
            {
                Console.WriteLine("Memoria cheia, apague algum aplicativo...");
            }
        }
    }
}
