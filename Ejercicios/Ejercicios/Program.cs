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
                case "2":
                    Ejercicio2 ej2 = new Ejercicio2();
                    ej2.Ejercicio();
                    break;
                case "3":
                    Ejercicio3 ej3 = new Ejercicio3();
                    ej3.Ejercicio();
                    break;
                case "4":
                    Ejercicio4 ej4 = new Ejercicio4();
                    ej4.Ejercicio();
                    break;
                case "5":
                    Ejercicio5 ej5 = new Ejercicio5();
                    ej5.Ejercicio();
                    break;
                case "6":
                    Ejercicio6 ej6 = new Ejercicio6();
                    ej6.Ejercicio();
                    break;
                case "7":
                    Ejercicio7 ej7 = new Ejercicio7();
                    ej7.Ejercicio();
                    break;
                case "8":
                    Ejercicio8 ej8 = new Ejercicio8();
                    ej8.Ejercicio();
                    break;
                case "9":
                    Ejercicio9 ej9 = new Ejercicio9();
                    ej9.Ejercicio();
                    break;
                case "10":
                    Ejercicio10 ej10 = new Ejercicio10();
                    ej10.Ejercicio();
                    break;
                case "11":
                    Ejercicio11 ej11 = new Ejercicio11();
                    ej11.Ejercicio();
                    break;
                case "12":
                    Ejercicio12 ej12 = new Ejercicio12();
                    ej12.Ejercicio();
                    break;
                case "13":
                    Ejercicio13 ej13 = new Ejercicio13();
                    ej13.Ejercicio();
                    break;
                case "14":
                    Ejercicio14 ej14 = new Ejercicio14();
                    ej14.Ejercicio();
                    break;
                case "15":
                    Ejercicio15 ej15 = new Ejercicio15();
                    ej15.Ejercicio();
                    break;
                case "16":
                    Ejercicio16 ej16 = new Ejercicio16();
                    ej16.Ejercicio();
                    break;
                case "17":
                    Ejercicio17 ej17 = new Ejercicio17();
                    ej17.Ejercicio();
                    break;
                case "18":
                    Ejercicio18 ej18 = new Ejercicio18();
                    ej18.Ejercicio();
                    break;
                case "19":
                    Ejercicio19 ej19 = new Ejercicio19();
                    ej19.Ejercicio();
                    break;
                case "20":
                    Ejercicio20 ej20 = new Ejercicio20();
                    ej20.Ejercicio();
                    break;
                case "21":
                    Ejercicio21 ej21 = new Ejercicio21();
                    ej21.Ejercicio();
                    break;

            }
        }
    }
}
