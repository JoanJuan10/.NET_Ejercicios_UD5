using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Ejercicio5
    {
        public void Ejercicio()
        {
            Console.WriteLine("Introduce un numero");

            string numeroString = Console.ReadLine();
            int numero = Convert.ToInt32(numeroString);

            string binario = ConvertidorBinario(numero);

            Console.WriteLine("Codigo binario resultante: {0}", binario);


        }
        public string ConvertidorBinario(int numero)
        {
            int[] numeros = new int[100];
            int pos = 0;
            string binario = "";


            while (numero != 1)
            {
                numeros[pos] = numero % 2;
                numero = numero / 2;
                pos++;
            }
            for (int i = pos - 1; i >= 0; i--)
            {
                binario = binario + "" + numeros[i];
            }
            return binario;
        }
    }
}
