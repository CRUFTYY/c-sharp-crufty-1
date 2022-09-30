using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;
            int a = 0;
            Console.WriteLine("Ingrese el numero de empleados");
            a = int.Parse(Console.ReadLine());
            int[] idEmpleado = new int[a];
            string[] nombre = new string[a];
            int[] hTrabajadas = new int[a];
            string[] estadoCivil = new string[a];
            int[] salarioEmpleado = new int[a];
            string[] categoriaEmpleado = new string[a];

            for (int contador = 0; contador < a; contador++)
            {
                Console.WriteLine("Ingrese idEmpleado: ");
                idEmpleado[contador] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nombre: ");
                nombre[contador] = Console.ReadLine();
                Console.WriteLine("Ingrese horas trabajadas ");
                hTrabajadas[contador] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese estado civil");
                estadoCivil[contador] = Console.ReadLine();
                Console.WriteLine("Ingrese salario ");
                salarioEmpleado[contador] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese categoria ");
                categoriaEmpleado[contador] = Console.ReadLine();
            }

            int mayor = salarioEmpleado[0];
            int menor = salarioEmpleado[0];
            int posmayor = 0;
            int posmenor = 0;
            do
            {
                Console.WriteLine("1-empleado feliz");
                Console.WriteLine("2-aumento gerentes");
                Console.WriteLine("3- mayor y menor");
                Console.WriteLine("4- los pares");
                Console.WriteLine("5-salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {


                    case 1:
                        for (int contador2 = 0; contador2 < a; contador2++)
                        {

                            if (salarioEmpleado[contador2] > 80000 && hTrabajadas[contador2] < 50 && estadoCivil[contador2] == "soltero")
                            {

                                Console.WriteLine("el empleado " + idEmpleado[contador2] + " es Feliz");

                            }
                            else
                            {
                                Console.WriteLine("el emplado " + idEmpleado[contador2]);
                            }
                        }
                        break;
                    case 2:
                        for (int contador3 = 0; contador3 < a; contador3++)
                        {
                            if (categoriaEmpleado[contador3] == "gerente")
                            {
                                salarioEmpleado[contador3] = salarioEmpleado[contador3] + ((salarioEmpleado[contador3] * 30) / 100);
                                Console.WriteLine(idEmpleado[contador3] + " " + nombre[contador3] + " " + hTrabajadas[contador3] + " " + estadoCivil[contador3] + " " + salarioEmpleado[contador3] + " " + categoriaEmpleado[contador3]);
                            }


                        }
                        break;
                    case 3:
                        //mayor
                        for (int contador = 0; contador < a; contador++)
                        {
                            if (mayor < salarioEmpleado[contador])
                            {

                                posmayor = contador;

                            }

                        }
                        Console.WriteLine("Mayor");
                        Console.WriteLine(idEmpleado[posmayor] + " " + nombre[posmayor] + " " + hTrabajadas[posmayor] + " " + estadoCivil[posmayor] + " " + salarioEmpleado[posmayor] + " " + categoriaEmpleado[posmayor]);
                        //menor
                        for (int cont = 0; cont < a; cont++)
                        {
                            if (mayor > salarioEmpleado[cont])
                            {

                                posmenor = cont;

                            }

                        }
                        Console.WriteLine("Menor");
                        Console.WriteLine(idEmpleado[posmenor] + " " + nombre[posmenor] + " " + hTrabajadas[posmenor] + " " + estadoCivil[posmenor] + " " + salarioEmpleado[posmenor] + " " + categoriaEmpleado[posmenor]);

                        break;


                    case 4:


                        for (int contador = 0; contador < a; contador++)
                        {
                            if (idEmpleado[contador] % 2 == 0)
                            {

                                Console.WriteLine(idEmpleado[contador] + " " + nombre[contador] + " " + hTrabajadas[contador] + " " + estadoCivil[contador] + " " + salarioEmpleado[contador] + " " + categoriaEmpleado[contador]);
                            }


                        }
                        break;

                    case 5:

                        Console.WriteLine("chau");
                        break;
                }





            } while (opcion != 5);





        }

    }
}
