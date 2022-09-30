using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class crufty
{
    static int[,] tablero;
    static char[] simbolos = { '-', 'X' };
    static int jugadorActual = 1;
    static bool terminado;

    static void Main()
    {
        terminado = false;
        tablero = new int[6, 6];

        while (!terminado)
        {
            DibujarPantalla();
            ComprobarEntradaUsuario(jugadorActual);
            AnimarElementos();
            ComprobarEstadoDelJuego();
            PausaHastaFinDeFotogama();
        }
    }


    private static void DibujarPantalla()
    {
        for (int fila = 0; fila < 6; fila++)
        {
            for (int columna = 0; columna < 6; columna++)
            {
                Console.Write(simbolos[tablero[fila, columna]]);
            }
            Console.WriteLine();
        }
    }

    private static void ComprobarEntradaUsuario(int jugador)

    {
        Console.Write("Dime la fila (1 a 6): ");

        int fila = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.Write("Dime la columna (1 a 6): ");
        int columna = Convert.ToInt32(Console.ReadLine()) - 1;

        tablero[fila, columna] = jugador;
    }

    private static void AnimarElementos()
    {
    }

    private static void ComprobarEstadoDelJuego()
    {
        bool partidaGanada = false;


        for (int fila = 0; fila < 6; fila++)
        {
            if ((tablero[fila, 0] == tablero[fila, 1])
                    && (tablero[fila, 0] == tablero[fila, 2])
                    && (tablero[fila, 0] == jugadorActual))
                partidaGanada = true;
        }
        for (int fila = 0; fila < 6; fila++)
        {
            if ((tablero[fila, 0] == tablero[fila, 1]) && (tablero[fila, 0] == tablero[fila, 2]) && (tablero[fila, 0] == jugadorActual))
                partidaGanada = true;
        }
        for (int fila = 0; fila < 6; fila++)
        {
            if ((tablero[fila, 6] == tablero[fila, 6]) && (tablero[fila, 6] == tablero[fila, 6]) && (tablero[fila, 0] == jugadorActual)){
                partidaGanada = true;
        }
            }
    }


    private static void PausaHastaFinDeFotogama()
    {
        Console.WriteLine("");
        Console.WriteLine("Ingresa el proximo valor ");
    }
}

