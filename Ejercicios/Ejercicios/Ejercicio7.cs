using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio7
    {
        public void Ejercicio ()
        {
            Console.WriteLine("Introduce la cantidad en euros");

            string eurosString = Console.ReadLine();
            double euros = Convert.ToDouble(eurosString);

            Console.WriteLine("En que moneda quieres convertir los euros?");

            Console.WriteLine("1 - Libras");
            Console.WriteLine("2 - Dolares");
            Console.WriteLine("3 - Yenes");

            string monedaString = Console.ReadLine();

            int moneda = Convert.ToInt32(monedaString);

            ConvertirMoneda(euros, moneda);

        }

        public void ConvertirMoneda (double euros, int moneda)
        {
            switch (moneda)
            {
                case 1: Console.WriteLine("En Libras: {0}", euros * 0.86);
                    break;
                case 2:
                    Console.WriteLine("En Dolares: {0}", euros * 1.28611);
                    break;
                case 3:
                    Console.WriteLine("En Yenes: {0}", euros * 129.852);
                    break;
            }
        }
    }
}
