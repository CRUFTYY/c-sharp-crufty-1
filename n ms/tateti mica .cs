using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pos = new string[9];
            int posicion = 0;
            int op = 0;

            Console.WriteLine("Tablero de posiciones para jugar");
            Console.WriteLine(" 0 | 1 | 2 ");
            Console.WriteLine("---|---|---");
            Console.WriteLine(" 3 | 4 | 5 ");
            Console.WriteLine("---|---|---");
            Console.WriteLine(" 6 | 7 | 8 ");


            Console.WriteLine("1-JUGAR");
            Console.WriteLine("0-SALIR");

            Console.WriteLine("Ingrese la opciòn");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    for (int cont = 0; cont < 3; cont++)
                    {
                        Console.WriteLine("Ingrese la posicion numero " + (cont + 1));
                        posicion = int.Parse(Console.ReadLine());
                        if (posicion == 0)
                        {
                            pos[0] = "x";
                        }
                        if (posicion == 1)
                        {
                            pos[1] = "x";
                        }
                        if (posicion == 2)
                        {
                            pos[2] = "x";
                        }
                        if (posicion == 3)
                        {
                            pos[3] = "x";
                        }
                        if (posicion == 4)
                        {
                            pos[4] = "x";
                        }
                        if (posicion == 5)
                        {
                            pos[5] = "x";
                        }
                        if (posicion == 6)
                        {
                            pos[6] = "x";
                        }
                        if (posicion == 7)
                        {
                            pos[7] = "x";
                        }
                        if (posicion == 8)
                        {
                            pos[8] = "x";
                        }

                        Console.WriteLine(pos[0] + " | " + pos[1] + " | " + pos[2]);
                        Console.WriteLine("-------");
                        Console.WriteLine(pos[3] + " | " + pos[4] + " | " + pos[5]);
                        Console.WriteLine("-------");
                        Console.WriteLine(pos[6] + " | " + pos[7] + " | " + pos[8]);



                    }
                    if (pos[0] == "x" && pos[1] == "x" && pos[2] == "x" || pos[3] == "x" && pos[4] == "x" && pos[5] == "x" || pos[6] == "x" && pos[7] == "x" && pos[8] == "x" || pos[0] == "x" && pos[3] == "x" && pos[6] == "x" || pos[1] == "x" && pos[4] == "x" && pos[7] == "x" || pos[2] == "x" && pos[5] == "x" && pos[8] == "x" || pos[0] == "x" && pos[4] == "x" && pos[8] == "x" || pos[2] == "x" && pos[4] == "x" && pos[6] == "x")
                    {
                        Console.WriteLine("GANASTE");
                    }

                    else
                    {
                        Console.WriteLine("PERDISTE, INTENTE NUEVAMENTE");
                    }

                    break;

                case 0:
                    break;

                default:
                    Console.WriteLine("Esa opciòn no existe, ingrese otra");
                    break;
            }
        }
    }
}
