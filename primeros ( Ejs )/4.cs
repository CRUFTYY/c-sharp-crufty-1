using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            float n1;
            float n2;
            float n3;
            float n4;
            float n5;
            float r;
            float p;
            //fin de variables 

            //numero 1
            Console.WriteLine("Ingresa el n1");
            n1 = float.Parse(Console.ReadLine());

            //numero 2
            Console.WriteLine("Ingresa el n2");
            n2 = float.Parse(Console.ReadLine());

            //numero 3
            Console.WriteLine("Ingresa el n3");
            n3 = float.Parse(Console.ReadLine());

            //numero 4
            Console.WriteLine("Ingresa el n4");
            n4 = float.Parse(Console.ReadLine());

            //numero 5
            Console.WriteLine("Ingresa el n5");
            n5 = float.Parse(Console.ReadLine());

            //suma
            r = n1 + n2 + n3 + n4 + n5;
            //fin de suma 

            //promedio 
            p = r / 5;
            //fin de promedio

            //mostrar resultado del promedio 
            Console.WriteLine("bro el promedio es " + p);
            //fin de mostrar resultado del promedio

            //esperar tecla 
            Console.ReadKey();
            //fin de esperar tecla 

        }
    }
}