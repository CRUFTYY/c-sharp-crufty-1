using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
///9. Crear un programa que pida al usuario un nombre y debe indicar si dicho nombre coincide con Cristian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Variables
            string n;
            ///Fin Variables

            ///Se le pide al usuario un nombre
            Console.WriteLine("Ingrese un nombre");
            n = Convert.ToString(Console.ReadLine());

            ///Se verifica si el nombre ingresado coincide con Cristian
            if(n == "Cristian")
            {
                Console.WriteLine("El nombre coincide");
            }
            else
            {
                Console.WriteLine("El nombre no coincide");
            }
            ///Fin
            
            Console.ReadKey();

        }
    }
}
