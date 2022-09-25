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
            int[] sal = new int[6];
            string[] nom = new string[6];
            int msal = 0;
            string mnom = "";

            for (int i = 1; i < 6; i++) 
            {

                Console.WriteLine("Ingrese el nombre del operario Nº: " + i);
                nom[i] = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Ingrese el salario del operario Nº: " + i);
                sal[i] = Convert.ToInt32(Console.ReadLine());

                if (sal[i] > sal[i - 1])
                {
                    mnom = nom[i];
                    msal = sal[i];
                }
            }

            Console.Clear();
            Console.WriteLine("El operario con mayor sueldo es: " + mnom + ", con un salario de: " + msal);
            Console.ReadLine();
        }
    }
}
