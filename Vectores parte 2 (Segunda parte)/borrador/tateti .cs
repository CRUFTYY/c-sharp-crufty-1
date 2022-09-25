-using System;

class crufty
{
    static int[,] tablero;
    static char[] simbolos = { '-', 'X' };
    static int jugadorActual = 1;
    static bool terminado;

    static void Main()
    {
        terminado = false;
        tablero = new int[3, 3];

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
        for (int fila = 0; fila < 3; fila++)
        {
            for (int columna = 0; columna < 3; columna++)
            {
                Console.Write(simbolos[tablero[fila, columna]]);
            }
            Console.WriteLine();
        }
    }

    private static void ComprobarEntradaUsuario(int jugador)
    {
        Console.Write("Dime la fila (1 a 3): ");
        int fila = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.Write("Dime la columna (1 a 3): ");
        int columna = Convert.ToInt32(Console.ReadLine()) - 1;

        tablero[fila, columna] = jugador;
    }

    private static void AnimarElementos()
    {
    }

    private static void ComprobarEstadoDelJuego()
    {
        bool partidaGanada = false;


        for (int fila = 0; fila < 3; fila++)
        {
            if ((tablero[fila, 0] == tablero[fila, 1])
                    && (tablero[fila, 0] == tablero[fila, 2])
                    && (tablero[fila, 0] == jugadorActual))
                partidaGanada = true;
        }

        for (int columna = 0; columna < 3; columna++)
        {
            if ((tablero[0, columna] == tablero[1, columna])
                    && (tablero[0, columna] == tablero[2, columna])
                    && (tablero[0, columna] == jugadorActual))
                partidaGanada = true;
        }

        if ((tablero[0, 0] == tablero[1, 1])
                && (tablero[0, 0] == tablero[2, 2])
                && (tablero[0, 0] == jugadorActual))
            partidaGanada = true;

        if ((tablero[0, 2] == tablero[1, 1])
                && (tablero[0, 2] == tablero[2, 0])
                && (tablero[0, 2] == jugadorActual))
            partidaGanada = true;

        if (partidaGanada)
        {
            Console.WriteLine("Felicidades ganaste!");
            terminado = true;
        }

    }

    private static void PausaHastaFinDeFotogama()
    {
        Console.WriteLine("Broo ganaste nashei");
    }
}

