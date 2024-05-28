}using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Controldeacceso
{
    internal class Program
    {

        static double Cobro(int vehiculo, int cantVehiculo)
        {
            double valorBase = 0;

            switch (vehiculo)
            {
                case 1:
                    valorBase = 100;
                    break;

                case 2:
                    valorBase = cantVehiculo * 800;
                    break;

                case 3:
                    valorBase = cantVehiculo * 1000;
                    break;

                case 4:
                    valorBase = cantVehiculo * 1500;
                    break;

                case 5:
                    valorBase = cantVehiculo * 5000;
                    break;

                case 6:
                    valorBase = cantVehiculo * 1200;
                    break;

                default:
                    Console.WriteLine("ERROR: Opcion no valida");
                    break;
            }

            return valorBase;
        }


        static double Porc(int cantDias, double valorBase)
        {
            double porcentaje = 0;

            switch (cantDias)
            {
                case 1:
                    porcentaje = valorBase * 1.00;
                    break;

                case 2:
                    porcentaje = valorBase * 1.20;
                    break;

                case 3:
                    porcentaje = valorBase * 2.20;
                    break;

                case 4:
                    porcentaje = valorBase * 3.20;
                    break;


            }

            if (cantDias >= 5 && cantDias <= 10)
            {
                porcentaje = valorBase * 3.80;

            }

            return porcentaje;

        }

        static double Impuestos(double iva, double impBoludo, double porcentaje)
        {
            double valorFinal = 0;

            valorFinal = porcentaje + ((porcentaje * iva) * impBoludo);

            return valorFinal;

        }



        static void Main(string[] args)
        {
            double rec = 0;
            double mayorTicket = 0;
            int ticket, cantVehiculo, tipoVehiculo, cantDias;
            int total;

            Console.WriteLine("Ticket valido? 1.Si 0.No");
            ticket = Convert.ToInt32(Console.ReadLine());

            if (ticket == 0)
            {
                Console.WriteLine("Ingrese tipo de vehiculo 1.NINGUNO 2.MOTO 3.AUTO 4.CAMIONETA 5.BUGY 6.VEHICULO NAUTICO 0.SALIR");
                tipoVehiculo = Convert.ToInt32(Console.ReadLine());

                while (tipoVehiculo != 0)
                {
                    // metodo 1
                    Console.WriteLine("Ingrese cantidad de vehiculos: "); 
                    cantVehiculo = Convert.ToInt32(Console.ReadLine());
                    //Cobro(tipoVehiculo, cantVehiculo);

                    // metodo 2
                    Console.WriteLine("Ingrese cantidad de dias: ");
                    cantDias = Convert.ToInt32(Console.ReadLine());
                    //Porc(cantDias, Cobro(tipoVehiculo, cantVehiculo));

                    // metodo 3
                    Console.WriteLine("COSTO FINAL: ");
                    Console.WriteLine(Impuestos(0.21, 0.15, Porc(cantDias, Cobro(tipoVehiculo, cantVehiculo))));


                    Console.WriteLine("Ingrese tipo de vehiculo 1.NINGUNO 2.MOTO 3.AUTO 4.CAMIONETA 5.BUGY 6.VEHICULO NAUTICO 0.SALIR");
                    tipoVehiculo = Convert.ToInt32(Console.ReadLine());

                }

            }
            else if (ticket == 1)
            {
                Console.WriteLine("Ticket valido.");
            }



        }
    }
}