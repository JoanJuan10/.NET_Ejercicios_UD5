using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio12
    {
        public void Ejercicio()
        {
            int[] vector = new int[10];

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = i;
            }
            double media = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                media += vector[i];
            }
            media /= vector.Length; 
            Console.WriteLine("Media total: {0}", media);
        }
    }
}
