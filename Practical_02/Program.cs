using System.Text.RegularExpressions;

namespace Practical_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Login:");
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

            
        }
    }
}
