using System;

class Programa
{
	static void Main()
	{
        Console.Write("Ingresa tu nombre: ");
        string? nombre = Console.ReadLine();
        if (string.IsNullOrEmpty(nombre))
        {
            Console.WriteLine("Nombre no proporcionado.");
        } else
        {
		    Console.WriteLine("Hello, " + nombre.Trim() + "!");
        }
	}
}
