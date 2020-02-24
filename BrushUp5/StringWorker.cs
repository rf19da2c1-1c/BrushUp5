using System;
using System.Text;

namespace BrushUp5
{
    internal class StringWorker
    {
        public void Start()
        {
            String str = "all of you, we are working with strings";

            String fullStr = "Hello " + str;
            Console.WriteLine("Full String : " + fullStr);

            int letterCount = str.Length;
            Console.WriteLine("Count alle tegn : " + letterCount);
            int letterCountNoBlanks = str.Replace(" ", "").Length;
            Console.WriteLine("Count tegn minus mellemrum : " + letterCountNoBlanks);

            String UPPERSTR = fullStr.ToUpper();
            Console.WriteLine("UPPER String : " + UPPERSTR);

            int placeIndex = str.IndexOf("we");
            Console.WriteLine("Where is we : " + placeIndex);

            String subString = str.Substring(placeIndex);
            Console.WriteLine("Sub string : " + subString);

            Console.WriteLine("String holds peter : " + str.Contains("peter"));
            Console.WriteLine("String holds with : " + str.Contains("with"));

            Console.WriteLine("str starts with Hello : " + str.StartsWith("Hello"));
            Console.WriteLine("fullstr starts with Hello : " + fullStr.StartsWith("Hello"));

            String newStr = str.Replace("we", "you");
            Console.WriteLine("we exchange with you : " + newStr);

            /*
             * on str = null you cannot call ANY methods
             * on str = "", you can call any methods e.g. str.Length
             */

            string pstr = "peter";
            string pstr2 = "peter";

            bool strequals = pstr.Equals(pstr2);
            Console.WriteLine("peter is equal to peter " + strequals);

            string Pstr = "Peter";
            int largest = pstr.CompareTo(Pstr);
            Console.WriteLine("order of peter and Peter " + largest);

            String revers = "";
            revers = Revers(pstr); // made as a method
            Console.WriteLine("Reverse of peter : " + revers);

            String palindromUk = "rotor";
            Console.WriteLine("rotor is palindrom " + (palindromUk.Equals(Revers(palindromUk))));
            String palindromDk = "regninger";
            Console.WriteLine("regninger is palindrom " + (palindromDk.Equals(Revers(palindromDk))));

            String[] noOfWords = str.Split(' ');
            Console.WriteLine("No of words in str is : " + noOfWords.Length);
            Console.WriteLine("The third word " + noOfWords[2]);

            StringBuilder sb = new StringBuilder();
            sb.Append("apple");
            sb.Append(",");
            sb.Append("orange");
            sb.Append(",");
            sb.Append("pear");
            sb.Append(",");
            sb.Append("banana");
            Console.WriteLine("Use of string builder : " + sb.ToString());

            String nullStr = null;
            Console.WriteLine("Is string is null = " + (nullStr == null));
            String emptyStr = "";
            Console.WriteLine("Is string is empty = " + (nullStr == ""));
            Console.WriteLine("Is string is null or empty = " + string.IsNullOrEmpty(emptyStr));

            String withBlanks = "       with spaces  ";
            Console.WriteLine("Before remove :" + withBlanks + ":");
            Console.WriteLine("After remove :" + withBlanks.Trim() + ":");



        }

        private string Revers(string pstr)
        {
            string revers = "";
            foreach (char c in pstr.ToCharArray())
            {
                revers = c + revers;
            }

            return revers;
        }
    }
}