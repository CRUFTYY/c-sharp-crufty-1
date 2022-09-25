using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
///4. Crear un programa que me permita ingresar una x cantidad de pesos y que me indique cuantas personas pesan más y cuantas menos de 80kg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;
            int p = 0;
            int ma = 0;
            int men = 0;


            Console.WriteLine("Ingrese la cantidad de pesos");
            cant = Convert.ToInt32(Console.ReadLine());

            for(int c = 0; c <= cant; c++)
            {

                Console.WriteLine("Ingrese el peso N°: " + c);
                p = Convert.ToInt32(Console.ReadLine());

                if(p > 80)
                {
                    ma = ma + 1;
                }

                else
                {
                    men = men + 1;
                }

            }

            Console.WriteLine("Las personas mayores a 80kg son: " + ma);
            Console.WriteLine("Las personas menores a 80kg son: " + men);
            Console.ReadLine();
        }
    }
}
