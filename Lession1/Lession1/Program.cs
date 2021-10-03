using System;

namespace Lession1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What`s your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}, today, [{DateTime.Now}]");
        }
    }
}
