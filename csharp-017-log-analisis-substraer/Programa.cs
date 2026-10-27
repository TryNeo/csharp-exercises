using System;

namespace csharp_904_log_analisis_substraer
{
    static class Programa
    {
        static void Main()
        {
            /*SubstringAfter
            var log = "[INFO]: File Deleted.";
            log.SubstringAfter(": "); // => returns "File Deleted."
            */
            /*SubstringBetween
            var log = "[INFO]: File Deleted.";
            log.SubstringBetween("[", "]"); // => returns "INFO"
            */
        }

        public static string SubstringAfter(this string str, string substring){
            int initialPosition = str.IndexOf(substring);
            int finalPosition =  str.Length-initialPosition;
            return str.Substring(initialPosition,finalPosition).Replace(substring, "");
        }
        public static string SubstringBetween(this string str, string substringR1, string substringR2){
            int initialPosition = str.IndexOf(substringR1);
            int finalPosition = str.IndexOf(substringR2);
            int length = finalPosition-initialPosition;
            return str.Substring(initialPosition,length).Replace(substringR1, "").Replace(substringR2, "");
        }

    }
}