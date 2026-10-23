
using System;

class Programa
{
    static void Main()
    {
        int s = 7;
        int t = 11;
        int a = 5;
        int b = 15;
        int[] apples = { -2, 2, 1 };
        int[] oranges = { 5, -6 };

        countApplesAndOranges(s, t, a, b, apples, oranges);
    }

    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        int appleCount = 0;
        int orangeCount = 0;

        foreach (int apple in apples)
        {
            int landingPosition = a + (apple);
            if (landingPosition >= s && landingPosition <= t)
            {
                appleCount++;
            }
        }

        foreach (int orange in oranges)
        {
            int landingPosition = b + (orange);
            if (landingPosition >= s && landingPosition <= t)
            {
                orangeCount++;
            }
        }
        Console.WriteLine(appleCount);
        Console.WriteLine(orangeCount);
    }
}