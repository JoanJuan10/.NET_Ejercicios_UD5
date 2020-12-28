using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio6
    {
        public void Ejercicio ()
        {
            Console.WriteLine("Introduce un numero positivo");

            string numeroString = Console.ReadLine();

            try
            {
                uint numero = Convert.ToUInt32(numeroString);
                Console.WriteLine("El numero de cifras es de: {0}", NumeroCifras(numero));
            }
            catch (Exception)
            {
                Console.WriteLine("El numero no es valido o es un numero negativo");
            }
        }

        public int NumeroCifras (uint numero)
        {
            int cifras = 0;
            while (numero >= 1)
            {
                numero = numero / 10;
                cifras++;
            }
            return cifras;
        }
    }
}
