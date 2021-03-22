using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio___Métodos_Anónimos
{
    class Operaciones
    {
        public delegate void DelNumeros();

        public DelNumeros numeros;

        private int[] num = new int[10];

        public int[] Num {get { return num; } set { num = value; } }

    }
}
