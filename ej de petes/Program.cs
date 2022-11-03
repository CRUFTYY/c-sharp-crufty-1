using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public struct ventas{
            public int id;
            public float vent;
            public int horas;

        }

        public struct rec
        {
            public int id;           
            public int horas;

        }

         static void pedir(ventas[] ventas1, rec[] rec1,int cantr, int cantv)
         {
             
             for(int i=0; i<cantv; i++)
             {
                 Console.WriteLine("Ingrese id del empleado de Ventas");
                 ventas1[i].id = int.Parse(Console.ReadLine());

                 Console.WriteLine("Ingrese las ventas del empleado");
                 ventas1[i].vent = int.Parse(Console.ReadLine());

                 Console.WriteLine("Ingrese horas del empleado");
                 ventas1[i].horas = int.Parse(Console.ReadLine());
             }

             for (int i = 0; i < cantr; i++)
             {
                 Console.WriteLine("Ingrese id del empleado de Recursos Humanos");
                 rec1[i].id = int.Parse(Console.ReadLine());               

                 Console.WriteLine("Ingrese horas del empleado");
                 rec1[i].horas = int.Parse(Console.ReadLine());
             }



         }



         static void ordenar(ventas[] ventas1, rec[] rec1, int cantr, int cantv) {

             int idv = ventas1[0].id;
             int idr = rec1[0].id;
             int hv = ventas1[0].horas;
             int hr = rec1[0].horas;
             int auxv;
             int auxvh;
             int auxr;
             int auxrh;

             for (int j = 0; j < cantv; j++) {
                 for (int k = 1; k < cantv-1; k++)
                 {
                     if (ventas1[k].id > ventas1[k + 1].id) {
                         auxv = ventas1[k].id;
                         ventas1[k].id = ventas1[k + 1].id;
                         ventas1[k + 1].id = auxv;

                         auxvh = ventas1[k].horas;
                         ventas1[k].horas = ventas1[k + 1].horas;
                         ventas1[k + 1].id = auxvh;
                          
                          
                     }



                 }
             
             
             }



             for (int j = 0; j < cantv; j++)
             {
                 for (int k = 1; k < cantv - 1; k++)
                 {
                     if (rec1[k].id > rec1[k + 1].id)
                     {
                         auxr = rec1[k].id;
                         rec1[k].id = rec1[k + 1].id;
                         rec1[k + 1].id = auxr;

                         auxrh = rec1[k].horas;
                         rec1[k].horas = rec1[k + 1].horas;
                         rec1[k + 1].id = auxrh;


                     }



                 }


             }

             for (int s = 0; s < cantv; s++) {

                 Console.WriteLine("El empleado de ventas ID: " + ventas1[s].id + " Trabaja: " + ventas1[s].horas);
             
             }

             for (int s = 0; s < cantv; s++)
             {

                 Console.WriteLine("El empleado de Recursos ID: " + rec1[s].id + " Trabaja: " + rec1[s].horas);

             }

             Console.ReadKey();


         }


         static void mejor(ventas[] ventas1, rec[] rec1, int cantr, int cantv)
         {
             int idv = ventas1[0].id;
             int idr = rec1[0].id;
             int hv = ventas1[0].horas;
             int hr = rec1[0].horas;

             for (int i = 0; i < cantv; i++)
             {
                 if (hv < ventas1[i].horas)
                 {

                     hv = ventas1[i].horas;
                     idv = ventas1[i].id;
                 }
             }

             for (int i = 0; i < cantv; i++)
             {
                 if (hr < rec1[i].horas)
                 {

                     hr = rec1[i].horas;
                     idr = rec1[i].id;
                 }


             }

             if (hv < hr)
             {

                 Console.WriteLine("El mejor empleado pertenece a REC y es: " + idr + " Con " + hr + " horas trabajadas");


             }
             else {

                 Console.WriteLine("El mejor empleado pertenece a Ventas y es: " + idv + " Con " + hv + " horas trabajadas");
             }

         }


         static void ventast(ventas[] ventas1, int cantv) {

             float ventastotales=0;
             float ganancia;
             int mv=ventas1[0].id;
             float mg=ventas1[0].vent;

             for (int i = 0; i < cantv; i++) {

                 ventastotales = ventastotales + ventas1[i].vent;
             
             
             
             }

             

         
         
         }


         static void Main(string[] args)
         {
             int op;
            int cantv;
            int cantr;
            Console.WriteLine("ingrese cant de empleados en ventas");
            cantv = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese cant de empleados en REC");
            cantr = int.Parse(Console.ReadLine());

            ventas[] ventas1  ;
                ventas1=new ventas[cantv];
            rec[] rec1 ;
            rec1= new rec[cantr];


            pedir(ventas1, rec1, cantr, cantv);


            do
            {
                Console.WriteLine("1-Ordenar");
                Console.WriteLine("2-Mejor Empleado");
                Console.WriteLine("3-Ventas totales");
                op = int.Parse(Console.ReadLine());
                switch(op){
                    case 1: ordenar(ventas1, rec1, cantr, cantv);
                        break;

                    case 2: mejor(ventas1, rec1, cantr, cantv);
                        break;

                    case 3: ventast(ventas1,  cantv); break;

                     }
            } while (op < 4);
        }
    }
}
