using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        ///op 1 la  op  es "animalpeligroso" (esta op indica si el animal es un animal peligroso , para eso tiene en cuenta las cualidades , la especie , la cantidad de dientes .Un animal es peligroso cuando en sus cualidades es venenoso o apestoso , si su especie es reptil y si la cant de dientes es igual >= 2 dientes. )
        /// La op 2 "reptil + y - comilon "(esta op muestra todos los atributos reptil que tienen mayor numero de comidas ingeridas en la semana ).
        ///op 3 "poner a dieta a los mamiferos" (esta op decrementa un 25% las comidas ingeridas por semana que tienen los mamiferos ).
        /// op 4 "animales impares " (cada animal es identificado con un chip numerico , se debe mostrar todos los atibutos de  los animales con chip numerico impar )
        /// El programa debe realizarse con todas las estructuras y vectores.El programa debe realizarse para "X" cantidad de animales ingresado 
        {
            Console.WriteLine("Ingrese cantidad de animales ");
            int a = int.Parse(Console.ReadLine());

            int op = 0;
            int[] cantdientes = new int[a];
            string[] especie = new string[a];
            string[] cualidad = new string[a];
            int[] comidas = new int[a];
            int[] id = new int[a];
            int mayor = comidas[0];
            int menor = comidas[0];
            double[] comidasdecre = new double[a];
            int posmayor = 0;
            int posmenor = 0;

            for (int i = 0; a > i; i++)
            {
                Console.WriteLine("Ingrese cantidad de dientes del animal Nº: " + (i + 1));
                cantdientes[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese cualidad del animal Nº: " + (i + 1));
                cualidad[i] = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Ingrese especie del animal Nº: " + (i + 1));
                especie[i] = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Ingrese comidas ingeridas  del animal Nº: " + (i + 1));
                comidas[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el id del animal Nº: " + (i + 1));
                id[i] = int.Parse(Console.ReadLine());

            }

            do
            {
                Console.WriteLine("1 - Animal peligroso");
                Console.WriteLine("2 - Poner a dieta a los mamifero");
                Console.WriteLine("3 - Reptil mas y menos comilon");
                Console.WriteLine("4 - Animales impares");
                Console.WriteLine("");
                Console.WriteLine("6 - Salir del programa");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {

                    case 1:
                        for (int k = 0; k < a;k++)
                        {
                            if (cualidad[k] == "venenoso" && especie[k] == "reptil" && cantdientes[k] <= 2 || cualidad[k] == "apestoso" && especie[k] == "reptil" && cantdientes[k] <= 2)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("El animal " + id[k] + "  es peligroso");
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("El animal " + id[k] + "  No es pelgroso ");
                                Console.WriteLine("");
                            }
                        }
                        break;
                    case 2:
                        //mayor
                        for (int t = 0; t < a; t++)
                        {
                            if (especie[t] == "reptil")
                            {
                                for (int c = 0; c < a; c++)
                                {
                                    if (mayor > comidas[c])
                                    {

                                        posmayor = c;

                                    }

                                }
                                Console.WriteLine("");
                                Console.WriteLine("Mayor");
                                Console.WriteLine("Datos del animal que mas comida semanal comio");
                                Console.WriteLine("El id  : " + id[posmayor]);
                                Console.WriteLine("La cantidad de dientes : " + cantdientes[posmayor]);
                                Console.WriteLine("Cualidad : " + cualidad[posmayor]);
                                Console.WriteLine("Especie :  " + especie[posmayor]);
                                Console.WriteLine("Cantidad de comida semanal " + comidas[posmayor]);
                                Console.WriteLine("");

                                //menor
                                for (int l = 0; l < a; l++)
                                {
                                    if (mayor < comidas[l])
                                    {

                                        posmenor = l;

                                    }

                                }
                                Console.WriteLine("");
                                Console.WriteLine("Datos del animal que menos comida semanal comio");
                                Console.WriteLine("El id  : " + id[posmenor]);
                                Console.WriteLine("La cantidad de dientes : " + cantdientes[posmenor]);
                                Console.WriteLine("Cualidad : " + cualidad[posmenor]);
                                Console.WriteLine("Especie :  " + especie[posmenor]);
                                Console.WriteLine("Cantidad de comida semanal " + comidas[posmenor]);
                                Console.WriteLine("");
                                
                            }
                        }
                        break;


                    case 3:
                        for (int d = 0; d < a; d++)
                        {
                            comidas[d] = (comidas[d] * 25 / 100);
                            Console.WriteLine("El id  : " + id[d]);
                            Console.WriteLine("La cantidad de dientes : " + cantdientes[d]);
                            Console.WriteLine("Cualidad : " + cualidad[d]);
                            Console.WriteLine("Especie :  " + especie[d]);
                            Console.WriteLine("Cantidad de comida semanal " + comidas[d]);
                            Console.WriteLine("");
                        }
                        break;

                    case 4:
                        for (int r = 0; r < a; r++)
                        {
                            if (id[r] % 2 == 0)
                            {
                                Console.WriteLine("El id  : " + id[r]);
                                Console.WriteLine("La cantidad de dientes : " + cantdientes[r]);
                                Console.WriteLine("Cualidad : " + cualidad[r]);
                                Console.WriteLine("Especie :  " + especie[r]);
                                Console.WriteLine("Cantidad de comida semanal " + comidas[r]);
                                Console.WriteLine("");

                            }
                        }
                        break;
                }
            }
            while (op != 6);
        }

    }
}
