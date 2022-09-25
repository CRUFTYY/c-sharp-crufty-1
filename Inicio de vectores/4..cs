using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] parc = new float[3];
            float[] oral = new float[3];
            float[] fin = new float[3];

            for(int i = 0; i < 3; i++)
            {

                Console.WriteLine("Ingrese la nota parcial del alumno:" + i + 1);
                parc[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la nota oral del alumno:" + i + 1);
                oral[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la nota final del alumno:" + i + 1);
                fin[i] = float.Parse(Console.ReadLine());

                if(parc[i] + oral[i] > 16)
                {
                    Console.WriteLine("El alumno está promocionado");
                }
                else if(parc[i] + oral[i] <= 16 && parc[i] + oral[i] > 12)
                {
                    Console.WriteLine("El alumno está aprobado, pero debe rendir complementos");
                }
                else
                {
                    Console.WriteLine("El alumno está desaprobado");
                }
                Console.ReadLine();
            }

        }
    }
}
