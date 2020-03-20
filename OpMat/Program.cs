using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*************************
 * Autor: Noelia Rodríguez Cifuentes
 * Curso: 1DAM-T
 * Asignación: Operación matemática en Csharp
 * Fecha asignación: 19 de febrero
 * ************************/
namespace OperacionesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
             
                double primero = 0;
                double segundo = 0;
                string opcion;
                double result;
                String linea;

                Console.Write("Introduzca un número: ");
                linea = Console.ReadLine();

            if (double.TryParse(linea, out primero))
            {
            
            }
            else
            {
                Console.WriteLine("No es numérico");
                Environment.Exit(2);

            }


                Console.WriteLine("Introduzca una opción: \n- Suma ó + \n- Resta ó -\n- Multiplicación ó * ó x \n- División ó /\n- Resto ó %:");
                linea = Console.ReadLine();
                opcion = (linea);

                Console.WriteLine("Introduzca otro número: ");
                linea = Console.ReadLine();

            if (double.TryParse(linea, out segundo))
            {
              
            }
            else
            {
                Console.WriteLine("No es numérico");
                Environment.Exit(2);

            }

            switch (opcion) { 
             

                    case "+":
                    case "suma":
                            result = primero + segundo;
                            Console.WriteLine("Resultado: " + primero + " + " + segundo + " = " + result);
                            break;
                        
                    case "-":
                    case "resta":
                            result = primero - segundo;
                            Console.WriteLine("Resultado: " + primero + " - " + segundo + " = " + result);
                            break;

                    case "*":
                    case "x":
                    case "multiplicacion":
                    case "multiplicación":
                            result = primero * segundo;
                            Console.WriteLine("Resultado: " + primero + " x " + segundo + " = " + result);
                            break;
                       
                    case "/":
                    case "division":
                    case "división":
                            if (segundo == 0)
                            {
                                Console.WriteLine("Error. no se puede dividir entre 0");
                            }
                            else
                            {
                                result = primero / segundo;
                                Console.WriteLine("Resultado: "+ primero + " / " + segundo + " = " + result);
                            }
                            break;

                    case "resto":
                    case "%":
                            result = primero % segundo;
                            Console.WriteLine("Resultado" + primero + " % " + segundo + " = " + result);
                            break;
                       
                    default:
                            Console.WriteLine("Opción incorrecta");
                            Environment.Exit(1);
                            break;
                }
                Console.ReadKey();
            }
        }
    }
