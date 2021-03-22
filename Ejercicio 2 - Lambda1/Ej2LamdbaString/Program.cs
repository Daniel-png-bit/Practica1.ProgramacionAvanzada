using System;

namespace Ejercicio2_Lambda
{
    delegate bool CadenaDelegado(char caracter);

    class Program
    {
        public static string Filtrar(string cadena, CadenaDelegado del)
        {
            string fraseCadena = "";
            foreach (var caracter in cadena)
                if (del(caracter))
                    fraseCadena += caracter;
            return fraseCadena.ToString();
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Ingrese una frase: ");
            var cadena = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Cadena: " + cadena);
            var vocales = Program.Filtrar(cadena, caracter => caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u' ||
                                          caracter == 'A' || caracter == 'E' || caracter == 'I' || caracter == 'O' || caracter == 'U');
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"La frase tiene como vocales: {vocales}");

            var dig = Program.Filtrar(cadena, caracter => char.IsDigit(caracter));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"La frase tiene como dígitos: {dig}");

            var caracMin = Program.Filtrar(cadena, caracter => char.IsLower(caracter));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"La frase tiene como carácteres minúsculas: {caracMin}");

            var caracNum = Program.Filtrar(cadena, caracter => char.IsLetter(caracter) || char.IsNumber(caracter));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("La frase tiene como carácteres y números: " + caracNum);
            Console.ReadLine();
        }
    }
}
