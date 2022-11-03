using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace empleados
{
    internal class Program
    {
        public struct empleados
        {
            public string cond;
            public string estado;
            public int id;
            public int salario;
            public int horas;


        };
        static void leer(empleados[] a, int total)
        {
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Ingresar condición del empleado " + i);
                a[i].cond = Console.ReadLine();
                Console.WriteLine("Ingresar estado del empleado " + i);
                a[i].estado = Console.ReadLine();
                Console.WriteLine("Ingresar salario del empleado " + i);
                a[i].salario = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar horas del empleado " + i);
                a[i].horas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar id del empleado " + i);
                a[i].id = int.Parse(Console.ReadLine());


            }


        }
        static void empleadosfelices(empleados[] a, int total)
        {
            for (int i = 0; i < total; i++)
            {
                if (a[i].horas < 50 && a[i].salario > 80000 && a[i].estado == "soltero")
                {
                    Console.WriteLine("El empleado con id " + a[i].id + " es un empleado feliz");
                }


            }

        }
        static void aumentogerentes(empleados[] a, int total)
        {
            int aux;
            int aux2;
            int aux3;
            string aux4;
            string aux5;
            for (int i = 1; i < total; i++)
            {
                for (int j = 0; j < total - 1; j++)
                {
                    if (a[j].id < a[j + 1].id)
                    {
                        aux = a[j].id;
                        a[j].id = a[j + 1].id;
                        a[j + 1].id = aux;
                        aux2 = a[j].horas;
                        a[j].horas = a[j + 1].horas;
                        a[j + 1].horas = aux2;
                        aux3 = a[j].salario;
                        a[j].salario = a[j + 1].salario;
                        a[j + 1].salario = aux3;
                        aux4 = a[j].cond;
                        a[j].cond = a[j + 1].cond;
                        a[j + 1].cond = aux4;
                        aux5 = a[j].estado;
                        a[j].estado = a[j + 1].estado;
                        a[j + 1].estado = aux5;
                    }



                }


            }
            for (int i = 0; i < total; i++)
            {
                if (a[i].cond == "gerente")
                {
                    a[i].salario = a[i].salario + a[i].salario * 30 / 100;
                }


            }
            for (int i = 0; i < total; i++)
                Console.WriteLine("id: " + a[i].id + ", salario: " + a[i].salario + ", horas: " + a[i].horas + ", condición: " + a[i].cond + ", estado: " + a[i].estado);
        }
        static void ordenarsalarios(empleados[] a, int total)
        {
            int aux;
            int aux2;
            int aux3;
            string aux4;
            string aux5;
            for (int i = 1; i < total; i++)
            {
                for (int j = 0; j < total - 1; j++)
                {
                    if (a[j].salario < a[j + 1].salario)
                    {
                        aux = a[j].id;
                        a[j].id = a[j + 1].id;
                        a[j + 1].id = aux;
                        aux2 = a[j].horas;
                        a[j].horas = a[j + 1].horas;
                        a[j + 1].horas = aux2;
                        aux3 = a[j].salario;
                        a[j].salario = a[j + 1].salario;
                        a[j + 1].salario = aux3;
                        aux4 = a[j].cond;
                        a[j].cond = a[j + 1].cond;
                        a[j + 1].cond = aux4;
                        aux5 = a[j].estado;
                        a[j].estado = a[j + 1].estado;
                        a[j + 1].estado = aux5;
                    }



                }


            }
            for (int i = 0; i < total; i++)
                Console.WriteLine("id: " + a[i].id + ", salario: " + a[i].salario + ", horas: " + a[i].horas + ", condición: " + a[i].cond + ", estado: " + a[i].estado);
        }
        static void mostrarpares(empleados[] a, int total)
        {
            for (int i = 0; i < total; i++)
            {
                if (a[i].id % 2 == 0)
                {
                    Console.WriteLine("id: " + a[i].id + ", salario: " + a[i].salario + ", horas: " + a[i].horas + ", condición: " + a[i].cond + ", estado: " + a[i].estado);
                }

            }

        }
        static void gerentejodon(empleados[] a, int total)
        {
            int men = 0;
            int j = 0;
            for (int i = 0; i < total; i++)
            {
                if (a[i].horas > men && a[i].cond == "gerente")
                {
                    men = a[i].horas;
                    j = i;

                }

            }
                Console.WriteLine("id: " + a[j].id + ", salario: " + a[j].salario + ", horas: " + a[j].horas + ", condición: " + a[j].cond + ", estado: " + a[j].estado);

        }
        static void Main(string[] args)
        {
            int cant;
            int op;
            Console.WriteLine("Ingrese la cantidad de empleados");
            cant = int.Parse(Console.ReadLine());
            empleados[] empleados1 = new empleados[cant];
            leer(empleados1, cant);
            do
            {
                Console.WriteLine("1. Empleados felices");
                Console.WriteLine("2. Aumento gerentes");
                Console.WriteLine("3. Ordenar salario");
                Console.WriteLine("4. Mostrar pares");
                Console.WriteLine("5. Gerente jodón");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Ingrese una opción");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        empleadosfelices(empleados1, cant);
                        break;
                    case 2:
                        Console.Clear();
                        aumentogerentes(empleados1, cant);
                        break;
                    case 3:
                        Console.Clear();
                        ordenarsalarios(empleados1, cant);
                        break;
                    case 4:
                        Console.Clear();
                        mostrarpares(empleados1, cant);
                        break;
                    case 5:
                        Console.Clear();
                        gerentejodon(empleados1, cant);
                        break;
                        Console.Clear();
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Chau");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese una opción correcta");
                        break;
                }


            } while (op != 6);
        }
    }
}

