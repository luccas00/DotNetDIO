using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaBibliotecaDeClasses
{
    public class MeuArray<T>
    {
        private static int max = 10;
        private int contador = 0;
        private T[] array = new T[max];

        public void AdicionarElemento(T elemento)
        {
            if(contador + 1 < 11)
            {
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}
