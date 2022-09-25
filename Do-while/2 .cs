using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {


        static void Main(string[] args)
        {

            int op;
            string cafe = "";
            string torta = "";
            string almuerzo = "";
            string bebida = "";

            int opcafe;
            int optorta;
            int opalmuerzo;
            int opbebida;

            do
            {
                Console.WriteLine("Ingresa una opcion");
                Console.WriteLine("");
                Console.WriteLine("1 -Cafes");
                Console.WriteLine("");
                Console.WriteLine("2 -tortas");
                Console.WriteLine("");
                Console.WriteLine("3 -Almuerzo");
                Console.WriteLine("");
                Console.WriteLine("4 -Bebidas");
                Console.WriteLine("");
                Console.WriteLine("5 -Cuenta");
                Console.WriteLine("");


                op = int.Parse(Console.ReadLine());
                switch (op)
                {

                    case 1:
                        Console.WriteLine("1-Cafe");
                        Console.WriteLine("2-Capuccino");
                        Console.WriteLine("3-Latte");
                        opcafe = int.Parse(Console.ReadLine());

                        switch (opcafe)
                        {

                            case 1:
                                cafe = "Cafe";
                                break;

                            case 2:
                                cafe = "Capuccino";
                                break;

                            case 3:
                                cafe = "Latte";
                                break;

                        }


                        break;


                    case 2:
                        Console.WriteLine("1-Chocolate");
                        Console.WriteLine("2-Lemond pie");
                        Console.WriteLine("3-Crumble");
                        opcafe = int.Parse(Console.ReadLine());

                        switch (opcafe)
                        {

                            case 1:
                                torta = "Chocolate";
                                break;

                            case 2:
                                torta = "Lemond pie";
                                break;

                            case 3:
                                torta = "Crumble";
                                break;

                        }


                        break;


                    case 3:
                        Console.WriteLine("1-Milanesa");
                        Console.WriteLine("2-Hamburguesa");
                        Console.WriteLine("3-Tostado");
                        opcafe = int.Parse(Console.ReadLine());

                        switch (opcafe)
                        {

                            case 1:
                                almuerzo = "Milanesa";
                                break;

                            case 2:
                                almuerzo = "hamburguesa";
                                break;

                            case 3:
                                almuerzo = "Tostado";
                                break;

                        }


                        break;

                    case 4:
                        Console.WriteLine("1-Agua");
                        Console.WriteLine("2-Coca-cola");
                        Console.WriteLine("3-Jugo");
                        opcafe = int.Parse(Console.ReadLine());

                        switch (opcafe)
                        {

                            case 1:
                                bebida = "Agua";
                                break;

                            case 2:
                                bebida = "Coca-cola";
                                break;

                            case 3:
                                bebida = "Jugo";
                                break;

                        }


                        break;





                }
            }
            while (op != 5);

            Console.WriteLine("Pediste:" + cafe + " " + torta + " " + almuerzo + " " + bebida);

            Console.ReadKey();
        }
    }
}