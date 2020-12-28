using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio13
    {
        public void Ejercicio()
        {
            Console.WriteLine("Cual es la longitud del vector?");

            int[] vector = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < vector.Length; i++)
            {
                Random r = new Random();

                vector[i] = r.Next(1,11);
            }
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
    }
}
