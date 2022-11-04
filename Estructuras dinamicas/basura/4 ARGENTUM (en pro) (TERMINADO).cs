using System;

namespace ConsoleApp82
{
    internal class Program
    {

        public struct leer
        {
            public string status;
            public string nom;

            public int criminales;
            public int ciudadanos;

        }
        public struct armada
        {
            public string nom;

            public int hcaballo;
            public int arqueria;
            public int navegacion;
        }
        public struct legion
        {
            public string nom;

            public int poder;
            public int fuerza;
            public int celeridad;

        }
        static void lee(leer[] leer, armada[] armada, legion[] legion, int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Ingrese nombre del personaje");
                leer[i].nom = Console.ReadLine();

                Console.WriteLine("Ingrese cantidad de criminales asesinados");
                leer[i].criminales = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese cantidad de ciudadanos asesinados");
                leer[i].ciudadanos = int.Parse(Console.ReadLine());
            }
        }
        static void faccionpert(leer[] leer, armada[] armada, legion[] legion, int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                if (leer[i].criminales > 150 && leer[i].ciudadanos == 0)
                {
                    leer[i].status = "armada";
                    Console.WriteLine("");
                    Console.WriteLine("El personaje " + armada[i].nom + "  pertenece a la faccion la   Armada Real");
                    Console.WriteLine("");
                }
                if (leer[i].ciudadanos > 200)
                {
                    leer[i].status = "legion";

                    legion[i].nom = leer[i].nom;
                    Console.WriteLine("");
                    Console.WriteLine("El personaje " + legion[i].nom + "  pertenece a la faccion la   Legión Oscura");
                    Console.WriteLine("");
                }
                if (leer[i].ciudadanos > 0 && leer[i].ciudadanos< 200 && leer[i].criminales < 150)
                {
                    Console.WriteLine(leer[i].nom + "  No pertenece a ninguna facción");
                }
            }
        }
        static void Cualidade(leer[] leer, armada[] armada, legion[] legion, int cant)
        {

                for (int h = 0; h < cant; h++)
                {
                    if (leer[h].status == "legion")
                    {

                        legion[h].nom = leer[h].nom;

                        Console.WriteLine("Ingrese poder de habilidad del personaje : " + legion[h].nom);
                        legion[h].poder = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese fuerza del personaje :    " + legion[h].nom);
                        legion[h].fuerza = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese celeridad del personaje : " + legion[h].nom);
                        legion[h].celeridad = int.Parse(Console.ReadLine());

                    }
                    if (leer[h].status == "armada")
                    {

                            armada[h].nom = leer[h].nom;

                            Console.WriteLine("Ingrese habilidades a caballo del personaje : " + armada[h].nom);
                            armada[h].hcaballo = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese arqueria del personaje : " + armada[h].nom);
                            armada[h].arqueria = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese navegacion del personaje : " + armada[h].nom);
                            armada[h].navegacion = int.Parse(Console.ReadLine());

                        
                    }
                }
            
        }
        static void aumentoarmada(leer[] leer, armada[] armada, legion[] legion, int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                if (leer[i].status == "armada")
                {
                    
                    armada[i].hcaballo = armada[i].hcaballo + armada[i].hcaballo * 25 / 100;
                    armada[i].arqueria = armada[i].arqueria + armada[i].arqueria * 25 / 100;
                    armada[i].navegacion = armada[i].navegacion + armada[i].navegacion * 25 / 100;
                    Console.WriteLine("");
                    Console.WriteLine("  AUMENTO DE ARMADA  ");
                    Console.WriteLine("");
                    Console.WriteLine("Se aumento 25 % a sus habilidades a caballo, arquería y navegación");
                    Console.WriteLine("Por ende despues del aumento los valores serian los siguientes : ");
                    Console.WriteLine("");
                    Console.WriteLine("Nombre : " + armada[i].nom);
                    Console.WriteLine("habilidades a caballo : " + armada[i].hcaballo);
                    Console.WriteLine("Arqueria  :  " + armada[i].arqueria);
                    Console.WriteLine("Navegacion : " + armada[i].navegacion);
                    Console.WriteLine("");
                    
                }
            }
        }
        static void aumentolegion(leer[] leer, armada[] armada, legion[] legion, int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                if (leer[i].status == "legion")
                {
                    legion[i].fuerza = legion[i].fuerza + legion[i].fuerza * 20 / 100;
                    legion[i].celeridad = legion[i].celeridad + legion[i].celeridad * 20 / 100;
                    legion[i].poder = legion[i].poder + legion[i].poder * 20 / 100;

                    Console.WriteLine("");
                    Console.WriteLine("   AUMENTO DE LEGION   ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Se aumento 20 % a sus poder de habilidad, fuerza y celeridad");
                    Console.WriteLine("Por ende despues del aumento los valores serian los siguientes : ");
                    Console.WriteLine("");
                    Console.WriteLine("Nombre : " + legion[i].nom);
                    Console.WriteLine("poder de habilidad : " + legion[i].poder);
                    Console.WriteLine("fuerza  :  " + legion[i].fuerza);
                    Console.WriteLine("celeridad : " + legion[i].celeridad);
                    Console.WriteLine("");
                }
            }
        }
        static void final(leer[] leer, armada[] armada, legion[] legion, int cant)
        {
            int legionsum = 0;
            int armadasum = 0;

            for (int i = 0; i < cant; i++)
            {
                legionsum = legion[i].poder + legion[i].fuerza + legion[i].celeridad ;
                armadasum = armada[i].hcaballo + armada[i].arqueria + armada[i].navegacion;
            }

            for (int l = 0; l < cant; l++)
            {
                if (armadasum > legionsum && leer[l].status == "armada")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Gano  ARMADA REAL ");
                    Console.WriteLine("");
                    Console.WriteLine("");

                        armada[l].hcaballo = armada[l].hcaballo + armada[l].hcaballo * 30 / 100;
                        armada[l].arqueria = armada[l].arqueria + armada[l].arqueria * 30 / 100;
                        armada[l].navegacion = armada[l].navegacion + armada[l].navegacion * 30 / 100;

                        Console.WriteLine("");
                        Console.WriteLine("NOMBRE : " + armada[l].nom);
                        Console.WriteLine("");
                        Console.WriteLine("Habilidades a caballo : " + armada[l].hcaballo);
                        Console.WriteLine("Arqueria : " + armada[l].arqueria);
                        Console.WriteLine("Navegacion : " + armada[l].navegacion);
                        Console.WriteLine("");


                }

                if (legionsum > armadasum && leer[l].status == "legion")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Gano  LEGION OSCURA ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");

                        legion[l].fuerza = legion[l].fuerza + legion[l].fuerza * 30 / 100;
                        legion[l].poder = legion[l].fuerza + legion[l].fuerza * 30 / 100;
                        legion[l].celeridad = legion[l].celeridad + legion[l].celeridad * 30 / 100;
                       

                        Console.WriteLine("NOMBRE : " + legion[l].nom);
                        Console.WriteLine("Poder de habilidad : " + legion[l].poder);
                        Console.WriteLine("Fuerza  :  " + legion[l].fuerza);
                        Console.WriteLine("Celeridad : " + legion[l].celeridad);

                }
                if (legionsum == armadasum)
                {

                        Console.WriteLine("Empate. Los equipos empataron , por lo tanto no se aumenta nada. No hay ganador");
                        Console.WriteLine("");

                            Console.WriteLine("");
                            Console.WriteLine("Habilidades a caballo : " + armada[l].hcaballo);
                            Console.WriteLine("Arqueria : " + armada[l].arqueria);
                            Console.WriteLine("Navegacion : " + armada[l].navegacion);
                            Console.WriteLine("");
                        

                            Console.WriteLine("");
                            Console.WriteLine("Poder de habilidad :  " + legion[l].poder);
                            Console.WriteLine("Fuerza  :  " + legion[l].fuerza);
                            Console.WriteLine("Celeridad : " + legion[l].celeridad);
                            Console.WriteLine("");
                }

            }
        }
            static void Main(string[] args)
                {

                    int cant;
                    int op;

                    Console.WriteLine("Ingrese la cantidad de personajes");
                    cant = int.Parse(Console.ReadLine());

                    leer[] leer = new leer[cant];
                    armada[] armada = new armada[cant];
                    legion[] legion = new legion[cant];

                    lee(leer, armada, legion, cant);
                    do
                    {
                        Console.WriteLine("1. Facción a la que pertenece");
                        Console.WriteLine("2. Asignar Cualidades");
                        Console.WriteLine("3. Aumento Armadas Reales");
                        Console.WriteLine("4. Aumento Legiones");
                        Console.WriteLine("5. Encuentro Final");
                        Console.WriteLine("");
                        Console.WriteLine("6. Salir");
                        Console.WriteLine("Ingrese una opción");
                        op = int.Parse(Console.ReadLine());
                        switch (op)
                        {
                            case 1:
                                Console.Clear();
                                faccionpert(leer, armada, legion, cant);
                                break;
                            case 2:
                                Console.Clear();
                                Cualidade(leer, armada, legion, cant);
                                break;
                            case 3:
                                Console.Clear();
                                aumentoarmada(leer, armada, legion, cant);
                                break;
                            case 4:
                                Console.Clear();
                                aumentolegion(leer, armada, legion, cant);
                                break;
                            case 5:
                                Console.Clear();
                                final(leer, armada, legion, cant);
                                break;
                            case 6:
                                Console.Clear();
                                Console.WriteLine("Usted eligio la opcion salir");

                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Esta opcion es invalida , ingrese otro valor ");
                                Console.WriteLine("");
                                break;
                        }
                    } while (op != 6);
                }
            }        
        }
    

