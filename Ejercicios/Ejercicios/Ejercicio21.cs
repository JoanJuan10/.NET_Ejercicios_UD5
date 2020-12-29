using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio21
    {
        public void Ejercicio()
        {
            Console.WriteLine("Introduce el tamaño del vector");
            int[] num = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = NumerosAleatorios(1, 300);
            }

            int[] terminaciones = TerminacionNumeros(num);
            Console.WriteLine("Numeros coincientes:");
            for (int i = 0; i < num.Length; i++)
            {
                if (terminaciones[i] != 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            
        }
        /*
         * Procedimiento para obtener un numero aleatorio
         */
        private int NumerosAleatorios(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max) + 1;
        }
        public int[] TerminacionNumeros ( int[] vector)
        {
            bool correcto = false;
            int[] terminaciones = new int[vector.Length];
            int terminacion = 0;
            while (!correcto)
            {
                Console.WriteLine("Introduce con que debe terminar el numero para ser mostrado");
                terminacion = Convert.ToInt32(Console.ReadLine());
                if (terminacion < 10 && terminacion >= 0)
                {
                    correcto = true;
                }
                else
                {
                    Console.WriteLine("El numero es más grande de 10 o es negativo!");
                }
            }
            int pos = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                string numeroString = vector[i].ToString();
                int terminacionNumero = Convert.ToInt32(numeroString.Substring(numeroString.Length - 1));
                if (terminacion == terminacionNumero)
                {
                    terminaciones[pos] = vector[i];
                    pos++;
                }
            }
            return terminaciones;
        }
    }
}
