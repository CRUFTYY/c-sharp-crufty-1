using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp88.Program;

namespace ConsoleApp88
{
    internal class Program
    {
        public struct bebidas
        {
            public int coca;
            public int up;
            public int agua;
            public int cafe;
            public int sprite;
            public int soda;
        }
        public struct comidas
        {
            public int vacio;
            public int pollo;
            public int paloma;
            public int empanadas;
            public int pizza;
            public int hamburguesa;
        }
        public struct postres
        {
            public int tiramisu;
            public int chcotorta;
            public int frutillas;
            public int ricota;
            public int oreo;
            public int avellanas;
        }
        static void leer(bebidas[] bebidas, comidas[] comidas, postres[] postres, int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Bienvenido al administrador de stock");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Ingreso de stock de las bebidas  ");
                Console.WriteLine("");
                Console.WriteLine("Ingrese cantidad de stock de la Cocacola");

                bebidas[i].coca = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de stock de la Seven Up");
                bebidas[i].up = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de stock del agua");
                bebidas[i].agua = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de stock del cafe");
                bebidas[i].cafe = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de stock de la Sprite");
                bebidas[i].sprite = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de stock de la soda");
                bebidas[i].soda = int.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Ingreso de stock de las comidas ");
                Console.WriteLine("");
                Console.WriteLine("Ingrese cantidad de stock del vacio");
                comidas[i].vacio = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de stock del pollo");
                comidas[i].pollo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de stock de la paloma");
                comidas[i].paloma = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de stock de las empanadas");
                comidas[i].empanadas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de stock de pizza");
                comidas[i].pizza = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de stock de hamburguesas");
                comidas[i].hamburguesa = int.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Ingreso de stock de los postres ");
                Console.WriteLine("");
                Console.WriteLine("Ingrese cantidad de stock del tiramisu ");
                postres[i].tiramisu = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de stock de tortas chocotortas");
                postres[i].chcotorta = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de stock de tortas de frutillas");
                postres[i].frutillas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de stock de tortas de ricota");
                postres[i].ricota = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de stock de tortas oreos ");
                postres[i].oreo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de stock de tortas de avellanas ");
                postres[i].avellanas = int.Parse(Console.ReadLine());
            }
        }

        static void tomarpedido(bebidas[] bebidas, comidas[] comidas, postres[] postres, int cant)
        {
            int op;
            Console.WriteLine("");
            Console.WriteLine("Bienvenido/a a Tomar un pedido ");
            Console.WriteLine("");
            do
            {
                Console.WriteLine("");
                Console.WriteLine("1-  Modificar stock de la bebida  ");
                Console.WriteLine("");
                Console.WriteLine("2 - Modificar stock de la comida  ");
                Console.WriteLine("");
                Console.WriteLine("3-  Modificar stock de  los postres ");
                Console.WriteLine("");
                Console.WriteLine("4- SALIR");
                Console.WriteLine("");
                Console.WriteLine("5-  No modificar el stock ");

                Console.WriteLine("Ingrese opcion");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        for (int i = 0; i < cant; i++)
                        {
                            Console.WriteLine(" MODIFICACION DE STOCK DE LAS BEBIDAS");
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese cantidad de stock de la Cocacola");

                            bebidas[i].coca = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese cantidad de stock de la Seven Up");
                            bebidas[i].up = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese cantidad de stock del agua");
                            bebidas[i].agua = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese cantidad de stock del cafe");
                            bebidas[i].cafe = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese cantidad de stock de la Sprite");
                            bebidas[i].sprite = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese cantidad de stock de la soda");
                            bebidas[i].soda = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        for (int i = 0; i < cant; i++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" MODIFICACION DE STOCK DE LA COMIDA ");
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese cantidad de stock del vacio");
                            comidas[i].vacio = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese cantidad de stock del pollo");
                            comidas[i].pollo = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese cantidad de stock de la paloma");
                            comidas[i].paloma = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese cantidad de stock de las empanadas");
                            comidas[i].empanadas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese cantidad de stock de pizza");
                            comidas[i].pizza = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese cantidad de stock de hamburguesas");
                            comidas[i].hamburguesa = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 3:
                        for (int i = 0; i < cant; i++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(" MODIFICACION DE STOCK DE LOS POSTRES ");
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese cantidad de stock del tiramisu ");
                            postres[i].tiramisu = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese cantidad de stock de tortas chocotortas");
                            postres[i].chcotorta = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese cantidad de stock de tortas de frutillas");
                            postres[i].frutillas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese cantidad de stock de tortas de ricota");
                            postres[i].ricota = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese cantidad de stock de tortas oreos ");
                            postres[i].oreo = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese cantidad de stock de tortas de avellanas ");
                            postres[i].avellanas = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("Usted eligio salir");
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("Como usted eligio , no se modifico el stock ");
                        Console.WriteLine("");
                        break;
                }
            } while(op > 3 );
        }
        static void Main(string[] args)
        {
            int cant = 1;
            int op;
            bebidas[] bebidas = new bebidas[cant];
            comidas[] comidas = new comidas[cant];
            postres[] postres = new postres[cant];

            leer(bebidas , comidas , postres , cant);

            do
            {
                Console.WriteLine("1- Tomar pedido");

                Console.WriteLine("2 - mostrar stock");

                Console.WriteLine("3- Ordenar stock");

                Console.WriteLine("6- SALIR");

                

                Console.WriteLine("Ingrese opcion");
             op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        tomarpedido(bebidas, comidas, postres, cant);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("Usted eligio salir del programa , chau");
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una opcion ivalida");
                        Console.WriteLine("");
                        break;
                }
            } while (op != 6);

        }
    }
}
