using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = "?";
            string ape = "?";
            string dni = "?";
            int telefono = 0;
            int op = 0;

            do
            {
                Console.WriteLine("Ingresa una opcion");

                Console.WriteLine("1 ----Nombre");
                Console.WriteLine("2 ---Apellido");
                Console.WriteLine("3 --DNI");
                Console.WriteLine("4 -Telefono");
                Console.WriteLine("");

                Console.WriteLine("5 -----Salir y ver los datos ingresados");


                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingresa tu nombre");
                        nom = Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingresa tu apellido");
                        ape = Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ingresa tu dnu");
                        dni = Console.ReadLine();
                        break;

                    case 4:
                        Console.Clear();

                        Console.WriteLine("Ingresa tu telefono");
                        telefono = int.Parse(Console.ReadLine());
                        break;


                }
            }
            while (op != 5);
            Console.Clear();
            Console.WriteLine("----nombre: " + nom);
            Console.WriteLine("");
            Console.WriteLine("---apellido " + ape);
            Console.WriteLine("");
            Console.WriteLine("--dni " + dni);
            Console.WriteLine("");
            Console.WriteLine("-Telefono " + telefono);
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
