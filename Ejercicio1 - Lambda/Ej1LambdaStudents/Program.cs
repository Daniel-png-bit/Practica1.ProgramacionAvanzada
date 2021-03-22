using System;


namespace Ejercicio1Lambda
{
    public delegate bool Comparacion(int nota);

    public class Estudiante
    {
        private string nombre;
        private int nota;

        public string Nombre { get; set; }
        public int Nota { get; set; }
    }


    public class Curso
    {
        private Estudiante[] estudiantes = new Estudiante[5];
        public void Cargar(int pos, Estudiante estudiante)
        {
            estudiantes[pos] = estudiante;
        }

        public void MostrarEstudiantes()
        {
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine($"Nombre: {estudiante.Nombre} - Nota: {estudiante.Nota}");
            }
                
        }

        public void MostrarIf(Comparacion comparacion)
        {
            foreach (var estudiante in estudiantes)
            {
                if (comparacion(estudiante.Nota))
                {
                    Console.WriteLine($"Nombre: {estudiante.Nombre} - Nota: {estudiante.Nota}");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Curso c1 = new Curso();
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ingrese el nombre del estudiante #{(i+1)}: ");
                string nameS = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Ingrese la nota del estudiante #{ (i + 1)}: ");
                int notaS = int.Parse(Console.ReadLine());
                c1.Cargar(i, new Estudiante
                {
                    Nombre = nameS,
                    Nota = notaS
                });
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Lista completa de estudiantes.");
            c1.MostrarEstudiantes();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Lista completa de estudiantes con nota mayor o igual a 51.");
            c1.MostrarIf((nota) => nota >= 51);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Lista completa de estudiantes que tienen de nota 50.");
            c1.MostrarIf((nota) => nota == 50);

            Console.ReadKey();
        }
    }
}


