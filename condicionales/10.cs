using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
///10. Crear un programa que pida nombre y apellido e indique si coincide con Federico Perez (Solamente realizar con if anidados)
{
    internal class Program           
    {
        static void Main(string[] args)
        {
            ///Variables
            string n;
            string a;
            ///Fin Variables

            ///Se pide nombre y apellido al usuario
            Console.WriteLine("Ingrese un nombre");
            n = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese un apellido");
            a = Convert.ToString(Console.ReadLine());
            ///Fin
            
            ///Se evalua si el nombre y apellido ingresados coinciden con Federico Perez
            if(n == "Federico")
            {
                if (a == "Perez")
                {
                    Console.WriteLine("El nombre y apellido coinciden");
                }
                else
                {
                    Console.WriteLine("El apellido no coincide");
                }
            }
            else
            {
                Console.WriteLine("El nombre ingresado no coincide");
            }
            ///Fin

            Console.ReadKey();
            ///Fin Código
        }
    }
}
