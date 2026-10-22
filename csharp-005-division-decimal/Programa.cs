
using System;
using System.Globalization;

class Programa
{
    static void Main()
    {
        Console.Write("Ingresa número 1: ");
        string? num1 = Console.ReadLine();

        Console.Write("Ingresa número 2: ");
        string? num2 = Console.ReadLine();

        if (decimal.TryParse(num1,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out decimal resultado1) &&
            decimal.TryParse(num2,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out decimal resultado2))
        {
            if (resultado2 != 0)
            {
                decimal division = resultado1 / resultado2;
                Console.WriteLine($"El resultado de la división es: {division}");
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }
        }
        else
        {
            Console.WriteLine("Debes ingresar dos números válidos.");
        }
    }
}
