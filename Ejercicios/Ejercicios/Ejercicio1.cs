using System;

namespace Ejercicios
{
	public class Ejercicio1
	{
        public void Ejercicio()
        {
            Console.WriteLine("De que quieres calcular el area?");

			Console.WriteLine("1 = Circulo");
			Console.WriteLine("2 = Cuadrado");
			Console.WriteLine("3 = Triangulo");

			string figura = Console.ReadLine();
			double area = 0;

			switch (figura)
            {
				case "1":
					Console.WriteLine("Define el radio del Circulo");

					string radioString = Console.ReadLine();
					try
                    {
						double radio = Convert.ToDouble(radioString);
						area = CalcularAreaCirculo(radio);
					}
					catch (Exception)
                    {
						Console.WriteLine("No es un radio valido");
                    }
					break;
				case "2":
					Console.WriteLine("Define el lado del Cuadrado");

					string ladoString = Console.ReadLine();

					try
					{
						double lado = Convert.ToDouble(ladoString);
						area = CalcularAreaCuadrado(lado);
					}
					catch (Exception)
					{
						Console.WriteLine("No es un lado valido");
					}
					break;
				case "3":

					Console.WriteLine("Define la base del Triangulo");

					string baseString = Console.ReadLine();

					Console.WriteLine("Define la altura del Triangulo");

					string alturaString = Console.ReadLine();
					try
					{
						double b = Convert.ToDouble(baseString);
						double altura = Convert.ToDouble(alturaString);
						area = CalcularAreaTriangulo(b, altura);
					}
					catch (Exception)
					{
						Console.WriteLine("Base o altura no validas");
					}
					break;

			}
			Console.WriteLine("El area es de {0}", area);
		}
		public double CalcularAreaTriangulo(double b, double altura)
		{
			return  b * altura / 2;
		}
		public double CalcularAreaCirculo(double radio)
		{
			return Math.Pow(radio, 2) * Math.PI;
		}
		public double CalcularAreaCuadrado(double lado)
		{
			return Math.Pow(lado, 2);
		}
	}
}


