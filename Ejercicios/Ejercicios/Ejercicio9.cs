using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio9
    {
        public void Ejercicio()
        {
            int[] vector = new int[10];

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Inserta el valor de la celda {0}", (i + 1));
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
    }
}
