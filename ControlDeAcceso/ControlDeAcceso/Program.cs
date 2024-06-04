using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Guia8
{
    internal class Program
    {

        public static int BusquedaSecuencial(int[] listado, int valor)
        {
            int i = 0;
            int pos = -1;
            while ((pos == -1) && (i < listado.Length))
            {
                if (listado[i] == valor)
                {
                    pos = i;
                }
                i++;
            }
            return pos;
        }



        static void Main(string[] args)
        {
            int opcion, aux;
            int[] listado;

            Console.WriteLine("Defina la cantida de numeros a ingresar: ");
            listado = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < listado.Length; i++)
            {
                Console.WriteLine("Ingrese numero en la posicion {0}: ", i);
                listado[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elija una opcion:\n 1.MOSTRAR LISTADO ORDENADO \n 2.BUSCAR UN ELEMENTO DEL LISTADO");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {

                case 1:
                    Console.WriteLine("LISTA ORDENADA: ");
                    for (int i = 0; i < listado.Length - 1; i++)
                    {
                        for (int j = i+1; j< listado.Length; j++)
                        {
                            if (listado[i] > listado[j])
                            {
                                aux = listado[i];
                                listado[i] = listado[j];
                                listado[j] = aux;
          
                            }
                        }
                    }
                    for (int i = 0; i < listado.Length; i++)
                    {
                        Console.WriteLine(listado[i]);
                    }
                break;

                case 2:
                    Console.WriteLine("¿Que valor desea encontrar?");
                    int busqueda = Convert.ToInt32(Console.ReadLine());
                    if (BusquedaSecuencial(listado, busqueda) == -1)
                    {
                        Console.WriteLine("El dato no se encontro");
                    }
                    else 
                    {
                        Console.WriteLine("EL RESULTADO SE ENCUENTRA EN LA POSICION: "+BusquedaSecuencial(listado, busqueda));
                    }
                break;
            }

            Console.ReadKey();
        }
    }
}