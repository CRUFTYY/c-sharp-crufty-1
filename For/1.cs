using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
    ///1. Crear un programa que muestra los multiplos de dos y de tres entre 0 y 100
    ///2. Crear un programa que permita ingresar un número y mostrar las suma de los números que lo anteceden
    ///3. Crear un programa que muestre los múltiplos de 3 desde 1 hasta el número ingresado
    ///4. Crear un programa que me permita ingresar una x cantidad de pesos y que me indique cuantas personas pesan más y cuantas menos de 80kg
    ///5. Crear un programa que me permita ingresar una x cantidad de pesos y me muestre la persona más pesada, la más liviana, la cantidad de personas que ingresaron a pesarse, cuantos pesan más y cuantos pesan menos de 50kg
    ///6. Crear un programa que me permita ingresar tres datos y decir que clase de triangulo es. Para formar un triangulo hay que tener en cuenta que la suma de sus dos lados inferiores tiene que ser mayor a el lado superior
    ///7. Crear un programa que simule un convertidor de moneda extranjera(los valores a convertir son: dolar, euro, nerval, bitcoin, ethereum, reales, soles y libras)
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int c = 0; c <= 100; c++){

                if(c % 2 == 0){
                    Console.WriteLine("Múltiplo de 2: " + c);
                }

                if(c % 3 == 0){
                    Console.WriteLine("Múltiplo de 3: " + c);
                }                
            }
            Console.ReadKey();
        }
    }
}
