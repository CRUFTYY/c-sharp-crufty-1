using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
    ///2. Crear un programa que pida a 5 clientes los nombres, apellidos, edad y sexo e indicar cuales son los nombres y los apellidos de las personas que tienen sexo femenino
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            string[] nom = new string[6];
            string[] ap = new string[6];
            string[] sexo = new string[6];
            string[] fem = new string[6];
            int[] edad = new int[6];

            for(int i = 1; i < 6; i++)
            {
                Console.WriteLine("Ingrese el nombre de la persona n°" + i);
                nom[i] = Convert.ToString(Console.ReadLine());

                tConsole.WriteLine("Ingrese el apellido de la persona n°" + i);
                ap[i] = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Ingrese el sexo de la persona n°" + i);
                sexo[i] = Convert.ToString(Console.ReadLine().ToLower());

                Console.WriteLine("Ingrese la edad de la persona n°" + i);
                edad[i] = Convert.ToInt32(Console.ReadLine());

                switch (sexo[i])
                {

                    case "masculino":
                        break;

                    case "femenino":
                        fem[i] = String.Concat(nom[i], " ",  ap[i]);
                        break;
                }
            }

            Console.WriteLine("Las personas femeninas son:");

            foreach(var com in fem)
            {
                Console.WriteLine(com);
            }

            Console.ReadLine();
        }
    }
}
