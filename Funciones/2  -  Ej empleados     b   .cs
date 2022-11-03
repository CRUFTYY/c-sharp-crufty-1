using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Leer(int a, string[] estado, int[] horas, int[] salario, int[] id, string[] categoria)
        {
            for (int i = 0; i < a; i++)
            {

                Console.WriteLine("Ingres el ID del empleado N° " + (i + 1));
                id[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresar horas de trabajo del empleado N° " + (i + 1));
                horas[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese estado civil (todo en minuscula) del empleado N° " + (i + 1));
                estado[i] = Console.ReadLine();

                Console.WriteLine("Categoria  del empleado N° " + (i + 1));
                categoria[i] = Console.ReadLine();

                Console.WriteLine("Salario del empleado N° " + (i + 1));
                salario[i] = int.Parse(Console.ReadLine());


            }
        }

        static void empleadosfelices(int a, string[] estado, int[] horas, int[] salario, int[] id , string[] categoria)
        {
            for (int i = 0; i < a; i++)
            {
                if (horas[i] < 50 && salario[i] > 80000)
                {
                    Console.WriteLine("El empleado " + id[i] + "( " + (i + 1) + " ) " + "es un empleado feliz");

                }

            }
        }

        static void aumentocategoriagerentes(int a, string[] estado, int[] horas, int[] salario, int[] id, string[] categoria)
        {

            int aux1;

            for (int i = 1; i < a; i++)
            {
                for (int b = 0; b < a - 1; b++)
                {
                    if (id[b] < id[b + 1])
                    {
                        aux1 = id[b];
                        id[b] = id[b + 1];
                        id[b + 1] = aux1;
                    }
                }
            }
            for (int h = 0; h < a; h++)
            {
                if (categoria[h] == "gerente" || categoria[h] == "GERENTE" || categoria[h] == "Gerente" || categoria[h] == "GeReNtE")
                {
                    salario[h] = salario[h] + salario[h] * 30 / 100;
                    Console.WriteLine("Ahora el salario del gerente es de  : " + salario[h]);

                }
            }
        }

        static void ordenar(int a, string[] estado, int[] horas, int[] salario, int[] id, string[] categoria)
            {
            int aux1;

            for (int i = 1; i < a; i++)
            {
                for (int b = 0; b < a - 1; b++)
                {
                    if (salario[b] < salario[b + 1])
                    {
                        aux1 = salario[b];
                        salario[b] = salario[b + 1];
                        salario[b + 1] = aux1;
                    }
                }

            }
            for (int o = 0; o < a; o++)
            {
                Console.WriteLine("");
                Console.WriteLine("Id : " + id[o]);
                Console.WriteLine("Horas trabajadas : " + horas[o]);
                Console.WriteLine("Estado civil : " + estado[o]);
                Console.WriteLine("Salario : " + salario[o]);
                Console.WriteLine("");
            }

        }

        static void mostrarpares(int a, string[] estado, int[] horas, int[] salario, int[] id, string[] categoria)
        {
            for (int h = 0; h < a; h++)
            {
                if (id[h] % 2 == 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Id : " + id[h]);
                    Console.WriteLine("Horas trabajadas : " + horas[h]);
                    Console.WriteLine("Estado civil :     " + estado[h]);
                    Console.WriteLine("Salario :          " + salario[h]);
                    Console.WriteLine("Categoria :        " + categoria[h]);
                    Console.WriteLine("");
                }
            }
        }
        static void elgerentemasjodon(int a, string[] estado, int[] horas, int[] salario, int[] id, string[] categoria)
        {
            int posmenor = 0;
            int mayor = horas[0];

            for (int p = 0; p < a; p++)
            {
                if (mayor > horas[p])
                {

                    posmenor = p;

                }

            }
            Console.WriteLine("El gerente mas jodon es... ");
            Console.WriteLine("");
            Console.WriteLine("Id :                       " + id[posmenor]);
            Console.WriteLine("Horas trabajadas :         " + horas[posmenor]);
            Console.WriteLine("Estado civil :             " + estado[posmenor]);
            Console.WriteLine("Salario :                  " + salario[posmenor]);
            Console.WriteLine("");

        }

        static void Main(string[] args)
        {
            int a;
            int op;
            Console.WriteLine("Ingresar cantidad de empleados ");
            a = int.Parse(Console.ReadLine());

            string[] estado = new string[a];
            int[] horas = new int[a];
            int[] salario = new int[a];
            int[] id = new int[a];
            string[] categoria = new string[a];

            Leer(a, estado, horas, salario, id, categoria);

            do
            {
                Console.WriteLine("");
                Console.WriteLine("1 -  Empleados felices            ");
                Console.WriteLine("2 -  Aumento categoria gerentes   ");
                Console.WriteLine("3 -  Ordenar por salarios         ");
                Console.WriteLine("4 -  Mostrar los pares            ");
                Console.WriteLine("5 -  El gerente mas jodon         ");
                Console.WriteLine("");
                Console.WriteLine("6 -  SALIR                        ");
                Console.WriteLine(" Ingrese una opcion               ");
                Console.WriteLine("");
                op = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                switch (op)
                {
                    case 1:

                        Console.WriteLine("");
                        empleadosfelices(a, estado, horas, salario, id, categoria);
                        Console.WriteLine("");

                        break;

                    case 2:

                        aumentocategoriagerentes(a, estado, horas, salario, id, categoria);

                        break;

                    case 3:

                        ordenar(a, estado, horas, salario, id, categoria);

                        break;

                    case 4:

                        Console.WriteLine("");
                        mostrarpares(a, estado, horas, salario, id, categoria);
                        Console.WriteLine("");

                        break;

                    case 5:

                        Console.WriteLine("");
                        elgerentemasjodon(a,estado, horas,salario,id,categoria);
                        Console.WriteLine("");

                        break;

                }
            }
            while (op != 6);
        }
    }
}
