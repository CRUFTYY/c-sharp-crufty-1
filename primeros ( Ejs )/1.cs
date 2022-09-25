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
            //variables 
            float n1;
            float n2;
            float resto;
            float res;
            //fin de variables

            //Primero numero 
            Console.WriteLine("Decime el primer numero : ");
            n1 = float.Parse(Console.ReadLine());
            //fin de primer numero 

            //Segundo numero 
            Console.WriteLine("Decime el segundo numero : ");
            n2 = float.Parse(Console.ReadLine());
            //fin de segundo  numero 

            //hace las cuentas 
            res = n1 / n2;
            resto = n1 % n2;
            //fin de hace las cuentas 

            //Muestra de los resultados 
            Console.WriteLine("El resultad de la division es : " + res);
            Console.WriteLine("El resto es: " + resto);
            //fin de Muestra de los resultados 


            //esperar tecla 
            Console.ReadKey();
        }
    }
}
