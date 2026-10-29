public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        int lengthSubjects = subjects.Length;
        if (lengthSubjects == 0){
            return [];
        }
        string[] proverb = new string[lengthSubjects];
        int count=0;
        if (lengthSubjects == 1){
            proverb[0] = $"And all for the want of a {subjects[0]}.";
        }else{
            for (int i = 0; i < lengthSubjects; i++)
            {
                count+=1;
                if (count == lengthSubjects){
                    proverb[i] = $"And all for the want of a {subjects[0]}.";
                }else{
                    proverb[i] = $"For want of a {subjects[i]} the {subjects[i+1]} was lost.";
                }
            }
        }
        return proverb;
    }
}