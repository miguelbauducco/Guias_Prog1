using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Security.AccessControl;

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

        public static void OrdenamientoBurbuja(int[] lista) 
        {
        
            int aux, i, j;
            for (i = 0; i < lista.Length - 1; i++)
            {
                for (j = 0;j<lista.Length; j++)
                {
                    if (lista[i] > lista[j])
                    {
                        aux = lista[i];
                        lista[i] = lista[j];
                        lista[j] = aux;
                    }
                }
            }
        }



        static void Main(string[] args)
        {
            int opcion, busqueda, pos;

            int c = 0;
            string alumnoNotaMayor="";
            string alumnoNotaMenor = "";
            float promedio = 0;
            float mayor = 0;
            float menor = 111111;

            string[] nombres;
            nombres = new string[3];
            int[] nroLibreta;
            nroLibreta = new int[3];
            int[] notas;
            notas = new int[3];

            string[] alumnosProm;
            int[] nroLibretaProm;
            int[] notasProm;

            Console.WriteLine("Ingrese nombres de alumnos: \n");
            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] = Console.ReadLine();
            }

            Console.WriteLine("\nIngrese numero de libreta de alumnos: \n");
            for (int i = 0; i < nroLibreta.Length; i++)
            {
                nroLibreta[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nIngrese las notas de alumnos: \n");
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("\nPromedio de notas: \n");
            for (int i = 0; i < notas.Length; i++)
            {
                promedio = (promedio + notas[i]);
            }
            promedio = promedio / nombres.Length;
            Console.WriteLine(promedio);

            for (int i = 0; notas.Length > i; i++)
            {
                if (notas[i] > promedio)
                {

                    c++;

                }
            }

            alumnosProm = new string[c];
            nroLibretaProm = new int[c];
            notasProm = new int[c];

            for (int i = 0; i < alumnosProm.Length; i++)
            {

                alumnosProm[i] = nombres[i];

            }

            for (int i = 0; i < nroLibretaProm.Length; i++)
            {

                nroLibretaProm[i] = nroLibreta[i];

            }

            for (int i = 0; i < notasProm.Length; i++)
            {

                notasProm[i] = notas[i];

            }




            for (int i = 0; alumnosProm.Length > i; i++)
            {
                Console.WriteLine("\nAlumnos que superaron el promedio:\n" + alumnosProm[i]);
            }

            for (int i = 0; nroLibretaProm.Length > i; i++)
            {
                Console.WriteLine("\nNro de libreta que superaron el promedio:\n" + nroLibretaProm[i]);
            }

            for (int i = 0; notasProm.Length > i; i++)
            {
                Console.WriteLine("\nNotas de alumnos que superaron el promedio:\n" + notasProm[i]);
            }

            
            OrdenamientoBurbuja(nroLibretaProm);

            Console.WriteLine("\nPresione 1 si desea ordenar la lista de alumnos por numero libreta de mayor a menor.\nPresione 2 para buscar por libreta de alumno\nCualquier boton para salir.");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    
                    Console.WriteLine("\nLISTA DE ALUMNOS ORDENADA: \n");
                    for (int i = 0; i < nroLibretaProm.Length; i++)
                    {
                        Console.WriteLine("\nNro de libreta:\n");
                        Console.WriteLine(nroLibreta[i]);
                        Console.WriteLine("\nNombre:\n");
                        Console.WriteLine(alumnosProm[i]);
                        Console.WriteLine("\nNota:\n");
                        Console.WriteLine(notasProm[i]);

                        if (notasProm[i] > mayor)
                        {
                            mayor = notasProm[i];
                            alumnoNotaMayor = alumnosProm[i];
                        }

                        if (notasProm[i] < menor)
                        {
                            menor = notasProm[i];
                            alumnoNotaMenor = alumnosProm[i];
                        }

                    }

                    Console.WriteLine("\n Alumno de mayor nota: " + alumnoNotaMayor);
                    Console.WriteLine("\n Alumno de menor nota: " + alumnoNotaMenor);

                break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese numero de libreta de alumno para su busqueda: \n");
                    busqueda = Convert.ToInt32(Console.ReadLine());
                    pos = (BusquedaSecuencial(nroLibreta, busqueda));
                    Console.WriteLine("\nNumero de libreta:\n");
                    Console.WriteLine(nroLibreta[pos]);
                    Console.WriteLine("\nNombre:\n");
                    Console.WriteLine(nombres[pos]);
                    Console.WriteLine("\nNota:\n");
                    Console.WriteLine(notas[pos]);
                break;
            }




            Console.ReadKey();
        }
    }
}