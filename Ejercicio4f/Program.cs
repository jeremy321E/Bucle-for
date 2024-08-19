using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Imprimir las tablas de multiplicar del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                // Imprimir el encabezado de la tabla actual
                Console.WriteLine($"Tabla de multiplicar del {i}:");

                // Bucle anidado para calcular y mostrar la tabla de multiplicar para el número actual
                for (int j = 1; j <= 10; j++)
                {
                    // Calcular el resultado de la multiplicación
                    int resultado = i * j;

                    // Mostrar el resultado
                    Console.WriteLine($"{i} x {j} = {resultado}");
                }

                // Línea en blanco para separar las tablas
                Console.WriteLine();
            }
        }
    }
}
