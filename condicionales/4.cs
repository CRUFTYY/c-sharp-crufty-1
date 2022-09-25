using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_2
///4. Crear un programa que pida al usuario tres números enteros y diga cual es el mayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Variables
            int n1;
            int n2;
            int n3;
            ///Fin Variables

            ///Se pide al usuario tres números enteros
            Console.WriteLine("Ingrese el primer número");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número");
            n3 = Convert.ToInt32(Console.ReadLine());
            ///Fin

            ///Se calcula el mayor de los números ingresados
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("El primer número es mayor");
            }
            if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("El segundo número es mayor");
            }
            if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine("El tercer número es mayor");
            }
            ///Fin

            Console.ReadKey();
            ///Fin Código
        }
    }
}
