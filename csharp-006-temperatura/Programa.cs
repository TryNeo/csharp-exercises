
using System;
using System.Globalization;

class Programa
{
    static void Main()
    {
        Console.Write("Ingresa celsius: ");
        string? num1 = Console.ReadLine();

        if (decimal.TryParse(num1,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out decimal resultado1))
        {
            decimal fahrenheit = (resultado1 * 9/5) + 32;
            Console.WriteLine($"La temperatura en fahrenheit es: {fahrenheit}");
        }
        else
        {
            Console.WriteLine("Debes ingresar un número válido.");
        }
    }
}