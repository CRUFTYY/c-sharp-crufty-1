using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public struct trabajadores
        {
            public string nomrh;

            public string aprh;

            public string nomv;

            public string apv;

            public int hr;

            public int vent;

            public int idrh;

            public int idv;

            public char sec;
        }

        static void info(trabajadores[] a, int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Ingrese las horas trabajadas del empleado " + (i + 1));
                a[i].hr = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el sector del empleado " + (i + 1));
                a[i].sec = Convert.ToChar(Console.ReadLine());
                if (a[i].sec == 'h')
                {
                    Console.WriteLine("Ingrese el id del empleado " + (i + 1));
                    a[i].idrh = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el nombre del empleado " + (i + 1));
                    a[i].nomrh = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Ingrese el apellido del empleado " + (i + 1));
                    a[i].aprh = Convert.ToString(Console.ReadLine());
                }
                else if (a[i].sec == 'v')
                {
                    Console.WriteLine("Ingrese el id del empleado " + (i + 1));
                    a[i].idv = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el nombre del empleado " + (i + 1));
                    a[i].nomv = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Ingrese el apellido del empleado " + (i + 1));
                    a[i].apv = Convert.ToString(Console.ReadLine());

                    Console.WriteLine("Ingrese las ventas del empleado " + (i + 1));
                    a[i].vent = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Ingrese un sector valido");
                }

            }
        }
        static void OrdenarSector(tr[] a, int cant)
        {
            string aux1, aux2;
            int aux3, aux4, aux5;

            for (int i1 = 1; i1 < cant; i1++)
            {
                for (int i2 = 0; i2 < cant - 1; i2++)
                {
                    if (a[i2].idrh > a[i2 + 1].idrh)
                    {
                        aux1 = a[i2].nomrh;
                        a[i2].nomrh = a[i2 + 1].nomrh;
                        a[i2 + 1].nomrh = aux1;

                        aux2 = a[i2].aprh;
                        a[i2].aprh = a[i2 + 1].aprh;
                        a[i2 + 1].aprh = aux2;

                        aux3 = a[i2].hr;
                        a[i2].hr = a[i2 + 1].hr;
                        a[i2 + 1].hr = aux3;

                        aux5 = a[i2].idrh;
                        a[i2].idrh = a[i2 + 1].idrh;
                        a[i2 + 1].idrh = aux5;
                    }
                }
            }

            Console.WriteLine("Recursos Humanos");
            Console.WriteLine("");

            for (int i = 0; i < cant; i++)
            {
                if (a[i].idrh == 0)
                {
                }
                else
                {
                    Console.WriteLine("Nombre: " + a[i].nomrh);
                    Console.WriteLine("Apellido: " + a[i].aprh);
                    Console.WriteLine("ID: " + a[i].idrh);
                    Console.WriteLine("Horas Trabajadas: " + a[i].hr);
                    Console.WriteLine("");
                }
            }

            for (int i1 = 1; i1 < cant; i1++)
            {
                for (int i2 = 0; i2 < cant - 1; i2++)
                {
                    if (a[i2].idv > a[i2 + 1].idv)
                    {
                        aux1 = a[i2].nomv;
                        a[i2].nomv = a[i2 + 1].nomv;
                        a[i2 + 1].nomv = aux1;

                        aux2 = a[i2].apv;
                        a[i2].apv = a[i2 + 1].apv;
                        a[i2 + 1].apv = aux2;

                        aux3 = a[i2].hr;
                        a[i2].hr = a[i2 + 1].hr;
                        a[i2 + 1].hr = aux3;

                        aux4 = a[i2].vent;
                        a[i2].vent = a[i2 + 1].vent;
                        a[i2 + 1].vent = aux4;

                        aux5 = a[i2].idv;
                        a[i2].idv = a[i2 + 1].idv;
                        a[i2 + 1].idv = aux5;
                    }
                }
            }

            Console.WriteLine("Ventas");
            Console.WriteLine("");

            for (int i = 0; i < cant; i++)
            {
                if (a[i].idv == 0)
                {
                }
                else
                {
                    Console.WriteLine("Nombre: " + a[i].nomv);
                    Console.WriteLine("Apellido: " + a[i].apv);
                    Console.WriteLine("ID: " + a[i].idv);
                    Console.WriteLine("Ventas: " + a[i].vent);
                    Console.WriteLine("Horas Trabajadas: " + a[i].hr);
                    Console.WriteLine("");
                }
            }
        }

        static void MejorEmp(trabajadores[] a, int cant)
        {
            int ma = a[0].hr;
            int posmayor = 0;

            for (int i = 0; i < cant; i++)
            {
                if (ma < a[i].hr)
                {
                    ma = a[i].hr;
                    posmayor = i;
                }
            }
            if (a[posmayor].idrh == 0)
            {
                Console.WriteLine("Nombre: " + a[posma].nomv);
                Console.WriteLine("Apellido: " + a[posmayor].apv);
                Console.WriteLine("ID: " + a[posmayor].idv);
                Console.WriteLine("Ventas: " + a[posmayor].vent);
                Console.WriteLine("Horas Trabajadas: " + a[posmayor].hr);
                Console.WriteLine("Sector: Ventas");
            }
            else
            {
                Console.WriteLine("Nombre: " + a[posmayor].nomrh);
                Console.WriteLine("Apellido: " + a[posmayor].aprh);
                Console.WriteLine("ID: " + a[posmayor].idrh);
                Console.WriteLine("Horas Trabajadas: " + a[posmayor].hr);
                Console.WriteLine("Sector: Recursos Humanos");
            }
        }

        static void VentasTot(trabajadores[] a, int cant)
        {
            int venttot = 0;

            for (int i = 0; i < cant; i++)
            {
                venttot = venttot + a[i].vent;
            }

            Console.WriteLine("Hubo un total de " + venttot + " ventas");

            Console.WriteLine("Las ganancias totales son de " + (venttot * 5500) + "$");

            for (int i = 0; i < cant; i++)
            {
                if (a[i].idv != 0)
                {
                    Console.WriteLine("Nombre: " + a[i].nomv);
                    Console.WriteLine("Apellido: " + a[i].apv);
                    Console.WriteLine("ID: " + a[i].idv);
                    Console.WriteLine("Ventas: " + a[i].vent);
                    Console.WriteLine("Ganancias: " + (a[i].vent * 5500));
                    Console.WriteLine("Horas Trabajadas: " + a[i].hr);
                    Console.WriteLine("");
                }
                else
                {
                }

            }
            Console.ReadLine();

            Console.Clear();

            int mayor = a[0].vent;
            int posmayor = 0;

            for (int i = 0; i < cant; i++)
            {
                if (mayor < a[i].vent)
                {
                    mayor = a[i].vent;
                    posmayor = i;
                }
            }
            Console.WriteLine("El mayor vendendor es:");
            Console.WriteLine("Nombre: " + a[posmayor].nomv);
            Console.WriteLine("Apellido: " + a[posmayor].apv);
            Console.WriteLine("ID: " + a[posmayor].idv);
            Console.WriteLine("Ventas: " + a[posmayor].vent);
            Console.WriteLine("Horas Trabajadas: " + a[posmayor].hr);
        }

        static void Main(string[] args)
        {
            int cant;
            int op;

            Console.WriteLine("Ingrese la cantidad de empleados");
            cant = int.Parse(Console.ReadLine());
            trabajadores[] a = new tr[cant];

            info(a, cant);
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese la opcion a elegir");
                Console.WriteLine("1-ordenar ambos sectores");
                Console.WriteLine("2-el mejor empleado");
                Console.WriteLine("3-ventas totales");
                Console.WriteLine("4-Salir");

                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        OrdenarSector(a, cant);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        MejorEmp(a, cant);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        VentasTot(a, cant);
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Usted eligio la opcion salir , toca una tecla para continuar ");
                        Console.ReadLine();
                        break;
                }

            } while (op != 4);
        }
    }
}
