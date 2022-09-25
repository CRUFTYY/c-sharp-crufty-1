using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
    ///Ejercitacion con vectores
    ///1. Crear un programa que lea y muestre cuatro alumnos y sus notas finales de tres materias y que indique al lado de su nota y su nombre si pasó de año o n
    ///2. Crear un programa que pida a 5 clientes los nombres, apellidos, edad y sexo e indicar cuales son los nombres y los apellidos de las personas que tienen sexo femenino 
    ///3. Mostrar la suma de n cantidades de los precios de los productos ingresados por teclado
    ///4. Crear un programa que muestra las notas del examen parcial, oral y final de tres alumnos. Si la suma de todas las notas es mayor a 16 (el examen parcial y oral), el alumno esta promocionado, si la suma es menor a 16 y mayor que 12 el alumno está aprobado y debe rendir un complemento, si la suma es menor que 12 el alumno está desaprobado
    ///5. Crear un programa que calcule y grafique el area de un cuadrado, rectangulo y triangulo y además que calcule el perímetro de un trianglo, un trapecio y un paralelogramo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nom = new string[5];
            string[] ap = new string[5];
            float[] nota = new float[4];
            float[] prom = new float[4]; 

            for (int con = 1; con < 5; con++)
            {
                Console.Write("Ingrese el nombre del alumno: ");
                nom[con] = Console.ReadLine();

                Console.Write("Ingrese el apellido del alumno: ");
                ap[con] = Console.ReadLine();

                for (int cont = 1; cont < 4; cont++)  
                {
                    Console.WriteLine("Ingrese la nota N°" + cont);
                    nota[cont] = Convert.ToInt32(Console.ReadLine());
                }
            prom[con] = prom[con] + nota[con];
                Console.WriteLine(ap[con] + "," + nom[con] + " Con un promedio de: " + prom[con]);
                if (prom[con]/3 >= 6)
                {
                    Console.WriteLine("Está aprobado");
                }
                else
                {
                    Console.WriteLine("Está desaprobado");
                }
            
            }
        }
    }
}
