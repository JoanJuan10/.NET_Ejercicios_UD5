using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio10
    {
        public void Ejercicio ()
        {
            Console.WriteLine("Introduce un numero");

            string numeroString = Console.ReadLine();

            int numero = Convert.ToInt32(numeroString);
            GeneradorTabla(numero);
        }
        public void GeneradorTabla (int numero)
        {
            Console.WriteLine("Tabla del {0}", numero);
            Console.WriteLine();
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", numero, i, (numero * i));
            }
        }
    }
}
