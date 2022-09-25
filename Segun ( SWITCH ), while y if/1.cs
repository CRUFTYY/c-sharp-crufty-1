using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int men=0;
            int sum=0;
            float n=0;
            float cont = 0;
            while (cont < 10)
            {
                Console.WriteLine("iNGRESA UN NUMERO");
                n = float.Parse(Console.ReadLine());
                if (n > 0)
                {
                    sum = sum + 1;

                }


                if (n < 0)
                {
                    men = men + 1;

                }
                cont = cont + 1;
            }
            Console.WriteLine("Hay " + sum + " numeros mayores a 0 y hay " + men + " Numeros menor a 0");
            Console.ReadKey();
        }
    }
}
