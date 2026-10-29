using System.Collections.Generic;
using System.Linq;
public static class BottleSong
{
     static void Main()
    {
        int startBottles = 10;
        int takeDown = 2;
        string[] expected = [
                    "Ten green bottles hanging on the wall,",
                    "Ten green bottles hanging on the wall,",
                    "And if one green bottle should accidentally fall,",
                    "There'll be nine green bottles hanging on the wall.",
                    "",
                    "Nine green bottles hanging on the wall,",
                    "Nine green bottles hanging on the wall,",
                    "And if one green bottle should accidentally fall,",
                    "There'll be eight green bottles hanging on the wall."
                ];
        bool iguales = expected.SequenceEqual(Recite(startBottles, takeDown));
        Console.WriteLine(iguales);
    }

    public static string ConvertNumber(int numero) => numero switch
    {
        1 => "One",
        2 => "Two",
        3 => "Three",
        4 => "Four",
        5 => "Five",
        6 => "Six",
        7 => "Seven",
        8 => "Eight",
        9 => "Nine",
        10 => "Ten",
        _ => "no"
    };

    static string GetBottleWord(int num) => num switch
    {
        1 => $"There'll be {ConvertNumber(num).ToLower()} green bottle hanging on the wall.",
        _ => $"There'll be {ConvertNumber(num).ToLower()} green bottles hanging on the wall.",
    };
    
    public static IEnumerable<string> Recite(int startBottles, int takeDown)
    {
        int count=takeDown-1;
        int sizeArr=4;
        if (takeDown > 1){
            sizeArr=(takeDown*4)+count;
        }
        int num=startBottles;
        string [] songBottles = new string[sizeArr];
        int z = 0;
        for (int i = takeDown; i > 0 ; i--)
        {
            string nameNum=ConvertNumber(num);
            num--;
            string[] songBottle={
                nameNum == "One" ? $"{nameNum} green bottle hanging on the wall," : $"{nameNum} green bottles hanging on the wall,",
                nameNum == "One" ? $"{nameNum} green bottle hanging on the wall," : $"{nameNum} green bottles hanging on the wall,",
                "And if one green bottle should accidentally fall,",
                GetBottleWord(num),
            };
            for (int y=0;y<songBottle.Length; y++)
            {
                songBottles[z] = songBottle[y];
                Console.WriteLine(songBottles[z]);
                z++;
           }
           if (count > 0){
                if (z < sizeArr){
                   songBottles[z] ="";
                   z++;
                   count--;
                }
           }
        }
        return songBottles;
    }
}
