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
            ///Variables
            int n;
            ///Fin Variables

            ///Se pide y recibe un número entero al usuario
            Console.WriteLine("Ingrese un número entero");
            n = Convert.ToInt32(Console.ReadLine());
            ///Fin

            ///Si el número es par se muestra un mensaje. De otro modo no pasa nada
            if (n % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            Console.ReadKey();
            ///Fin Código
        }
    }
}
