public static class Darts
{
    public static int Score(double x, double y)
    {
        double distancia = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        int puntos;
        switch (distancia)
        {
            case <= 1:
                puntos = 10;
                break;
        
            case <= 5:
                puntos = 5;
                break;
        
            case <= 10:
                puntos = 1;
                break;
        
            default:
                puntos = 0;
                break;
        }
        return puntos;
    }
}
