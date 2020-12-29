using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio20
    {
        public void Ejercicio()
        {
            Console.WriteLine("Introduce el tamaño del array");
            int medida = Convert.ToInt32(Console.ReadLine());

            int[] num1 = new int[medida];

            for (int i = 0; i < num1.Length; i++)
            {
                num1[i] = NumerosAleatorios(1, 10);
            }

            int[] num2 = num1;

            int[] num3 = new int[num1.Length];

            for (int i = 0; i < num1.Length; i++)
            {
                num3[i] = NumerosAleatorios(1, 10);
            }
            int[] multiplicado = MultiplicacionVector(num1, num2);

            Console.WriteLine("Vector 1:");
            MostrarContenido(num1);

            Console.WriteLine("Vector 2:");
            MostrarContenido(num2);

            Console.WriteLine("Vector 3:");
            MostrarContenido(num3);

            Console.WriteLine("Vector Multiplicado:");
            MostrarContenido(multiplicado);


        }
        /*
         * Procedimiento para obtener un numero aleatorio
         */
        private int NumerosAleatorios(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max) + 1;
        }
        public int[] MultiplicacionVector (int[] num1, int[] num2)
        {
            int[] multiplicado = new int[num1.Length];
            for (int i = 0; i < num1.Length; i++)
            {
                multiplicado[i] = num1[i] * num2[i];
            }
            return multiplicado;
        }
        public void MostrarContenido(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Posicion {0} - Valor {1}", i, vector[i]);
            }
        }
    }
}
