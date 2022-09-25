using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables 
            float resto;
            float n1;
            float n2;
            //fin de variables 

             n1 = 301;
             n2 = 3;

            //Muestra de el resto 
            resto = n1 % n2;
            Console.WriteLine("El resto es :" + resto);

            //esperar tecla 
            Console.ReadKey();
            //fin de esperar tecla

        }
    }
}
