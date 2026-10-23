
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

        Console.Write("Ingresa numero3: ");
        string? num3 = Console.ReadLine();


        if (int.TryParse(num1,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out int resultado1) && int.TryParse(num2,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out int resultado2) && int.TryParse(num3,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out int resultado3))
        {
            int maximo = resultado1;

            if (resultado2 > maximo)
            {
                maximo = resultado2;
            }

            if (resultado3 > maximo)
            {
                maximo = resultado3;
            }

            Console.WriteLine($"El número máximo es: {maximo}");
        }
        else
        {
            Console.WriteLine("Debes ingresar un número válido.");
        }
    }
}