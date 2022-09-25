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
            int num2 = 1;
            int num1 = 1000;
            while (num1 >= num2)
            {
                if (num1 % 2 == 0)
                {
                    Console.Write("Estos son los numeros pares del 1 al 1000: ");
                    Console.WriteLine(num1);
                }
                num1--;
                
            }
        }
    }
}
