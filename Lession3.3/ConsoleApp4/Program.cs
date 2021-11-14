using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string s;
            while ((s = Console.ReadLine()) != null)
                Console.WriteLine(new string(s.Reverse().ToArray()));
           
        }
    }
}
