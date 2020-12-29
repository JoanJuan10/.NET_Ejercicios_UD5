using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio19
    {
        public void Ejercicio()
        {
            Console.WriteLine("Introduce el tamaño del vector");
            int[] vector = new int[Convert.ToInt32(Console.ReadLine())];

            Console.WriteLine("Introduce el minimo de numero");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el maximo de numero");
            int max = Convert.ToInt32(Console.ReadLine());
            RellenarArray(min, max, vector);
            Console.WriteLine("Numero mas alto: {0}", MayorNumero(vector));

        }
        /*
         * Procedimiento para rellenar el vector
         */
        public int[] RellenarArray(int min, int max, int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                bool colocado = false;
                while (!colocado)
                {
                    int num = NumerosAleatorios(min, max);
                    if (NumeroPrimo(num)) {
                        vector[i] = num;
                        colocado = true;
                    }
                }
            }
            return vector;

        }
        /*
         * Procedimiento para ver si un numero es primo
         */
        public bool NumeroPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        /*
         * Procedimiento para conseguir el numero más alto
         */
        public int MayorNumero (int[] vector)
        {
            int num = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                if (num < vector[i])
                {
                    num = vector[i];
                }
            }
            return num;
        }
        /*
         * Procedimiento para obtener un numero aleatorio
         */
        private int NumerosAleatorios(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max) + 1;
        }
    }
}
