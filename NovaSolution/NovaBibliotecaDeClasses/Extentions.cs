using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaBibliotecaDeClasses
{
    public static class Extentions
    {
        public static bool EhPar(this int number)
        {
            return number % 2 == 0;
        }
        public static bool EhLuccas(this string linha)
        {
            return linha.Equals("Luccas");
        }

        public static bool EhEscolhido(this Class1 obj)
        {
            if(obj == null)
                return false;

            if(obj.name.Equals("Luccas") && obj.id.Equals("000") && obj.price == 0)
                return true;


            return false;
        }

    }
}
