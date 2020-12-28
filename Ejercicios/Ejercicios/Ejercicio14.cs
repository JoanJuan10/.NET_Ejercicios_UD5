using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio14
    {
        public void Ejercicio()
        {
            Console.WriteLine("Cual es la longitud del vector?");

            int[] vector = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < vector.Length; i++)
            {
                Random r = new Random();

                vector[i] = r.Next(1, 11);
            }
            if (EncontrarNumero(vector))
            {
                Console.WriteLine("El numero esta en la lista");
            }
            else
            {
                Console.WriteLine("El numero no esta en la lista");
            }
            
        }
        public bool EncontrarNumero (int[] vector)
        {
            Console.WriteLine("Cual es tu numero a buscar?");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < vector.Length; i++)
            {
                if (numero == vector[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
