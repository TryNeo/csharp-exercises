
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

        Console.Write("Ingresa operacion: ");
        string? operacion = Console.ReadLine();


        if (decimal.TryParse(num1,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out decimal resultado1) && decimal.TryParse(num2,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out decimal resultado2))    
        {
            switch (operacion)
            {
                case "+":
                    Console.WriteLine($"El resultado de la suma es: {resultado1 + resultado2}");
                    break;
                case "-":
                    Console.WriteLine($"El resultado de la resta es: {resultado1 - resultado2}");
                    break;
                case "*":
                    Console.WriteLine($"El resultado de la multiplicación es: {resultado1 * resultado2}");
                    break;
                case "/":
                    if (resultado2 != 0)
                    {
                        Console.WriteLine($"El resultado de la división es: {resultado1 / resultado2}");
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    break;      
            }
        }
        else
        {
            Console.WriteLine("Debes ingresar un número válido.");
        }
    }
}