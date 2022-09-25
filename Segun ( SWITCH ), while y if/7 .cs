using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            int num1 = int.Parse(Console.ReadLine());

            while (num1 >= num2)
            {
                if (num1 % 2 == 0)
                {
                    Console.Write("Estos son los numeros pares: ");
                    Console.WriteLine(num1);
                }
                num1--;
            }
        }
    }
}
