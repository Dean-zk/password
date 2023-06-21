using System;
using System.Text;
using System.Transactions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static List<char> chars = new List<char>();
        static void Main(string[] args)
        {
            addChars(ref chars);
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Loading");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".\n");
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Enter the length of the password");
                int length = 0;
                Console.ForegroundColor = ConsoleColor.White;
                if (int.TryParse(Console.ReadLine(), out length))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Your Password: " + generatePassword(length)); ;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("-----------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You can copy your password with CTRL + c");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("Press any key to restart");
                    Console.BackgroundColor = ConsoleColor.Black;
                    ConsoleKeyInfo Input = Console.ReadKey();
                    Console.Clear();


                }
            }
            static string generatePassword(int length)
            {
                StringBuilder sb = new StringBuilder();
                Random rnd = new Random();
                int j = 0;
                while (j < length)
                {
                    sb.Append(chars[rnd.Next(0, chars.Count)]);
                    j++;

                }

                return sb.ToString();
            }
            static void addChars(ref List<char> chars)
            {
                for (char c = 'a'; c <= 'z'; c++)
                {
                    chars.Add(c);
                }
                for (char c = 'A'; c <= 'Z'; c++)
                {
                }
                for (char c = '?'; c >= '!'; c--)

                {
                    chars.Add(c);
                }

                for (char c = '0'; c <= '9'; c++)
                {
                    chars.Add(c);
                }
            }
        }
    }
}
