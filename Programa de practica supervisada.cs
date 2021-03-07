using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_practica_s
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2, RESULT;
            string linea;
            Console.WriteLine("Primer numero :");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.WriteLine("Segundo numero :");
            linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            Console.WriteLine();
            RESULT = NUM1 + NUM2;
            Console.WriteLine("La suma es {0} :", RESULT);
            RESULT = NUM1 - NUM2;
            Console.WriteLine("La resta es {0} - {1} = {2} ", NUM1, NUM2, RESULT);
            RESULT = NUM1 * NUM2;
            Console.WriteLine("La multiplicación es :" + RESULT);
            RESULT = NUM1 / NUM2;
            Console.WriteLine("La división es :" + RESULT);
            Console.WriteLine("Presione una tecla:");
            Console.ReadLine();
        }
    }
}
