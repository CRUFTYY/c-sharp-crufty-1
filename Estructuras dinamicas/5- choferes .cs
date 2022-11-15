using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public struct chofer
        {
            public string nombre;
            public int idchofer;
            public int antiguedad;
            public int sueldo;
            public int vueltas;
        }
        public struct boletos
        {
            public int a;
            public int cant_a;

            public int b;
            public int cant_b;
            public int c;
            public int cant_c;

        }
        public struct recorido
        {
            public int reco;

        }
        static void leer(chofer[]chofer,int cant,boletos[]boletos , recorido[] recorido)
        {
            for (int i = 0; i<cant; i++)
            {
                int op;
                Console.WriteLine("Nombre del chofer N °" + (i + 1));
                chofer[i].nombre = (Console.ReadLine());

                Console.WriteLine(" ID  del chofer " + chofer[i].nombre + " ( numero  " + (i + 1) + " )");
                chofer[i].idchofer = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la antiguedad " + chofer[i].nombre + " ( numero  " + (i + 1) + " )");
                chofer[i].antiguedad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese sueldo basico del chofer " + chofer[i].nombre + " ( numero  " + (i + 1) + " )");
                chofer[i].sueldo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese cantidad de vueltas del chofer " + chofer[i].nombre + " ( numero  " + (i + 1) + " )");
                chofer[i].vueltas = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese cantidad de boletos de duracion  'corta distancia' vendidos del chofer " + chofer[i].nombre + " ( numero  " + (i + 1) + " )");
                boletos[i].cant_a = int.Parse(Console.ReadLine());
                boletos[i].a = boletos[i].cant_a * 28;

                Console.WriteLine("Ingrese cantidad de boletos de duracion  'media distancia' vendidos del chofer " + chofer[i].nombre + " ( numero  " + (i + 1) + " )");
                boletos[i].cant_b = int.Parse(Console.ReadLine());
                boletos[i].b = boletos[i].cant_b * 31;

                Console.WriteLine("Ingrese cantidad de boletos de duracion  'larga distancia' vendidos del chofer " + chofer[i].nombre + " ( numero  " + (i + 1) + " )");
                boletos[i].cant_c = int.Parse(Console.ReadLine());
                boletos[i].c = boletos[i].cant_c * 67;
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el recorrido del chofer " + chofer[i].nombre);
                        Console.WriteLine("1- Recorrido 1");
                        Console.WriteLine("2- Recorrido 2");
                        Console.WriteLine("");
                        op = int.Parse(Console.ReadLine());

                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("");
                                recorido[i].reco = 4;
                                Console.WriteLine("Se designaron correctamente los recoridos");
                                Console.WriteLine("");
                                break;
                            case 2:
                                Console.WriteLine("");
                                recorido[i].reco = 5;
                                Console.WriteLine("Se designaron correctamente los recoridos");
                                Console.WriteLine("");
                                break;
                        }
                        if (op == 2)
                        {
                            break;
                        }
                        else if (op == 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese una opción válida");
                            Console.ReadLine();
                        }
                    }
                }

            }
        }

        static void sueldopordia(chofer[] chofer, int cant, boletos[] boletos, recorido[] recorido)
        { 
            for (int i = 0; i < cant; i++)
            {
                if (chofer[i].antiguedad > 5 ) 
                {
                    
                }
            }
        }

            static void total(chofer[] chofer, int cant, boletos[] boletos, recorido[] recorido)
        {
            int total;

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("");
                total = boletos[i].a + boletos[i].b + boletos[i].c;
                Console.WriteLine("La cantidad total que recaudo el chofer " + chofer[i].nombre + " : " + total);
                Console.WriteLine("");
            }

        }

        static void ordenar(chofer[] chofer, int cant, boletos[] boletos, recorido[] recorido)
        {
            int aux1;
            string aux;
            for (int y = 1; y < cant; y++)
            {
                for (int i = 0; i > cant; i++)
                {
                    if (chofer[i].idchofer > chofer[i + 1].idchofer)
                    {
                        aux = chofer[i].nombre;
                        chofer[i].nombre = chofer[i + 1].nombre;
                        chofer[i + 1].nombre = aux;

                        aux1 = chofer[i].idchofer;
                        chofer[i].idchofer = chofer[i + 1].idchofer;
                        chofer[i + 1].idchofer = aux1;
                    }
                }
            }
            for (int o = 1; o < cant; o++)
            {
                Console.WriteLine("");
                Console.WriteLine("Nombre  : " + chofer[o].nombre);
                Console.WriteLine("");
                Console.WriteLine("  ID  del chofer : " + chofer[o].idchofer);
                Console.WriteLine("  antiguedad : " + chofer[o].antiguedad);
                Console.WriteLine("  sueldo  : " + chofer[o].sueldo);
                Console.WriteLine("  cantidad de vueltas : " + chofer[o].vueltas);
                Console.WriteLine(" 'corta distancia' vendidos  : " + boletos[o].a);
                Console.WriteLine(" 'media distancia' vendidos  : " + boletos[o].b);
                Console.WriteLine(" 'larga distancia' vendidos  : " + boletos[o].c);
                Console.WriteLine("  Recorido : " + recorido[o].reco);
                Console.WriteLine("");
            }
        }
        static void Mejorypeor(chofer[] chofer, int cant, boletos[] boletos, recorido[] recorido)
        {
            int mayor = chofer[0].sueldo;
            int posmayor = 0;
            int posmenor = 0;
            //mayor
            for (int t = 0; t < cant; t++)
            {
                    for (int c = 0; c < cant; c++)
                    {
                        if (mayor > chofer[c].sueldo)
                        {
                            posmayor = c;
                        }

                    }
                Console.WriteLine("");
                Console.WriteLine("El mejor  sueldo");
                Console.WriteLine("");
                Console.WriteLine("Nombre  : " + chofer[posmayor].nombre);
                Console.WriteLine("");
                Console.WriteLine("  ID  del chofer : " + chofer[posmayor].idchofer);
                Console.WriteLine("  antiguedad : " + chofer[posmayor].antiguedad);
                Console.WriteLine("");
                Console.WriteLine("  sueldo  : " + chofer[posmayor].sueldo);
                Console.WriteLine("");
                Console.WriteLine("  cantidad de vueltas : " + chofer[posmayor].vueltas);
                Console.WriteLine(" 'corta distancia' vendidos  : " + boletos[posmayor].a);
                Console.WriteLine(" 'media distancia' vendidos  : " + boletos[posmayor].b);
                Console.WriteLine(" 'larga distancia' vendidos  : " + boletos[posmayor].c);
                Console.WriteLine("  Recorido : " + recorido[posmayor].reco);
                Console.WriteLine("");
                //menor
                for (int l = 0; l < cant; l++)
                    {
                        if (mayor < chofer[l].sueldo)
                        {
                            posmenor = l;
                        }

                    }
                Console.WriteLine("");
                Console.WriteLine("El peor sueldo");
                Console.WriteLine("");
                Console.WriteLine("Nombre  : " + chofer[posmenor].nombre);
                Console.WriteLine("");
                Console.WriteLine("  ID  del chofer : " + chofer[posmenor].idchofer);
                Console.WriteLine("  antiguedad : " + chofer[posmenor].antiguedad);
                Console.WriteLine("");
                Console.WriteLine("  sueldo  : " + chofer[posmenor].sueldo);
                Console.WriteLine("");
                Console.WriteLine("  cantidad de vueltas : " + chofer[posmenor].vueltas);
                Console.WriteLine(" 'corta distancia' vendidos  : " + boletos[posmenor].a);
                Console.WriteLine(" 'media distancia' vendidos  : " + boletos[posmenor].b);
                Console.WriteLine(" 'larga distancia' vendidos  : " + boletos[posmenor].c);
                Console.WriteLine("  Recorido : " + recorido[posmenor].reco);
                Console.WriteLine("");
            }
        }
        
        static void Main(string[] args)
        {
            int cant;
            int op;
            Console.WriteLine("Ingrese cantidad de choferes ");
            cant = int.Parse(Console.ReadLine());
            chofer[] chofer = new chofer[cant];
            boletos[] boletos = new boletos[cant];
            recorido[] recorido = new recorido[cant];


            leer(chofer, cant , boletos , recorido);
            do
            {
                Console.WriteLine("1- Sueldo del empleado por dia");
                Console.WriteLine("2- Total recaudado de por dia por recorrido ");
                Console.WriteLine("3- mostrar listado segun Id");
                Console.WriteLine("4- Mejor y Peor pagos");
                Console.WriteLine("");
                Console.WriteLine("6- Salir");
                Console.WriteLine("Ingrese una opción");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        sueldopordia(chofer, cant, boletos, recorido);
                        break;
                    case 2:
                        Console.Clear();
                        total(chofer, cant, boletos, recorido);
                        break;
                    case 3:
                        Console.Clear();
                        ordenar(chofer, cant, boletos, recorido);
                        break;
                    case 4:
                        Console.Clear();
                        Mejorypeor(chofer, cant, boletos, recorido);
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Usted eligio la opcion salir");       
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Esta opcion es invalida , ingrese otro valor ");
                        Console.WriteLine("");
                        break;
                }
            } while (op != 6);


        }
    }
}
