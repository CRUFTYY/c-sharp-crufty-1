using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("Elija un numero del 1 al 5");


            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            switch (Console.ReadLine())

            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Este es el numero Uno");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Este es el numero Dos");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Este es el numero Tres");
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Este es el numero Cuatro");
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Este es el numero Cinco");1
                    break;
                default:

                    Console.Clear();
                    Console.WriteLine("Este es un numero mayor Cinco");

                    break;
            }

            Console.WriteLine("Toque cualquier letra para cerrar el programa...");
            Console.ReadKey();
            

        }
    }
}
