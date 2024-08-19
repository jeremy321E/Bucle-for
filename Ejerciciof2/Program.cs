using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciof2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese un número
            Console.Write("Ingresa un número entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            // Inicializar la variable que almacenará la suma
            int suma = 0;

            // Bucle for que suma todos los números desde 1 hasta el número ingresado
            for (int i = 1; i <= numero; i++)
            {
                suma += i; // Sumar el valor de i a la variable suma
            }

            // Mostrar la suma total
            Console.WriteLine($"La suma de todos los números desde 1 hasta {numero} es: {suma}");
        }
    }
}
