using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            var simple_logical = new Regex(@"^(true|false)$", RegexOptions.IgnoreCase);

            string inputString = "true";
            Console.WriteLine("Ex1:\n\t\ttrue|false");
            Console.WriteLine("\t\tinputString= " + inputString);
            MatchCollection matches1 = simple_logical.Matches(inputString);

            if (matches1.Count > 0)
            {
                foreach (Match match in matches1)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Вираз не знайдено");
            }

            //2
            Regex simple_indentifier = new Regex(@"^([a-z])$", RegexOptions.IgnoreCase);

            inputString = "ffff";
            Console.WriteLine("Ex2:\n\t\t[a-z]");
            Console.WriteLine("\t\tinputString= " + inputString);
            MatchCollection matches2 = simple_indentifier.Matches(inputString);
            if (matches2.Count > 0)
            {
                foreach(Match match in matches2)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Вираз не знайдено");
            }

            //3
            Regex not_simple_logical = new Regex(@"^((not)(\s))?((true|false)|[a-z])$", RegexOptions.IgnoreCase);

            inputString = "not FALSE";
            Console.WriteLine("Ex3:\n\t\tnot (true|false)|[a-z])");
            Console.WriteLine("\t\tinputString= " + inputString);
            MatchCollection matches3 = not_simple_logical.Matches(inputString); 
            if (matches3.Count > 0)
            {
                foreach( Match match in matches3)
                    Console.WriteLine(match.Value);
                Console.WriteLine("Це простий логічний вираз");
            }
            else
            {
                Console.WriteLine("Це НЕ простий логічний вираз");
            }

            //4
            Regex operation_sign = new Regex(@"^(not\s)?((true|false)|[a-z])(\s(and|or)\s(not\s)?((true|false)|[a-z]))*$", RegexOptions.IgnoreCase);

            inputString = "s and true";
            Console.WriteLine("Ex4:\n\t\tsimple_indentifier and|or simple_identifier2");
            Console.WriteLine("\t\tinputString= " + inputString);
            MatchCollection matches4 = operation_sign.Matches(inputString);
            if (matches4.Count > 0)
            {
                foreach (Match match in matches4)
                    Console.WriteLine(match.Value);
                Console.WriteLine("Це логічний вираз");
            }
            else
            {
                Console.WriteLine("Це НЕ логічний вираз");
            }
        }
    }
}
