using System;

namespace csharp_904_log_analisis_substraer
{
    static class Programa
    {
        static void Main()
        {
            Console.WriteLine(SuccessRate(10));
            Console.WriteLine(ProductionRatePerHour(6));
            Console.WriteLine(WorkingItemsPerMinute(6));
        }

        public static double SuccessRate(int speed)
        {
            switch (speed)
            {
                case 0:
                    return 0.0;
                case 1:
                case 2:
                case 3:
                case 4:
                    return 1.0;
                case 5:
                case 6:
                case 7:
                case 8:
                    return 0.90;
                case 9:
                    return 0.80;
                case 10:
                    return 0.77;
                default:
                    return 0.0;
            }
        }

        public static double ProductionRatePerHour(int speed)
        {
            return (speed * 221) * SuccessRate(speed);
        }
        public static int WorkingItemsPerMinute(int speed)
        {
            double res =ProductionRatePerHour(speed) / 60;
            return (int)res;
        }
    }
}