using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*************************
 * Autor: Noelia Rodríguez Cifuentes
 * Curso: 1DAM-T
 * Asignación: Condiciones Compuestas
 * Fecha asignación: 5 de febrero
 * ************************/
namespace CondicionesCompuestasED
{
    class CondicionesCompuestas
    {
        private static void Main(string[] args)
        {
            string mes;

            Console.Write("Ingrese un mes:");
            mes = Console.ReadLine();

            //La función Substring comienza en una posición especificada y tiene una longitud especificada
            if (mes.Substring(0,3).Equals("sep") ||
                mes.Substring(0,3).Equals("oct") ||
                mes.Substring(0,3).Equals("nov") ||
                mes.Substring(0,3).Equals("dic"))
            {
                Console.Write("Primer trimestre");
            }
                  
          else if(mes.Substring(0,3).Equals("ene") ||
                    mes.Substring(0,3).Equals("feb") ||
                    mes.Substring(0,3).Equals("mar"))
            {
                Console.Write("No es del primero, es del segundo trimestre");
            }else if (mes.Substring(0,3).Equals("abr") ||
                     mes.Substring(0,3).Equals("may") ||
                     mes.Substring(0,3).Equals("jun"))
            {
                  Console.Write("No es del primero, es del tercer trimestre");
            }
            // Aunque sólo pide que diga si es del primer trimestre, yo he añadido las demás opciones. 
            Console.ReadKey();
        }
    }
}
