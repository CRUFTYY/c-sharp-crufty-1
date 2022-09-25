using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pos = new string[36];
            int c = 0;
            int op;
            Console.WriteLine("| 0 |1 | 2 | 3 | 4 | 5 |");
            Console.WriteLine("__________________________");
            Console.WriteLine("| 6 |7 | 8 | 9 | 10 | 11 |");
            Console.WriteLine("__________________________");
            Console.WriteLine("| 12|13| 14 | 15 | 16 | 17 |");
            Console.WriteLine("__________________________");
            Console.WriteLine("| 18 |19 | 20 | 21 | 22 | 26 |");
            Console.WriteLine("__________________________");
            Console.WriteLine("| 27 |28 | 29 | 30 | 31 | 32 |");
            Console.WriteLine("__________________________");
            Console.WriteLine("| 33 |34  | 35 | 36 |");
            do
            {
                Console.WriteLine("Ingresar valor entre 0 y 35");
                op = int.Parse(Console.ReadLine());

                if (op == 0)
                {
                    Console.WriteLine("No hay ninguna mina");
                    pos[0] = "x";
                }
                if (op == 2)
                {
                    Console.WriteLine("No hay ninguna mina");
                    pos[2] = "x";
                }
                if (op ==3)
                {
                    Console.WriteLine("No hay ninguna mina");
                    pos[3] = "x";
                }
                if (op == 4)
                {
                    Console.WriteLine("No hay ninguna mina");
                    pos[4] = "x";
                }
                if (op == 5)
                {
                    Console.WriteLine("No hay ninguna mina");
                    pos[5] = "x";
                }
                if (op == 6)
                {
                    Console.WriteLine("No hay ninguna mina");
                    pos[6] = "x";
                }
                if (op == 7)
                {
                    Console.WriteLine("No hay ninguna mina");
                    pos[7] = "x";
                }
                if (op == 8)
                {
                    Console.WriteLine("No hay ninguna mina");
                    pos[8] = "x";
                }
                if (op == 9)
                {
                    Console.WriteLine("No hay ninguna mina");
                    pos[9] = "x";
                }
                if (op == 10)
                {
                    Console.WriteLine("No hay ninguna mina");
                    pos[10] = "x";
                }
                if (op == 1)
                {
                    Console.WriteLine("Le diste a una mina. perdiste , Wa wa wa ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (op == 7)
                {
                    Console.WriteLine("Le diste a una mina. perdiste , Wa wa wa ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (op == 9)
                {
                    Console.WriteLine("Le diste a una mina. perdiste , Wa wa wa ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (op == 11)
                {
                    Console.WriteLine("Le diste a una mina. perdiste , Wa wa wa ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (op == 14)
                {
                    Console.WriteLine("Le diste a una mina. perdiste , Wa wa wa ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (op == 15)
                {
                    Console.WriteLine("Le diste a una mina. perdiste , Wa wa wa ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (op == 30)
                {
                    Console.WriteLine("Le diste a una mina. perdiste , Wa wa wa ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                if (op == 34)
                {
                    Console.WriteLine("Le diste a una mina. perdiste , Wa wa wa ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                if (pos[0] == "X" && pos[2] == "X" && pos[3] == "X" && pos[4] == "X" && pos[5] == "X" && pos[6] == "X" && pos[8] == "X" && pos[10] == "X")
                {
                    Console.WriteLine("Como no le diste a ninguna mina ganaste!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                c++;

            }
            while (op != 35);
            Console.ReadKey();
        }
    }
}
