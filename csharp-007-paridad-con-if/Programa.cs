
using System;
using System.Globalization;

class Programa
{
    static void Main()
    {
        Console.Write("Ingresa numero: ");
        string? num1 = Console.ReadLine();

        if (int.TryParse(num1,
                NumberStyles.Integer,
                CultureInfo.InvariantCulture,
                out int resultado1))
        {
            if (resultado1 % 2 == 0)
            {
                Console.WriteLine($"El número {resultado1} es par.");
            }
            else
            {
                Console.WriteLine($"El número {resultado1} es impar.");
            }
        }
        else
        {
            Console.WriteLine("Debes ingresar un número válido.");
        }
    }
}