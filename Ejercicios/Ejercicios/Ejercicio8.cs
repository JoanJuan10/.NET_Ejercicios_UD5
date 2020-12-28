using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio8
    {
        public void Ejercicio ()
        {
            int[] vector = new int[10];

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = i;
            }
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
    }
}
