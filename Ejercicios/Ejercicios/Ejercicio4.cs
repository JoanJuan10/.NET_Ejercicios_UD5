using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio4
    {
        public void Ejercicio()
        {
            Console.WriteLine("Introduce un numero");

            string numeroString = Console.ReadLine();

            try
            {
                int numero = Convert.ToInt32(numeroString);
                Console.WriteLine("Factorial de {0} es {1}", numero, CalcularFactorial(numero));


            }
            catch (Exception)
            {
                Console.WriteLine("Numero invalido");
            }
        }
        public int CalcularFactorial (int numero)
        {
            int resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
