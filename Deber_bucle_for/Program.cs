using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber_bucle_for
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Bucle for que recorre los números del 1 al 100
            for (int i = 1; i <= 100; i++)
            {
                // Verificar si el número es par
                if (i % 2 == 0)
                {
                    // Imprimir el número si es par
                    Console.WriteLine(i);
                }
            }
        }
    }
}
