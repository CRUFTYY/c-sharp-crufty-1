
using System;
using System.Linq;

class Ahorcado
{
    static void Main()
    {

        string[] palabras = { "capitan america", "doctor", "spiderman",
            "ironman", "hulk", "batman" };
        Random generador = new Random();
        int numeroAzar = generador.Next(0, palabras.Length);
        string palabraAdivinar = palabras[numeroAzar];


        string palabraMostrar = "";
        for (int i = 0; i < palabraAdivinar.Length; i++)
            if (palabraAdivinar[i] == ' ')
                palabraMostrar += " ";
            else
                palabraMostrar += "-";


        int fallosRestantes = 8;
        char letraActual;
        bool terminado = false;

        do
        {
            Console.WriteLine("Palabra oculta:  " + palabraMostrar);
            Console.WriteLine("Fallos restantes: " + fallosRestantes);

            Console.Write("Introduzca una letra: ");
            letraActual = Convert.ToChar(Console.ReadLine());


            if (!palabraAdivinar.Contains(letraActual))
                fallosRestantes--;


            string siguienteMostrar = "";

            for (int i = 0; i < palabraAdivinar.Length; i++)
            {
                if (letraActual == palabraAdivinar[i])
                    siguienteMostrar += letraActual;
                else
                    siguienteMostrar += palabraMostrar[i];
            }
            palabraMostrar = siguienteMostrar;

            if (!palabraMostrar.Contains("-"))
            {
                Console.WriteLine("Felicidades ganaste   ({0})",
                    palabraAdivinar);
                terminado = true;
            }
            else if (fallosRestantes == 0)
            {
                Console.WriteLine("Perdiste, era : " + palabraAdivinar);
                terminado = true;
            }

            Console.WriteLine();

        }
        while (!terminado);
    }
}