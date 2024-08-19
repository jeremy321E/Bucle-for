using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Número de términos a mostrar en la serie de Fibonacci
            int numTerminos = 10;

            // Variables para almacenar los términos de la serie de Fibonacci
            int a = 0;
            int b = 1;

            // Mostrar el primer término de la serie
            Console.WriteLine("Serie de Fibonacci hasta el décimo término:");

            // Imprimir el primer término
            Console.WriteLine(a);

            // Imprimir el segundo término
            Console.WriteLine(b);

            // Calcular e imprimir los términos restantes
            for (int i = 3; i <= numTerminos; i++)
            {
                int siguiente = a + b; // Calcular el siguiente término
                Console.WriteLine(siguiente); // Imprimir el siguiente término

                // Actualizar los valores de a y b
                a = b;
                b = siguiente;
            }
        }
    }
}
