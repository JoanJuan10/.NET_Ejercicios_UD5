using System;


namespace Ejercicios
{
	public class Ejercicio2
	{
		public void Ejercicio()
		{
			Console.WriteLine("Numero minimo para la generación aleatoria");

			string minimoString = Console.ReadLine();

			Console.WriteLine("Numero maximo para la generación aleatoria");
			

			string maximoString = Console.ReadLine();
			Console.WriteLine();


			try
            {
				int minimo = Convert.ToInt32(minimoString);
				int maximo = Convert.ToInt32(maximoString);
				numAleatorio(minimo, maximo);

			}
			catch (Exception)
            {
				Console.WriteLine("Numeros no validos");
            }

		}
		public int numAleatorio(int min, int max)
        {
			Random r = new Random();
			int cantidadNumeros = r.Next(1, 11);
			int[] numeros = new int[cantidadNumeros];

			for (int i = 0; i < cantidadNumeros; i++)
            {
				numeros[i] = r.Next(min, max + 1);
				Console.WriteLine(numeros[i]);
			}
			Console.WriteLine("Numero elegido: {0}", numeros[r.Next(0, cantidadNumeros)]);
			return 0;
        }
	}
}

