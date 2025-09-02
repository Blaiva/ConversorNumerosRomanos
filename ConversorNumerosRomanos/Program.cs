using System.Globalization;

namespace ConversorNumerosRomanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca el numero romano a convertir: ");
            char[] numeroRomano = Console.ReadLine().ToUpper().ToCharArray();

            Console.WriteLine(ConvertirRomanoDecimal(numeroRomano));
        }

        public static int ConvertirRomanoDecimal(char[] numeroRomano)
        {
            int numeroDecimal = 0;
            int valor = 0;

            for (int i = 0; i < numeroRomano.Length; i++)
            {
                if ((valor = ValorLetra(numeroRomano[i])) == 0)
                {
                    return 0;
                }

                if(i+1 < numeroRomano.Length && valor < ValorLetra(numeroRomano[i+1]))
                {
                    numeroDecimal -= valor;
                }
                else
                {
                    numeroDecimal += valor;
                }
            }

            return numeroDecimal;
        }

        public static int ValorLetra(char letra)
        {
            switch(letra)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }
    }
}
