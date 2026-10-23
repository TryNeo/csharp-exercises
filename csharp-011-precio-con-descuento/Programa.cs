
using System;
using System.Diagnostics;
using System.Globalization;

class Programa
{
    static void Main()
    {
        Console.Write("Ingresa numero1: ");
        string? num1 = Console.ReadLine();

        Console.Write("Ingresa numero2: ");
        string? num2 = Console.ReadLine();

        if (decimal.TryParse(num1,
                NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out decimal resultado1)  && int.TryParse(num2,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out int resultado2))
        {
            
            if (resultado1 < 0)
            {
                Console.WriteLine("El precio no puede ser negativo.");
                return;
            }

            if (resultado2 < 0 || resultado2 > 100)
            {
                Console.WriteLine("El porcentaje de descuento debe estar entre 0 y 100.");
                return;
            }
           decimal descuento = resultado1 * (resultado2 / 100);
           decimal precioFinal = resultado1 - descuento;
           Console.WriteLine($"El precio final con descuento es: {Math.Round(precioFinal, MidpointRounding.AwayFromZero)}");
        }
        else
        {
            Console.WriteLine("Debes ingresar un número válido.");
        }
    }
}