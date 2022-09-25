using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
///8. Crear un programa que pida al usuario un número entero y diga si es múltiplo de 2 y de 3 al mismo tiempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Variables
            int n1;
            ///Fin Variables

            ///Se pide un número entero al usuario
            Console.WriteLine("Ingrese un número entero");
            n1 = Convert.ToInt32(Console.ReadLine());
            ///Fin
            
            ///Se evalua si el número es múltiplo de 2 y de 3 al mismo tiempo
            if (n1 % 2 == 0 && n1 % 3 == 0)
            {
                Console.WriteLine("El número es múltiplo de 2 y de 3 al mismo tiempo");
            }
            else
            {
                Console.WriteLine("El número no es múltiplo de 2 y de 3 al mismo tiempo");
            }
            ///Fin
            
            Console.ReadKey();
            ///Fin Código
        }
    }
}
