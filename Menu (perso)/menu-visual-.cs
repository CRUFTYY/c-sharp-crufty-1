using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            bool MostrarMenu = true;



            while (MostrarMenu)
            {
                MostrarMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Elija que prefiere modificar");
            Console.WriteLine("1--- Oración");
            Console.WriteLine("2-- Número");
            Console.WriteLine("3- Salir");
            Console.Write("\r\nOpción: ");

            switch (Console.ReadLine())
            {
                case "1":
                    OracionMenu();
                    return true;
                case "2":
                    NumeroMenu();
                    return true;
                case "3":
                    return false;
                case "dua lipa":
                    DuaLipa();
                    return true;
                default:
                    Error();
                    return true;
            }

        }
        private static void DuaLipa()
        {
            Console.Clear();
            Console.WriteLine("\r\nOne kiss is all it takes Fallin' in love with me Possibilities I look like all you need Let me take the night, I love real easy And I know that you'll still wanna see me On the Sunday morning, music real loud Let me love you while the moon is still out Something in you, lit up heaven in me The feeling won't let me sleep 'Cause I'm lost in the way you move, the way you feel One kiss is all it takes Fallin' in love with me Possibilities I look like all you need One kiss is all it takes Fallin' in love with me Possibilities I look like all you need One One One One I just wanna feel your skin on mine Feel your eyes do the exploring Passion in the message when you smile Take my time Something in you lit up heaven in me The feeling won't let me sleep 'Cause I'm lost in the way you move, the way you feel One kiss is all it takes Fallin' in love with me Possibilities I look like all you need One kiss is all it takes Fallin' in love with me Possibilities I look like all you need One One One One See a wonderland in your eyes Might need your company tonight Something in you lit up heaven in me The feeling won't let me sleep 'Cause I'm lost in the way you move, the way you feel One kiss is all it takes Fallin' in love with me Possibilities I look like all you need One kiss is all it takes Fallin' in love with me Possibilities I look like all you need One One One One");
            Console.ReadKey();
        }
        private static bool OracionMenu()
        {
            Console.Clear();
            Console.WriteLine("1---- Dar Vuelta");
            Console.WriteLine("2--- Eliminar Espacio");
            Console.WriteLine("3-- Salto de Línea");
            Console.WriteLine("4- Salir");
            Console.Write("\r\nOpción: ");

            switch (Console.ReadLine())
            {
                case "1":
                    OracionAlReves();
                    return true;
                case "2":
                    EliminarEspacio();
                    return true;
                case "3":
                    SaltoLinea();
                    return true;
                case "4":
                    return false;
                default:
                    Error();
                    return true;
            }
        }
        private static string IngresoO()
        {
            Console.WriteLine("Escriba la oración a modificar: ");
            return Console.ReadLine();
        }
        private static void OracionAlReves()
        {
            Console.Clear();
            Console.WriteLine("Oración al revés");
            char[] charArray = IngresoO().ToCharArray();
            Array.Reverse(charArray);
            MostrarResultadoO(String.Concat(charArray));
        }
        private static void EliminarEspacio()
        {
            Console.Clear();
            Console.WriteLine("Eliminar Espacio");

            MostrarResultadoO(IngresoO().Replace(" ", ""));
        }
        private static void SaltoLinea()
        {
            Console.Clear();
            Console.WriteLine("Salto de Línea");

            string[] subs = IngresoO().Split(' ');

            Console.WriteLine("\r\nTu oración modificada es: ");

            foreach (var sub in subs)
            {
                Console.WriteLine($"{sub}");
            }
            Console.Write("\r\nPresione Enter para volver al Menu");
            Console.ReadLine();
        }
        private static void MostrarResultadoO(string message)
        {
            Console.WriteLine($"\r\nTu oración modificada es: {message}");
            Console.Write("\r\nPresione Enter para volver al Menu");
            Console.ReadLine();
        }
        private static bool NumeroMenu()
        {
            Console.Clear();
            Console.WriteLine("1------ Agregar 10");
            Console.WriteLine("2----- Restar 10");
            Console.WriteLine("3---- Multiplicar por 10");
            Console.WriteLine("4--- Dividir por 10");
            Console.WriteLine("5-- Operación personalizada");
            Console.WriteLine("6- Salir");
            Console.Write("\r\nOpción: ");

            switch (Console.ReadLine())
            {
                case "1":
                    SumaDiez();
                    return true;
                case "2":
                    RestaDiez();
                    return true;
                case "3":
                    MultiDiez();
                    return true;
                case "4":
                    DiviDiez();
                    return true;
                case "5":
                    PersMenu();
                    return true;
                case "6":
                    return false;
                default:
                    Error();
                    return true;
            }
        }
        private static float IngresoN()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el número a modificar: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        private static void SumaDiez()
        {
            Console.Clear();
            Console.WriteLine("Sumar 10");
            MostrarResultadoN(IngresoN() + 10);

        }
        private static void RestaDiez()
        {
            Console.Clear();
            Console.WriteLine("Restar 10");
            MostrarResultadoN(IngresoN() - 10);
        }
        private static void MultiDiez()
        {
            Console.Clear();
            Console.WriteLine("Multiplicar por 10");
            MostrarResultadoN(IngresoN() * 10);
        }
        private static void DiviDiez()
        {
            Console.Clear();
            Console.WriteLine("Dividir por diez");
            MostrarResultadoN(IngresoN() / 10);
        }
        private static bool PersMenu()
        {
            Console.Clear();
            Console.WriteLine("1----- Suma");
            Console.WriteLine("2---- Resta");
            Console.WriteLine("3--- Multiplicar");
            Console.WriteLine("4-- Dividir");
            Console.WriteLine("5- Salir");

            switch (Console.ReadLine())
            {
                case "1":
                    Suma();
                    return true;
                case "2":
                    Resta();
                    return true;
                case "3":
                    Multi();
                    return true;
                case "4":
                    Divi();
                    return true;
                case "5":
                    return false;
                default:
                    Error();
                    return true;
            }
        }
        private static float IngresoN2()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el primer número para realizar la operación: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        private static float IngresoN3()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el segundo número para realizar la operación: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        private static void Suma()
        {
            Console.Clear();
            MostrarResultadoPS((IngresoN2() + IngresoN3()));
        }
        private static void Resta()
        {
            Console.Clear();
            MostrarResultadoPS((IngresoN2() - IngresoN3()));
        }
        private static void Multi()
        {
            Console.Clear();
            MostrarResultadoPS((IngresoN2() * IngresoN3()));
        }
        private static void Divi()
        {
            Console.Clear();
            MostrarResultadoPS((IngresoN2() / IngresoN3()));
        }
        private static void MostrarResultadoN(float message)
        {
            Console.WriteLine($"\r\nTu número modificado es: {message}");
            Console.Write("\r\nPresione Enter para volver al menú");
            Console.ReadKey();
        }
        private static void MostrarResultadoPS(float message)
        {
            Console.WriteLine($"Resultado: {message}");
            Console.Write("\r\nPresione Enter para volver al menú");
            Console.ReadKey();
        }
        private static void Error()
        {
            Console.Clear();
            Console.WriteLine("Ingrese una opción válida");
            Console.ReadKey();
        }
    }
}
