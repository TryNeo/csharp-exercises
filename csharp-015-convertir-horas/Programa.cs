
using System;

class Programa
{
    static void Main()
    {   
        string horasformato = "07:05:45PM";
        string horas24 = ConvertirFormato24Horas(horasformato);
        Console.WriteLine($"Formato 24 horas: {horas24}");
    }

    static string ConvertirFormato24Horas(string horasformato)
    {
        string[] partes = horasformato.Split(':');
        int horas = int.Parse(partes[0]);
        int minutos = int.Parse(partes[1]);
        int segundos = int.Parse(partes[2].Substring(0, 2));
        string ampm = partes[2].Substring(2, 2);

        if (ampm == "PM" && horas < 12)
        {
            horas += 12;
        }
        else if (ampm == "AM" && horas == 12)
        {
            horas = 0;
        }

        return $"{horas:D2}:{minutos:D2}:{segundos:D2}";
    }
}