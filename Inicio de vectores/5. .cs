using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
    ///5. Crear un programa que calcule y grafique el area de un cuadrado, rectangulo y triangulo y además que calcule el perímetro de un trianglo, un trapecio y un paralelogramo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float per = 0;
            float[] l = new float[4];
            float l1 = 0;
            float l2 = 0;
            float b = 0;
            float h = 0;

            Console.WriteLine("Ingrese que prefiere calcular");
            Console.WriteLine("1. Rectangulo");
            Console.WriteLine("2. Cuadrado");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Trapecio");
            Console.WriteLine("5. Paralelogramo");
            switch (Console.ReadLine())
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Ingrese la base");
                    b = float.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la altura");
                    h = float.Parse(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine("╔══════════╗");
                    Console.WriteLine("║          ║");
                    Console.WriteLine("║          ║");
                    Console.WriteLine("╚══════════╝");

                    Console.WriteLine("El area del rectangulo es:" + (b*h) );
                    Console.ReadLine();

                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese la medida de un lado");
                    b = float.Parse(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine("╔══════╗");
                    Console.WriteLine("║      ║");
                    Console.WriteLine("║      ║");
                    Console.WriteLine("╚══════╝");

                    Console.WriteLine("El area del cuadrado es:" + (b * b));
                    Console.ReadLine();

                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Ingrese la base");
                    b = float.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el primer lado");
                    l1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo lado");
                    l1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la altura");
                    h = float.Parse(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine("    /\"");
                    Console.WriteLine("   /  \"");
                    Console.WriteLine("  /    \"");
                    Console.WriteLine(" -------- ");

                    Console.WriteLine("El area del triangulo es:" + ((b * h) /2));
                    Console.WriteLine("El perimetro del triangulo es:" + (l1 + l2 + b));
                    Console.ReadLine();

                    break;

                case 4:
                    Console.Clear();
                    for(int i = 0; i <4; i++)
                    {
                        Console.WriteLine("Ingrese el lado N°" + i);
                        l[i] = float.Parse(Console.ReadLine());
                        per += l[i];
                    }

                    Console.WriteLine("");
                    Console.WriteLine("    ----   ");
                    Console.WriteLine("   /    \"");
                    Console.WriteLine("  /      \"");
                    Console.WriteLine("  -------- ");

                    Console.WriteLine("El perimetro es: " + per);
                    Console.ReadLine();

                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Ingrese la medida de los primeros opuestos");
                    l1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la medida de los segundos opuestos");
                    l2 = float.Parse(Console.ReadLine());

                    Console.WriteLine("");
                    Console.WriteLine("    -------- ");
                    Console.WriteLine("   /      / ");
                    Console.WriteLine("  /      / ");
                    Console.WriteLine(" -------- ");

                    Console.WriteLine("El perimetro es: " + (2* (l1 + l2)));
                    Console.ReadLine();

                    break;

                    default:
                    break;
            }
        }
    }
}
