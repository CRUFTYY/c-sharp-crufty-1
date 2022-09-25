using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___suma_de_los_num_que_anteceden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, suma = 0, n, divisor, cont = 0;

            Console.Write("Ingrese un número: ");
            num = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
                suma = suma + i;

            Console.Write("La suma de los números que anteceden a el {0} es {1}\n\n", num, suma);
        }
    }
}
