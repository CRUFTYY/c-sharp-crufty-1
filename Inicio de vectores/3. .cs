using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
///3. Mostrar la suma de n cantidades de los precios de los productos ingresados por teclado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int cant;
            float total = 0;

            Console.WriteLine("Ingrese la cantidad de productos");
            cant = Convert.ToInt32(Console.ReadLine());
            string[] pro = new string[cant];
            float[] pre = new float[cant];

            for (int i = 0; i < cant; i++)
            {
                {
                    Console.WriteLine("Ingrese el nombre:" + i);
                    pro[i] = Console.ReadLine();

                    Console.WriteLine("Ingrese el precio N°" + i);
                    pre[i] = Convert.ToInt32(Console.ReadLine());

                    total += pre[i];
                }
            }

            Console.WriteLine("La suma de todos los precios es de:");
            Console.WriteLine(total);

            Console.ReadLine();
        }
    }
}
