using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio16
    {
        public void Ejercicio ()
        {
            int[] numeros1 = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
            int[] numeros2 = { 1, 2, 3, 4, 5, 5, 4, 3, 2, 1 };

            if (ComprobarCapicua(numeros2))
            {
                Console.WriteLine("Es capicua");
            }
            else
            {
                Console.WriteLine("No es capicua");
            }

        }
        public bool ComprobarCapicua (int[] vector)
        {
            int contador1, contador2;
            if (vector.Length % 2 == 0)
            {
                contador1 = (vector.Length / 2) - 1;
                contador2 = (vector.Length / 2);
            }
            else
            {
                contador1 = vector.Length / 2 - 1;
                contador2 = vector.Length / 2 + 1;
            }
            for (int i = contador1; i >= 0; i--)
            {
                if (vector[i] != vector[contador2])
                {
                    return false;
                }
                contador2++;
            }
            return true;
        }
    }
}
