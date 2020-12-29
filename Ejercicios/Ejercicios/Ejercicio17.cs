using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio17
    {
        public void Ejercicio ()
        {
            int[] vector = new int[10];

            vector = RellenarValores(vector);
            MostrarValores(vector);
        }
        public int[] RellenarValores (int[] vector)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Introduce el valor de la posicion {0}", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            return vector;
            
        }
        public void MostrarValores (int[] vector)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Posicion {0} - Valor {1}", i, vector[i]);
            }
        }
    }
}
