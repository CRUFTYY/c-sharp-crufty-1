using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Variables
            int n1;
            int n2;
            ///Fin Variables

            ///Se pide dos numeros enteros al usuario
            Console.WriteLine("Ingrese el primer número entero");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número entero");
            n2 = Convert.ToInt32(Console.ReadLine());

            //primera condicion 
            if (n1 > n2)
            {
                Console.WriteLine("El primer nùmero es mayor");
            }
            //fin de primera condicion 

            //Lazy segunda condicion 
            if (n1 < n2)
            {
                Console.WriteLine("El segundo nùmero es mayor");
            }
            //fin de la segunda condicion 

        }
    }
}
