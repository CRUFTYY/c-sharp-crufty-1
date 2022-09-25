using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            string p1;
            string p2;
            string o;
            //fin de variables 

            //Palabra 1 
            Console.WriteLine("bro Ingresa la palbra 1 bro");
            p1 = Convert.ToString(Console.ReadLine());
            //fin de palabra 1

            //Palabra 2
            Console.WriteLine("bro Ingresa la palbra 2 bro");
            p2 = Convert.ToString(Console.ReadLine());
            //fin de palabra 2

            //juntar las dos palabras 
            o = (p1 + " " + p2);
            //fin de juntar las dos palabras

            //aca lee la linea que es "o = (p1 + \" \" + p2);"
            Console.WriteLine(o);
            //fin  de leer la linea 

            //esperar tecla 
            Console.ReadKey();
            //fin de esperar tecla 
        }
    }
}
