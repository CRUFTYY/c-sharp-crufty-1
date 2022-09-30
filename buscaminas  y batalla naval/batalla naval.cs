using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pos = new string[41];
            int posicion = 0;
            int op = 0;

            //| 0 | 1 | 2 | 3 | x | 5 |
            //| x | x | 8 | 9 | x | 11|
            //| 12| 13| 14| 15| x | 17|
            //| 18| 19| 20| 21| 22| 23|
            //| 24| x | x | x | x | 29|
            //| 30| 31| 32| 33| 34| 35|
            //| 36| 37| x | x | 40| 41|
            Console.WriteLine("TABLERO DE JUEGO");
            Console.WriteLine("");
            Console.WriteLine("| 1 | 2 | 3 | 4 | 5 | 6 |");
            Console.WriteLine("| 7 | 8 | 9 | 10| 11| 12|");
            Console.WriteLine("| 13| 14| 15| 16| 17| 18|");
            Console.WriteLine("| 19| 20| 21| 22| 23| 24|");
            Console.WriteLine("| 25| 26| 27| 28| 29| 30|");
            Console.WriteLine("| 31| 32| 33| 34| 35| 36|");
            Console.WriteLine("| 37| 38| 39| 40| 41| 42|");
            Console.WriteLine("");

            Console.WriteLine("1- Jugar");
            Console.WriteLine("0- Salir");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    for (int cont = 0; cont < 12; cont++)
                    {
                        Console.WriteLine("_____");
                        Console.WriteLine("Ingrese la posicion que quiera disparar");
                        posicion = int.Parse(Console.ReadLine());

                        if (posicion == 1)
                        {
                            pos[0] = "x";
                        }
                        if (posicion == 2)
                        {
                            pos[1] = "x";
                        }
                        if (posicion == 3)
                        {
                            pos[2] = "x";
                        }
                        if (posicion == 4)
                        {
                            pos[3] = "x";
                        }
                        if (posicion == 5)
                        {
                            pos[4] = "x";
                            Console.WriteLine("");
                            Console.WriteLine("Le diste a un barco");
                        }
                        if (posicion == 6)
                        {
                            pos[5] = "x";
                        }
                        if (posicion == 7)
                        {
                            pos[6] = "x";
                            Console.WriteLine("");
                            Console.WriteLine("Le diste a un barco");
                        }
                        if (posicion == 8)
                        {
                            pos[7] = "x";
                            Console.WriteLine("");
                            Console.WriteLine("Le diste a un barco");
                        }
                        if (posicion == 9)
                        {
                            pos[8] = "x";
                        }
                        if (posicion == 10)
                        {
                            pos[9] = "x";
                        }
                        if (posicion == 11)
                        {
                            pos[10] = "x";
                            Console.WriteLine("");
                            Console.WriteLine("Le diste a un barco");
                        }
                        if (posicion == 12)
                        {
                            pos[11] = "x";
                        }
                        if (posicion == 13)
                        {
                            pos[12] = "x";
                        }
                        if (posicion == 14)
                        {
                            pos[13] = "x";
                        }
                        if (posicion == 15)
                        {
                            pos[14] = "x";
                        }
                        if (posicion == 16)
                        {
                            pos[15] = "x";
                        }
                        if (posicion == 17)
                        {
                            pos[16] = "x";
                            Console.WriteLine("");
                            Console.WriteLine("Le diste a un barco");
                        }
                        if (posicion == 18)
                        {
                            pos[17] = "x";
                        }
                        if (posicion == 19)
                        {
                            pos[18] = "x";
                        }
                        if (posicion == 20)
                        {
                            pos[19] = "x";
                        }
                        if (posicion == 21)
                        {
                            pos[20] = "x";
                        }
                        if (posicion == 22)
                        {
                            pos[21] = "x";
                        }
                        if (posicion == 23)
                        {
                            pos[22] = "x";
                        }
                        if (posicion == 24)
                        {
                            pos[23] = "x";
                        }
                        if (posicion == 25)
                        {
                            pos[24] = "x";
                            Console.WriteLine("");
                            Console.WriteLine("Le diste a un barco");
                        }
                        if (posicion == 26)
                        {
                            pos[25] = "x";
                            Console.WriteLine("");
                            Console.WriteLine("Le diste a un barco");
                        }
                        if (posicion == 27)
                        {
                            pos[26] = "x";
                            Console.WriteLine("");
                            Console.WriteLine("Le diste a un barco");
                        }
                        if (posicion == 28)
                        {
                            pos[27] = "x";
                            Console.WriteLine("");
                            Console.WriteLine("Le diste a un barco");
                        }
                        if (posicion == 29)
                        {
                            pos[28] = "x";
                        }
                        if (posicion == 30)
                        {
                            pos[29] = "x";
                        }
                        if (posicion == 31)
                        {
                            pos[30] = "x";
                        }
                        if (posicion == 32)
                        {
                            pos[31] = "x";
                        }
                        if (posicion == 33)
                        {
                            pos[32] = "x";
                        }
                        if (posicion == 34)
                        {
                            pos[33] = "x";
                        }
                        if (posicion == 35)
                        {
                            pos[34] = "x";
                        }
                        if (posicion == 36)
                        {
                            pos[35] = "x";
                        }
                        if (posicion == 37)
                        {
                            pos[36] = "x";
                        }
                        if (posicion == 38)
                        {
                            pos[37] = "x";
                            Console.WriteLine("");
                            Console.WriteLine("Le diste a un barco");
                        }
                        if (posicion == 39)
                        {
                            pos[38] = "x";
                            Console.WriteLine("");
                            Console.WriteLine("Le diste a un barco");
                        }
                        if (posicion == 40)
                        {
                            pos[39] = "x";

                        }
                        if (posicion == 41)
                        {
                            pos[40] = "x";
                        }
                        if (posicion == 42)
                        {
                            pos[41] = "x";
                        }

                        if (posicion == 1 || posicion == 2 || posicion == 3 || posicion == 4 || posicion == 6 || posicion == 9 || posicion == 10 || posicion == 12 || posicion == 13 || posicion == 14 || posicion == 15 || posicion == 16 || posicion == 18 || posicion == 19 || posicion == 20 || posicion == 21 || posicion == 22 || posicion == 23 || posicion == 24 || posicion == 36 || posicion == 37 || posicion == 40 || posicion == 41)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("No le diste a nada");
                        }

                        if (pos[6] == "x" && pos[7] == "x")
                        {
                            Console.WriteLine("_____");
                            Console.WriteLine("");
                            Console.WriteLine("HUNDISTE EL BARCO DE 2");
                        }
                        if (pos[4] == "x" && pos[10] == "x" && pos[16] == "x")
                        {
                            Console.WriteLine("_____");
                            Console.WriteLine("");
                            Console.WriteLine("HUNDISTE EL BARCO DE 3");
                        }
                        if (pos[24] == "x" && pos[25] == "x" && pos[26] == "x" && pos[27] == "x")
                        {
                            Console.WriteLine("_____");
                            Console.WriteLine("");
                            Console.WriteLine("HUNDISTE EL BARCO DE 4");
                        }
                        if (pos[37] == "x" && pos[38] == "x")
                        {
                            Console.WriteLine("_____");
                            Console.WriteLine("");
                            Console.WriteLine("HUNDISTE EL BARCO DE 2");
                        }
                        if (pos[6] == "x" && pos[7] == "x" && pos[4] == "x" && pos[10] == "x" && pos[16] == "x" && pos[24] == "x" && pos[25] == "x" && pos[26] == "x" && pos[27] == "x" && pos[37] == "x" && pos[38] == "x")
                        {
                            Console.WriteLine("¡GANASTE!");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                    }

                    break;
                case 0:
                    Console.WriteLine("Gracias por jugar");
                    break;
                case 2:
                    Console.WriteLine("One kiss is all it takes\r\nFallin' in love with me\r\nPossibilities\r\nI look like all you need\r\nLet me take the night, I love real easy\r\nAnd I know that you'll still wanna see me\r\nOn the Sunday morning, music real loud\r\nLet me love you while the moon is still out\r\nSomething in you, lit up heaven in me\r\nThe feeling won't let me sleep\r\n'Cause I'm lost in the way you move, the way you feel\r\nOne kiss is all it takes\r\nFallin' in love with me\r\nPossibilities\r\nI look like all you need\r\nOne kiss is all it takes\r\nFallin' in love with me\r\nPossibilities\r\nI look like all you need\r\nOne\r\nOne\r\nOne\r\nOne\r\nI just wanna feel your skin on mine\r\nFeel your eyes do the exploring\r\nPassion in the message when you smile\r\nTake my time\r\nSomething in you lit up heaven in me\r\nThe feeling won't let me sleep\r\n'Cause I'm lost in the way you move, the way you feel\r\nOne kiss is all it takes\r\nFallin' in love with me\r\nPossibilities\r\nI look like all you need\r\nOne kiss is all it takes\r\nFallin' in love with me\r\nPossibilities\r\nI look like all you need\r\nOne\r\nOne\r\nOne\r\nOne\r\nSee a wonderland in your eyes\r\nMight need your company tonight\r\nSomething in you lit up heaven in me\r\nThe feeling won't let me sleep\r\n'Cause I'm lost in the way you move, the way you feel\r\nOne kiss is all it takes\r\nFallin' in love with me\r\nPossibilities\r\nI look like all you need\r\nOne kiss is all it takes\r\nFallin' in love with me\r\nPossibilities\r\nI look like all you need\r\nOne\r\nOne\r\nOne\r\nOne");

                    break;
            }
        }
    }
}
