using System;
using System.Collections.Generic;
using System.Text;
 
namespace Practica
{
    class Ejercicio01
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultado;
 
            do
            {
 
                Console.Write("Digite un número positivo: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite otro número positivo: ");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1 + numero2;
                if (numero1 != 0 || numero2 != 0)
 
                    Console.WriteLine("El resultado es: {0} ", resultado);
 
            } while (numero1 != 0 || numero2 != 0);
            Console.WriteLine("Haga clic para salir del programa...");
        }
    }
}