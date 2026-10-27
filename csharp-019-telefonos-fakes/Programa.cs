using System;

namespace csharp_904_log_analisis_substraer
{
    static class Programa
    {
        static void Main()
        {
            PhoneNumber.Analyze("631-555-1234");
            // => (false, true, "1234")
            PhoneNumber.IsFake(PhoneNumbers.Analyze("631-555-1234"));
            // => true
        }
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            string[] telf = phoneNumber.Split("-");

            return ((telf[0] == "212" ? true : false), (telf[1] == "555" ? true : false),telf[2]);
        }

        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
        {
            (bool __,bool isFake,string _) validate= phoneNumberInfo;
            return validate.isFake;
        }
    }
}