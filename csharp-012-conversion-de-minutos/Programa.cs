
using System;
using System.Diagnostics;
using System.Globalization;

class Programa
{
    static void Main()
    {
        Console.Write("Ingresa minutos: ");
        string? num1 = Console.ReadLine();

        if (int.TryParse(num1,
                NumberStyles.Integer,
                CultureInfo.InvariantCulture,
                out int resultado1))
        {
            if (resultado1 < 0)
            {
                Console.WriteLine("Debes ingresar un número positivo.");
                return;
            }
            const int minutosPorHora = 60;
            int horas = resultado1 / minutosPorHora;
            int minutosRestantes = resultado1 % minutosPorHora;
            Console.WriteLine($"Horas: {horas}, Minutos: {minutosRestantes}");
        }
        else
        {
            Console.WriteLine("Debes ingresar un número válido.");
        }
    }
}