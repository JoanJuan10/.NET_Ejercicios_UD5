﻿using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que ejercicio quieres ejecutar?");

            Console.WriteLine("1 = Ejercicio 1");
            Console.WriteLine("2 = Ejercicio 2");
            Console.WriteLine("3 = Ejercicio 3");
            Console.WriteLine("4 = Ejercicio 4");
            Console.WriteLine("5 = Ejercicio 5");
            Console.WriteLine("6 = Ejercicio 6");
            Console.WriteLine("7 = Ejercicio 7");
            Console.WriteLine("8 = Ejercicio 8");
            Console.WriteLine("9 = Ejercicio 9");
            Console.WriteLine("10 = Ejercicio 10");
            Console.WriteLine("11 = Ejercicio 11");
            Console.WriteLine("12 = Ejercicio 12");
            Console.WriteLine("13 = Ejercicio 13");
            Console.WriteLine("14 = Ejercicio 14");
            Console.WriteLine("15 = Ejercicio 15");
            Console.WriteLine("16 = Ejercicio 16");
            Console.WriteLine("17 = Ejercicio 17");
            Console.WriteLine("18 = Ejercicio 18");
            Console.WriteLine("19 = Ejercicio 19");
            Console.WriteLine("20 = Ejercicio 20");
            Console.WriteLine("21 = Ejercicio 21");


            string ejercicio = Console.ReadLine();

            switch (ejercicio)
            {
                case "1":
                    Ejercicio1 ej1 = new Ejercicio1();
                    ej1.Ejercicio();
                    break;

            }
        }
    }
}
