using System;
/*************************
 * Autor: Noelia Rodríguez Cifuentes
 * Curso: 1DAM-T
 * Asignación: Try Catch Finally con ficheros
 * Fecha asignación: 4 de marzo
 * ************************/
namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\nrcif\Desktop\NOELIA\ENTORNO DESARROLLO\2doTrimestreED\TryCatch\datos.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            int[] numeros;
            string linea;
            int cant = 5;
            numeros = new int[cant];
            Console.WriteLine("Array de " + cant + " números ordenados");
            // Llena un vector de números por pantalla
            Boolean cargando = true;
            int i = 0;

            while (cargando)
            {

                try
                {
                    //Hace una pregunta las veces que hayamos indicado.
                    while (i < numeros.Length)
                    {
                        Console.Write("Ingrese el " + (i + 1) + "º número: ");
                        linea = Console.ReadLine();
                        numeros[i] = Convert.ToInt32(linea);
                        i++;
                    }
                    cargando = false;
                }

                // Excepción que salta cuando el formato introducido es incorrecto.
                catch (FormatException e)
                {
                    Console.WriteLine("Formato de dato incorrecto. Deben ser números");
                    Environment.Exit(1);
                }
                //Excepción que salta cuando el resultado desborda.
                catch (OverflowException e)
                {
                    Console.WriteLine(" El nro. debe ser menor que 100");
                    Environment.Exit(1);
                }
                //Excepción que salta cuando hay un error.
                catch (Exception e)
                {
                    Console.WriteLine("No válido.");
                    Console.WriteLine(e.Message);
                    Environment.Exit(2);
                }


            }
            //Ordena los elementos en una matriz unidimensional
            Array.Sort(numeros);

            System.Console.Write("Lista de números ordenados de menor a mayor:\n");

            //Itera los elementos de un vector.
            foreach (int j in numeros)
            {


                System.Console.WriteLine("{0} ", j);
            }
            Console.Write("Presione una tecla para finalizar");
            linea = Console.ReadLine();


            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.
            System.Console.ReadLine();
        }
    }
}
        
