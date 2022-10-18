using System;
///En la fifa se necesita desarrollar un programa que permita controlar el desarrollo de un torneo para esto son necesarias las siguientes funciones:
///a) la función "PosibleCampeon()" (esta función muestra una tabla con todos los nombres de los equipos y al lado muestra un mensaje que dice "es un posible
///campeón", para ser un posbile campeón se tienen en cuenta la cantidad de goles realizados, los puntos del torneo y la cantidad de partidos jugados.
///Si la cantidad de partidos jugados es mayor a 10, la cantidad de goles convertidos son mayores a 30 y los puntos del torneo son mayores a 100, se puede
///decir que el equipo puede ser campeón);
///
///b) la función "TablaDePosiciones()" (esta función ordena y muestra todos los datos de los equipos según puntos los puntos del torneo de mayor a menor,
///además debe realizar un aumento del 20% a los puntos de los equipos que tengan menos de 40 puntos)
///
///c) la función "NoLoConsigue" (Esta función muestra todos los datos del equipo que menos goles tenga);
///
namespace ConsoleApp68
{
    internal class

        Program
    {
        static void Leer(int a, string[] Nombres, int[] goles, int[] puntTorn, int[] partidoscant)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Nombre del equipo N : " + (i + 1));
                Nombres[i] = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Goles del equipo N : " + (i + 1));
                goles[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Puntos del equipo N : " + (i + 1));
                puntTorn[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Cantidad de partidos del equipo N : " + (i + 1));
                partidoscant[i] = int.Parse(Console.ReadLine());
            }
        }
        static void PosibleCampeon(int a, string[] Nombres, int[] goles, int[] puntTorn, int[] partidoscant)
        {

            for (int i = 0; i < a; i++)
            {
                if (partidoscant[i] > 10 && goles[i] > 30 && puntTorn[i] > 100)
                {
                    Console.WriteLine("");
                    Console.WriteLine("El equipo  : " + Nombres[i] + "  Es un posible ganador");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine(Nombres[i]);
                    Console.WriteLine("");

                }
            }

        }

        static void TablaDePosiciones(int a, string[] Nombres, int[] goles, int[] puntTorn, int[] partidoscant)
        {
            string aux1;
            int aux2, aux3, aux4;

            for (int i = 1; i < a; i++)
            {
                for (int b = 0; b < a - 1; b++)
                {
                    if (puntTorn[b] < partidoscant[b + 1])
                    {
                        aux1 = Nombres[b];
                        Nombres[b] = Nombres[b + 1];
                        Nombres[b + 1] = aux1;

                        aux2 = goles[b];
                        goles[b] = goles[b + 1];
                        goles[b + 1] = aux2;

                        aux3 = puntTorn[b];
                        puntTorn[b] = puntTorn[b + 1];
                        puntTorn[b + 1] = aux3;

                        aux4 = partidoscant[b];
                        partidoscant[b] = partidoscant[b + 1];
                        partidoscant[b + 1] = aux4;
                    }
                }
            }
            for (int f = 0; f < a; f++)
            {
                puntTorn[f] = puntTorn[f] + puntTorn[f] * 20 / 100;
            }

            Console.Clear();
            Console.WriteLine("Tabla de posiciones  :  ");
            for (int f = 0; f < a; f++)
            {

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Equipo : " + Nombres[f]);
                Console.WriteLine("Puntos : " + puntTorn[f]);
                Console.WriteLine("Goles  : " + goles[f]);
                Console.WriteLine("Cantidad de partidos : " + partidoscant[f]);
                Console.WriteLine("");
            }
        }
        static void NoLoConsigue(int a, string[] Nombres, int[] goles, int[] puntTorn, int[] partidoscant)
        {

            int posmenor = 0;
            int mayor = goles[0];

            for (int p = 0; p < a; p++)
            {
                if (mayor > goles[p])
                {

                    posmenor = p;

                }

            }

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("El equipo que no lo consigue es... ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Equipo : " + Nombres[posmenor]);
            Console.WriteLine("Puntos : " + puntTorn[posmenor]);
            Console.WriteLine("Goles  : " + goles[posmenor]);
            Console.WriteLine("Cantidad de partidos : " + partidoscant[posmenor]);
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {

            int a;
            Console.WriteLine("Ingrese cantidad de equipos ");
            a = int.Parse(Console.ReadLine());

            string[] Nombres = new string[a];
            int[] goles = new int[a];
            int[] puntTorn = new int[a];
            int[] partidoscant = new int[a];

            Leer(a, Nombres, goles, puntTorn, partidoscant);
            Console.WriteLine("Pulse una letra para ir a PosibleCampeon ");
            Console.ReadKey();

            PosibleCampeon(a, Nombres, goles, puntTorn, partidoscant);
            Console.WriteLine("Pulse una letra para ir a la tabla de posiciones... ");
            Console.ReadKey();

            TablaDePosiciones(a, Nombres, goles, puntTorn, partidoscant);
            Console.WriteLine("Pulse una letra para ver quien no lo consigue... ");
            Console.ReadKey();

            NoLoConsigue(a, Nombres, goles, puntTorn, partidoscant);
            Console.WriteLine("Pulse una letra para cerrar el programa... ");
            Console.ReadKey();

        }
    }
}
