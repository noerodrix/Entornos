using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*************************
 * Autor: Noelia Rodríguez Cifuentes
 * Curso: 1DAM-T
 * Asignación: Pintando la consola
 * Fecha asignación: 4 de marzo
 * ************************/
namespace PintandoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] caras = { "(^.^)", "(-_-)", "(*-*)", "<('.')>", ":)" };
            Random rnd = new Random();



            for (int i = 0; i < 3000; i++)
            {

                //Obtiene o establece un color aleatorio de fondo de la consola.
                Console.BackgroundColor = GetRandomConsoleColor();

                //Obtiene o establece un color aleatorio para las caras
                Console.ForegroundColor = GetRandomConsoleColor();

                //Devuelve un entero que está dentro de un intervalo específico. Coge un color aleatorio para las caras
                int altCol = rnd.Next(0, 2);

                //Posicines aleatoria
                int x = rnd.Next(1, 80);
                int y = rnd.Next(1, 24);

                //Devuelve un entero que está dentro de un intervalo específico. Coge una cara aleatoriamente
                int caracter = rnd.Next(0, 5);

                //Establece la posición del cursor.
                Console.SetCursorPosition(x, y);

                //Imprime
                Console.Write(caras[caracter]);
            }
            //para poner cursor al final de lo escrito
            Console.SetCursorPosition(1, 50);
        }

        //Crea colores aleatorios y coge valores de la función ConsoleColor
        private static ConsoleColor GetRandomConsoleColor()
        {
            Random rnd = new Random();
            var colores = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)colores.GetValue(rnd.Next(colores.Length));
        }
    }
}
