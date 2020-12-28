using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio3
    {
        public void Ejercicio()
        {
            Console.WriteLine("Introduce un numero");

            string numString = Console.ReadLine();
            int numero = 0;

            try
            {
                numero = Convert.ToInt32(numString);

                if (NumeroPrimo(numero))
                {
                    Console.WriteLine("Es un numero primo");
                }
                else
                {
                    Console.WriteLine("No es un numero primo");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Numero no valido");

            }
            
        }
        public bool NumeroPrimo (int numero)
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
    }
}
