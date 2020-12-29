using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio18
    {
        public void Ejercicio ()
        {
            Console.WriteLine("Introduce el tamaño del vector");
            int[] vector = new int[Convert.ToInt32(Console.ReadLine())];

            RellenarArray(0, 9, vector);
            MostrarContenidoYSuma(vector);

        }
        public int[] RellenarArray(int min, int max, int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = NumerosAleatorios(0, 9);
            }
            return vector;

        }
        public void MostrarContenidoYSuma (int[] vector)
        {
            int suma = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Posicion {0} - Valor {1}", i, vector[i]);
                suma += vector[i];
            }
            Console.WriteLine("Suma dels valors: {0}", suma);
        }
        private int NumerosAleatorios(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max) + 1;
        }
    }
}
