using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio15
    {
        public void Ejercicio()
        {
            int[] valores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] inversos = new int[valores.Length];

            int pos = 0;

            for (int i = valores.Length - 1; i >= 0; i--)
            {
                inversos[pos] = valores[i];
                pos++;
            }

        }
    }
}
