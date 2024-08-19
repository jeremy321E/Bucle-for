using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir un arreglo de números
            int[] numeros = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            // Solicitar al usuario el número a buscar
            Console.Write("Ingrese el número que desea buscar: ");
            int numeroBuscado = int.Parse(Console.ReadLine());

            // Variable para indicar si el número fue encontrado
            bool encontrado = false;

            // Bucle for para buscar el número en el arreglo
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    encontrado = true;
                    break; // Salir del bucle si el número es encontrado
                }
            }

            // Mostrar mensaje indicando si el número fue encontrado o no
            if (encontrado)
            {
                Console.WriteLine("El número fue encontrado en el arreglo.");
            }
            else
            {
                Console.WriteLine("El número no fue encontrado en el arreglo.");
            }
        }
    }
}
