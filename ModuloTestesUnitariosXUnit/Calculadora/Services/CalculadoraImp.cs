using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int somar(int a, int b)
        {
            return a + b;
        }

        public int multiplicar(int a, int b)
        {
            return a * b;
        }

        public bool EhPar(int a)
        {
            if(a % 2 == 0)
                return true;

            return false;
        }
    }
}
