using System;

namespace Ejercicio1
{
    class Programiii
    {
        static void Main(string[]args)
        {
            // Determinar si un número es Par o Impar en C#
            Console.Write("Introduce un número: ");
            int num = int.Parse(Console.ReadLine()); 

             
            if(num % 2 == 0)
            {
                Console.Write("El número " + num + " es Par.");
            }
            else
            {
                Console.Write("El número " + num + " es Impar.");
            }
        }
    }
}


    

