using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp79.Program;

namespace ConsoleApp79
{
    ///1. Para la empresa "local host" se necesita desarrollar un software que ayude a tenrer control de sus empleados. Existen dos sectores importantes en la organización que son recursos humanos y ventas, para identificar a sus empleados existe un id diferente para cada sector y datos personales. Se necesitan desarrollar las siguientes funcionalidades
    ///A. Ordenar ambos sectores (Esta función ordena ambos sectores por id de empleado de menor a mayor) (mostrar)
    ///B. El mejor empleado (Esta función compara todas las horas trabajadas de los empleados de la organización y muestra por pantalla al empleado con más horas trabajadas y el sector al cuál pertenece)
    ///C. Ventas totales (Esta función realiza la suma de todas las ventas realizadas, calcula las ganancias multiplicando las ventas por 5.500, calcula las ganancias obtenidas por cada vendedor e indica cual es el vendedor con mayor número de ventas)
    internal class Program
    {
        public struct recursoshumanos{
            public int id;
            public int dni;
            public int horas;
        };
        public struct ventas
        {
            public int id;
            public int dni;
            public int horas;
            public int venta;
        };

        static void Leer(ventas[] ventas, recursoshumanos[] recursoshumanos1, int cantrecursos, int cantventas) 
        {
            for (int i = 0; i < cantrecursos; i++)
            {
                Console.WriteLine("Ingrese el ID del empleado de recursos humanos           " + (i + 1));
                recursoshumanos1[i].id = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el DNI del empleado de recursos humanos          " + (i + 1));
                recursoshumanos1[i].dni = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el horas del empleado de recursos humanos        " + (i + 1));
                recursoshumanos1[i].horas = int.Parse(Console.ReadLine());
            }
            for (int o = 0; o < cantventas; o++)
            {
                Console.WriteLine("Ingrese el ID del empleado de ventas                     " + (o + 1));
                ventas[o].id = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el DNI del empleado de ventas                    " + (o + 1));
                ventas[o].dni = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el horas del empleado de ventas                  " + (o + 1));
                ventas[o].horas = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de ventas del empleado de ventas     " + (o + 1));
                ventas[o].venta = int.Parse(Console.ReadLine());
            }

        }
        static void Ordenar(ventas[] ventas, recursoshumanos[] recursoshumanos1, int cantrecursos, int cantventas)
        {
            int aux1,aux2,auxa, auxb;
            for (int j = 0; j > cantventas; j++)
            {
                for (int k = 1; k > cantventas - 1; k++)
                {
                    if (ventas[k].id > ventas[k + 1].id)
                    {
                        aux1 = ventas[k].id;
                        ventas[k].id = ventas[k + 1].id;
                        ventas[k + 1].id = aux1;
                    }
                }
            }
            for (int j = 0; j < cantventas; j++)
            {
                for (int k = 1; k < cantventas - 1; k++)
                {
                    if (recursoshumanos1[k].id > recursoshumanos1[k + 1].id)
                    {
                        auxa = recursoshumanos1[k].id;
                        recursoshumanos1[k].id = recursoshumanos1[k + 1].id;
                        recursoshumanos1[k + 1].id = auxa;

                        auxb = recursoshumanos1[k].horas;
                        recursoshumanos1[k].horas = recursoshumanos1[k + 1].horas;
                        recursoshumanos1[k + 1].id = auxb;
                    }
                }
            }
            for (int s = 0; s < cantventas; s++)
            {
                Console.WriteLine("El empleado de ventas");
                Console.WriteLine("Id: " + ventas[s].id);
                Console.WriteLine("Trabaja : " + ventas[s].horas);
                Console.WriteLine("Dni : " + ventas[s].dni);
                Console.WriteLine("Cantidad de ventas : " + ventas[s].venta);

            }
            for (int s = 0; s < cantventas; s++)
            {
                Console.WriteLine("El empleado de recursos humanos");
                Console.WriteLine("Id: " + recursoshumanos1[s].id);
                Console.WriteLine("Trabaja : " + recursoshumanos1[s].horas);
                Console.WriteLine("Dni : " + recursoshumanos1[s].dni);
            }
            Console.WriteLine("Pulse una letra para continuar");
            Console.ReadKey();
        }

        static void ventastotales(ventas[] ventas, recursoshumanos[] recursoshumanos1, int cantrecursos, int cantventas, int postmenor,int postmayor)
        {
            int mayor = ventas[0].venta;
            int posmayor = 0;

            float ganancia;
            float ventastotales;

            for (int i = 0; i < cantventas; i++)
            {
                ventas[i].venta = ventas[i].venta + ventas[i].venta;
            }
            
            for (int contador = 0; contador < cantventas; contador++)
            {
                if (mayor < ventas[contador].venta)
                {

                    posmayor = contador;

                }

            }
            
            Console.WriteLine("");
            Console.WriteLine("Mayor");
            Console.WriteLine("");
            Console.WriteLine("El empleado de ventas");
            Console.WriteLine("Id: " + ventas[posmayor].id);
            Console.WriteLine("Trabaja : " + ventas[posmayor].horas);
            Console.WriteLine("Dni : " + ventas[posmayor].dni);
            Console.WriteLine("Cantidad de ventas : " + ventas[posmayor].venta);


        }
        static void Main(string[] args)
        {
            int op;
            int cantventas;
            int cantrecursos;

            Console.WriteLine("ingrese cantidad de empleados en ventas");
            cantventas = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese cantidad de empleados en recursos humanos");
            cantrecursos = int.Parse(Console.ReadLine());

            ventas[] ventas;
            ventas = new ventas[cantventas];
            recursoshumanos[] recursoshumanos1;
            recursoshumanos1 = new recursoshumanos[cantrecursos];

            Leer(ventas, recursoshumanos1, cantrecursos, cantventas);
            Console.WriteLine("");
            Console.WriteLine("Pulsa una letra para ir al menu ");
            Console.ReadKey();
            do
            {
                Console.WriteLine("                     ");

                Console.WriteLine("1 - Ordenar          ");
                Console.WriteLine("2 - Mejor Empleado   ");
                Console.WriteLine("3 - Ventas totales   ");
                Console.WriteLine("4 - SALIR            ");

                Console.WriteLine("                     ");

                Console.WriteLine("Ingrese una opcion");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Ordenar(ventas, recursoshumanos1, cantrecursos, cantventas);
                        break;
                    case 2:

                        break;
                    case 3:
                        ventastotales(ventas, recursoshumanos1, cantrecursos, cantventas);
                        break;
                }
            }

            while (op != 4);
        }

        private static void ventastotales(ventas[] ventas, recursoshumanos[] recursoshumanos1, int cantrecursos, int cantventas)
        {
            throw new NotImplementedException();
        }
    }
}
