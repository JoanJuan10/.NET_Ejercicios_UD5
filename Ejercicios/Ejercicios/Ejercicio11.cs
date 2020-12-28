using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio11
    {
        public void Ejercicio()
        {
            int[] vector = new int[10];

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = i;
            }
            int suma = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];
            }
            Console.WriteLine("Suma total: {0}", suma);
        }
    }
}
