using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///7. Crear un programa que simule un convertidor de moneda extranjeras valores a convertir son: dolar, euro, nerval, bitcoin, ethereum, reales, soles y libras
            int pesos = 0;

            int dolar = 274;

            int pesos = 0;

            int pesos = 0;

            int pesos = 0;

            int pesos = 0;

            int pesos = 0;

            int pesos = 0;

            int pesos = 0;
            int op = 0;

            do
            {
                Console.WriteLine("Ingresa una opcion para convertir ");

                Console.WriteLine("1 ------- Dolar ");
                Console.WriteLine("2 ------- Euro ");
                Console.WriteLine("3 ------- Nerval ");
                Console.WriteLine("4 ------- Bitcoin ");
                Console.WriteLine("");
                Console.WriteLine("5 ------- Ethereume ");
                Console.WriteLine("6 ------- Reales ");
                Console.WriteLine("7 ------- Soles ");
                Console.WriteLine("8 ------- Libras ");
                Console.WriteLine("");
                Console.WriteLine("9 ------- Todas las monedas a la vez ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("0 ----------- SALIR DEL PROGRAMA ");


                Console.WriteLine("5 -----Salir y ver los datos ingresados");


                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingresa su valor en Pesos para convertir a Dolares ");
                        
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingresa su valor en Pesos para convertir a Euro ");
                        
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ingresa su valor en Pesos para convertir a Neval ");

                        break;


                    case 4:
                        Console.Clear();
                        Console.WriteLine("Ingresa su valor en Pesos para convertir a Bitcoin ");
                        
                        break;

                    case 5:
                        Console.Clear();

                        Console.WriteLine("Ingresa su valor en Pesos para convertir a Etereum ");
                        
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Ingresa su valor en Pesos para convertir a Reales ");
                        
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("Ingresa su valor en Pesos para convertir a Soles ");
                        
                        break;

                    case 8:
                        Console.Clear();
                        Console.WriteLine("Ingresa su valor en Pesos para convertir a Libras ");
                        
                        break;


                    case 9:
                        Console.Clear();

                        Console.WriteLine("Ingres su valor en Pesos para convertir en todas las monedas a la vez");

                        break;


                }
            }
            while (op != 0);

            Console.ReadKey();
        }
    }
  
}
