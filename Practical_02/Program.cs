using System.Text.RegularExpressions;

namespace Practical_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //1
            Console.WriteLine("Task1:\nLogin:");
            string login = Console.ReadLine();

            var log = new Regex(@"^[A-Za-z][A-Za-z0-9]{1,9}$");

            if (log.IsMatch(login))
            {
                Console.WriteLine($"Логін коректний\nLogin: {login}");
            }
            else
            {
                Console.WriteLine("Логін некоректний. Він повинен містити від 2 до 10 символів, тільки літери і цифри, і не починатися з цифри.");
            }

            //2
            string str = "кінь стоїть, коню поїсти дали, коня покупали, коник грається";

            string sth = @"\b(кінь|коник|коню|коня|конем|коневі|коні|коней|коням|конями)\b";

            string str2 = Regex.Replace(str, sth, new MatchEvaluator(Replace), RegexOptions.IgnoreCase);
            Console.WriteLine($"Task2:\n{str}");
            Console.WriteLine(str2);

            static string Replace(Match match)
            {
                string word = match.Value.ToLower();
                switch (word)
                {
                    case "кінь":
                        return "кіт";
                    case "коник":
                        return "котик";
                    case "коню":
                        return "коту";
                    case "конем":
                        return "котом";
                    case "коневі":
                        return "котові";
                    case "коні":
                        return "коти";
                    case "коней":
                        return "котів";
                    case "коням":
                        return "котам";
                    case "конями":
                        return "котами";
                    case "коня":
                        return "кота";
                    default:
                        return word;
                }

            }
        }
    }
}
    
