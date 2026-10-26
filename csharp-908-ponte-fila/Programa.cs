public static class LineUp
{
    public static string Format(string name, int number) 
    {
        if (number % 100 is 11 or 12 or 13)
        {
            return $"{name}, you are the {number}th customer we serve today. Thank you!";
        }
        return number.ToString()[^1] switch
        {
            '1'=> $"{name}, you are the {number}st customer we serve today. Thank you!",
            '2'=> $"{name}, you are the {number}nd customer we serve today. Thank you!",
            '3' => $"{name}, you are the {number}rd customer we serve today. Thank you!",
            _=> $"{name}, you are the {number}th customer we serve today. Thank you!",
        };
    }
}
