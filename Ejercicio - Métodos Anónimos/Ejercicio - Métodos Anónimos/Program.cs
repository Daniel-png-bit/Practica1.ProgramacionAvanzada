using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio___Métodos_Anónimos
{
    class Program
    {


        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();

            Random rnd = new Random();

            op.numeros += delegate ()
            {
                for (int i = 0; i < op.Num.Length; i++)
                {
                    op.Num[i] = rnd.Next(0, 100);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"La posición {i} del arreglo es: {op.Num[i]}");
                }
            };

            op.numeros += delegate ()
            {
                double prom = 0;
                for (int i = 0; i < op.Num.Length; i++)
                {
                    prom += op.Num[i];
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nEl promedio del arreglo es: {prom / op.Num.Length}");
            };

            op.numeros();

            Console.ReadLine();
        }
    }
}
