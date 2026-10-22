using System;

class Programa
{
	static void Main()
	{
        Console.Write("Ingresa el primer número: ");
        string? entrada1 = Console.ReadLine();

        Console.Write("Ingresa el segundo número: ");
        string? entrada2 = Console.ReadLine();

        if (int.TryParse(entrada1, out int num1) &&
            int.TryParse(entrada2, out int num2))
        {
            Console.WriteLine($"La suma es: {num1 + num2}");
        }
        else
        {
            Console.WriteLine("Debes ingresar dos números válidos.");
        }
	}
}
