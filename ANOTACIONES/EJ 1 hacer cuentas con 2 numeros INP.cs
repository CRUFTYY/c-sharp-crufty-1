using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1;
            float n2;

            float resultado1;

            float resultado2;

            float resultado3;

            float resultado4;


            n1 = float.Parse(Console.ReadLine());
            n2 = float.Parse(Console.ReadLine());

            resultado1 = (n1 + n2);

            resultado2 = (n1 - n2);

            resultado3 = (n1 / n2);

            resultado4 = (n1 * n2);

            Console.WriteLine("La suma es : " + resultado1);

            Console.WriteLine("La suma es : " + resultado2);

            Console.WriteLine("La suma es : " + resultado3);

            Console.WriteLine("La suma es : " + resultado4);

            Console.ReadKey();
            
        }
    }
}
