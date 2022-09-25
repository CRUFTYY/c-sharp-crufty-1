using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables 
            float n;
            float r;
            //fin de variables 

            //Pide numero 
            Console.WriteLine("Ingresa un numero");
            n = float.Parse(Console.ReadLine());
            //fin de pide numero 

            //hace la cuenta 
            r = 75 * n / 100;
            //fin de hace la cuenta 


            //resultado 
            Console.WriteLine("el 75% de tu numero es de: " + r);
            //fin de resultado 

            //esperar tecla
            Console.ReadKey();
            //fin de esperar tecla 


        }
    }
}