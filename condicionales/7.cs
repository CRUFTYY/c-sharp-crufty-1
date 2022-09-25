using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
///7. Crear un programa que pida al usuario un número entero y diga si es múltiplo de 2 o de 3
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
            
            ///Se evalua si el número es múltiplo de 2 o de 3
            if(n1 % 2 == 0)
            {
                Console.WriteLine("El número es múltiplo de 2");
            }
            else
            {
                Console.WriteLine("El número no es múltiplo de 2");
            }
            if (n1 % 3 == 0)
            {
                Console.WriteLine("El número es múltiplo de 3");
            }
            else
            {
                Console.WriteLine("El número no es múltiplo de 3");
            }
            ///Fin

            Console.ReadKey();
            ///Fin Código
        }
    }
}
