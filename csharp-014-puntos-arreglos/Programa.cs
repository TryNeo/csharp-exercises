
using System;

class Programa
{
    static void Main()
    {
        List<int> alice = new List<int>{4,4,6};
        List<int> bob = new List<int>{3,3,7};
        int alicePoints = 0;
        int bobPoints = 0;
        for (int i = 0; i < alice.Count; i++)
        {
            if (alice[i] > bob[i])
            {
                alicePoints++;
            }
            else if (alice[i] < bob[i])
            {
                bobPoints++;
            }
            else
            {
                alicePoints += 0;
                bobPoints += 0;
            }
        }
        Console.WriteLine($"Alice: {alicePoints}, Bob: {bobPoints}");
    }
}