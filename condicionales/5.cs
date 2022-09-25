using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
///5. Crear un programa que pida dos números enteros y diga si el primero es multiplo del segundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Variables
            int n1;
            int n2;
            ///Fin Variables

            ///Se pide al usuario dos números enteros
            Console.WriteLine("Ingrese el primer número entero");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número entero");
            n2 = Convert.ToInt32(Console.ReadLine());
            ///Fin

            ///Se calcula si el primer número4 es múltiplo del segundo
            if (n2 % n1 == 0)
            {
                Console.WriteLine("El primer número es múltiplo");
            }
            else

            {
                Console.WriteLine("El primer número no es múltiplo");
            }
            ///Fin
            
            Console.ReadKey();
            ///Fin Código
        }
    }
}
