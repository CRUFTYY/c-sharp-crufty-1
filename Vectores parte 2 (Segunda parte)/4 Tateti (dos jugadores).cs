using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tateticrufty
{


    static int[,] tablero = new int[3, 3];



    static char[] simbolo = { ' ', 'X', 'O' };



    public static void Main()
    {
        bool terminado = false;


        DibujarTablero();
        do
        {

            PreguntarPosicion(1);

            DibujarTablero();

            terminado = ComprobarGanador();
            if (terminado){
                Console.WriteLine("Ganó jugador con el simbolo ' X '");
                Console.ReadKey();
            }

            


            else
            {
                terminado = ComprobarEmpate();
                if (terminado)
                    Console.WriteLine("Empate!");
                else
                {

                    PreguntarPosicion(2);

                    DibujarTablero();

                    terminado = ComprobarGanador();
                    if (terminado)
                        
                        Console.WriteLine("Ganó jugador con el simbolo ' O ' ");
                        Console.ReadKey();
                }
            }
            // Repetir hasta 3 en  o empate (tablero lleno)
        } while (!terminado);
    }


    static void DibujarTablero()
    {
        Console.WriteLine();
        Console.WriteLine("-------------");
        System.Threading.Thread.Sleep(169);
        for (int fila = 0; fila < 3; fila++)
        {
            Console.Write("|");
            for (int columna = 0; columna < 3; columna++)
                Console.Write(" {0} |", simbolo[tablero[fila, columna]]);
            Console.WriteLine();
            Console.WriteLine("-------------");
            System.Threading.Thread.Sleep(69);
        }
    }


    // ----- Pregunta dónde mover y lo anota en el tablero
    static void PreguntarPosicion(int jugador) // 1 = Jug.1, 2= Jug.2
    {
        int fila, columna;
        do
        {
            Console.WriteLine();

            //pido fila 
            do
            {
                
                Console.Write("En qué fila (1 a 3) ");
                fila = Convert.ToInt32(Console.ReadLine());

            }
            while ((fila < 1) || (fila > 3));

            // Pido columna
            do
            {
                
                Console.Write("En qué columna (1 a 3) ");
                columna = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            while ((columna < 1) || (columna > 3));

            if (tablero[fila - 1, columna - 1] != 0)
            
                Console.WriteLine("Casilla ocupada!");
        }
        while (tablero[fila - 1, columna - 1] != 0);

        // Si todo es correcto, se la asigno
        tablero[fila - 1, columna - 1] = jugador;
    }


    // ----- Devuelve "true" si hay 
    static bool ComprobarGanador()
    {
        bool haylinea = false;

        // Si en alguna fila todas las casillas son iguales y no vacías
        for (int fila = 0; fila < 3; fila++)
            if ((tablero[fila, 0] == tablero[fila, 1])
                    && (tablero[fila, 0] == tablero[fila, 2])
                    && (tablero[fila, 0] != 0))
                haylinea = true;

        // Lo mismo para las columnas
        for (int columna = 0; columna < 3; columna++)
            if ((tablero[0, columna] == tablero[1, columna])
                    && (tablero[0, columna] == tablero[2, columna])
                    && (tablero[0, columna] != 0))
                haylinea = true;

        // Y finalmente miro las dos diagonales
        if ((tablero[0, 0] == tablero[1, 1])
                && (tablero[0, 0] == tablero[2, 2])
                && (tablero[0, 0] != 0))
            haylinea = true;
        //dgnls 2  
        if ((tablero[0, 2] == tablero[1, 1])
                && (tablero[0, 2] == tablero[2, 0])
                && (tablero[0, 2] != 0))
            haylinea = true;

        return haylinea;
    }


    // ------------------------ Devuelve "true" si hay empate 
    static bool ComprobarEmpate()
    {
        // Si no quedan huecos donde mover, es empate
        bool algunHueco = false;

        for (int fila = 0; fila < 3; fila++)
            for (int columna = 0; columna < 3; columna++)
                if (tablero[fila, columna] == 0)
                    algunHueco = true;

        return !algunHueco;
    }
}
