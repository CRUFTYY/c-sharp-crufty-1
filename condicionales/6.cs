using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
///6. Crear un programa que diga si dos números ingresados por el usuario son iguales a 0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Variables
            float n1;
            float n2;
            ///Fin Variables

            ///Se pide al usuario dos numeros
            Console.WriteLine("Ingrese el primer número");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            n2 = float.Parse(Console.ReadLine());
            ///Fin

            ///Se evalua si los números igualados son igual a 0 y los demas casos existentes
            if (n1 == 0 && n2 == 0)
            {
                Console.WriteLine("Ambos números son iguales a 0");
            }
            if (n1 > 0 && n2 == 0)
            {
                Console.WriteLine("El primer número es positivo");
            }
            if (n1 == 0 && n2 > 0)
            {
                Console.WriteLine("El segundo número es positivo");
            }
            if (n1 > 0 && n2 > 0)
            {
                Console.WriteLine("Ambos números son positivos");
            }
            if (n1 < 0 && n2 == 0)
            {
                Console.WriteLine("El primer número es negativo");
            }
            if (n1 == 0 && n2 < 0)
            {
                Console.WriteLine("El segundo número es negativo");
            }
            if (n1 < 0 && n2 < 0)
            {
                Console.WriteLine("Ambos números son negativos");
            }
            if (n1 > 0 && n2 < 0)
            {
                Console.WriteLine("El primer número es positivo y el segundo negativo");
            }
            if (n1 < 0 && n2 > 0)
            {
                Console.WriteLine("El primer número es negativo y el segundo positivo");
            }
            ///Fin

            Console.ReadKey();
            ///Fin Código
        }
    }
}
