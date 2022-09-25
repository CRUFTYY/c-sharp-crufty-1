using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            float m;
            float metros;
            //fin variables 

            //introducir millas 
            Console.WriteLine("Bro Decime la cant de millas bro");
            m = float.Parse(Console.ReadLine());
            metros = m * 1852;
            //introducir millas 

            //te devuelve los metros 
            Console.WriteLine("Bro tu cantidad de metros es " + metros + " bro");
            Console.ReadKey();
            // fin de  te devuelve los metros 
        }
    }
}
