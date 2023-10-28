namespace Biblioteca
{
    public class Class1
    {
        public static double FatorialInterno(double number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * FatorialInterno(number - 1);
            }
        }

    }
}


