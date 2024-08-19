using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario la cantidad de números a ingresar
            Console.Write("Ingrese la cantidad de números para calcular el promedio: ");
            int cantidad = int.Parse(Console.ReadLine());

            // Verificar que la cantidad sea válida
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad de números debe ser mayor que cero.");
                return;
            }

            // Variables para almacenar la suma de los números
            double suma = 0;

            // Bucle para ingresar los números
            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                double numero = double.Parse(Console.ReadLine());
                suma += numero; // Sumar el número ingresado
            }

            // Calcular el promedio
            double promedio = suma / cantidad;

            // Mostrar el resultado
            Console.WriteLine($"El promedio de los {cantidad} números ingresados es: {promedio}");
        }
    }
}
