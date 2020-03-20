using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*************************
 * Autor: Noelia Rodríguez Cifuentes
 * Curso: 1DAM-T
 * Asignación: Estructuras de control
 * Fecha asignación: 12 de febrero
 * ************************/

namespace EstructurasControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int num;
            int num2 = 1;
            int par = 0;
            int imp = 0;
            String resultado = "";
            int resultado2 = 1;

            Console.Write("Introduce un número, te diré cuantos números pares e impares tiene: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);

            //
            while (num2 <= num)
            {   //Condición para buscar un número par.
                if (num2 % 2 == 0)
                {
                    par = par + 1;
                    resultado = resultado + num2 + " ";
                }
                else //Condición para buscar un número impar.
                {
                    imp = imp + 1;
                }
                num2++;
            }

            Console.WriteLine("Números pares: " + par);
            Console.WriteLine("Números impares: " + imp);

            //Repite una iteración hasta el número introducido por pantalla.
            for (int i = 1; i <= num; i++)
            {
                //Condición para hacer el producto de los números pares encontrados.
                if (i % 2 == 0)
                {
                    resultado2 = resultado2 * i;
                }

            }
            //Guarda en la variable resultado, el resultado de Resultado2. Resultado2 es el producto de los pares encontrados.
            resultado = resultado + " = " + resultado2.ToString();
            Console.Write("Resultado de la multiplicación de los números pares: " + resultado);
            Console.ReadKey();
        }

    }
}
