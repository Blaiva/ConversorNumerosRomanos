using System.Globalization;

namespace ConversorNumerosRomanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca el numero romano a convertir: ");
            char[] numeroRomano = Console.ReadLine().ToUpper().ToCharArray();

            Console.WriteLine(ConvertirRomanoEntero(numeroRomano));
        }

        public static double ConvertirRomanoEntero(char[] numeroRomano)
        {
            double numeroEntero = 0;
            for(int i = 0; i < numeroRomano.Length; i++)
            {
                if(numeroRomano[i].Equals('I'))
                {
                    if (i + 1 < numeroRomano.Length && numeroRomano[i+1].Equals('V'))
                    {
                        numeroEntero += 4;
                        i++;
                        continue;
                    }
                    numeroEntero++;
                }
            }

            return numeroEntero;
        }


    }
}
