using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
    ///Ejercicios con estructura if
    ///1. Crear un programa que pida un número al usuario. Si es positivo, escribir en pantalla "el número es positivo" o si es negativo o 0 no hace nada 
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Variables
            float n;
            ///Fin Variables
            
            ///Se pide y guarda un número
            Console.WriteLine("Ingrese un numero");
            n = float.Parse(Console.ReadLine());

            ///Si el número es positivo se muestra un mensaje. De otro modo no se hace nada
            if(n > 0){
                Console.WriteLine("El número ingresado es positivo");
            }
            Console.ReadKey();
        
        }
    }
}
