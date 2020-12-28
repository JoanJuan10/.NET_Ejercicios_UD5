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
			int genRand = r.Next(min, max);
			return 0;
        }
	}
}

