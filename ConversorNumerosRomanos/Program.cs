using System.Globalization;

namespace ConversorNumerosRomanos
{
    internal class Program
    {
        static Dictionary<char, int> VALORES_LETRAS = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        static void Main(string[] args)
        {
            Console.Write("Introduzca el numero romano a convertir: ");
            string numeroRomano = Console.ReadLine().ToUpper();

            if (esNumeroRomanoValido(numeroRomano))
            {
                Console.WriteLine(ConvertirRomanoDecimal(numeroRomano));
            }
            else
            {
                Console.WriteLine("El numero ingresado no es un numero romano valido");
            }
        }

        private static int ConvertirRomanoDecimal(string numeroRomano)
        {
            int numeroDecimal = 0;
            int valor = 0;

            for (int i = 0; i < numeroRomano.Length; i++)
            {
                valor = VALORES_LETRAS[numeroRomano[i]];

                if (i + 1 < numeroRomano.Length && valor < VALORES_LETRAS[numeroRomano[i + 1]])
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

        private static bool esNumeroRomanoValido(string numeroRomano)
        {
            foreach(char letra in numeroRomano)
            {
                if(!VALORES_LETRAS.ContainsKey(letra))
                {
                    return false;
                }
            }

            if (numeroRomano.Contains("IIII") || numeroRomano.Contains("XXXX") || numeroRomano.Contains("CCCC") || numeroRomano.Contains("MMMM"))
            {
                return false;
            }

            if (numeroRomano.Contains("VV") || numeroRomano.Contains("LL") || numeroRomano.Contains("DD"))
            {
                return false;
            }

            return true;
        }
    }
}