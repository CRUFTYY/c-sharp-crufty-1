using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pesos;

            Console.WriteLine("Ingrese la cantidad de pesos a convertir ");
            pesos = int.Parse(Console.ReadLine());

            Console.WriteLine("Dolar (blue): " + (pesos * 280));

            Console.WriteLine("Euros       : " + (pesos * 141));

            Console.WriteLine("Bitcoin     : " + (pesos * 27211188));

            Console.WriteLine("Merval      : " + (pesos * 141509));

            Console.WriteLine("Ethereum    : " + (pesos * 229859));

            Console.WriteLine("Reales      : " + (pesos * 27));

            Console.WriteLine("Soles       : " + (pesos * 36));

            Console.WriteLine("Libras      : " + (pesos * 162));

            Console.WriteLine("");
        }
    }
}
