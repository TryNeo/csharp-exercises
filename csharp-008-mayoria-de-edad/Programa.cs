
using System;
using System.Globalization;

class Programa
{
    static void Main()
    {
        Console.Write("Ingresa edad: ");
        string? num1 = Console.ReadLine();

        if (int.TryParse(num1,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out int resultado1))
        {
            if (resultado1 >= 18)
            {
                Console.WriteLine($"El número {resultado1} es mayor de edad.");
            }
            else
            {
                Console.WriteLine($"El número {resultado1} es menor de edad.");
            }
        }
        else
        {
            Console.WriteLine("Debes ingresar un número válido.");
        }
    }
}