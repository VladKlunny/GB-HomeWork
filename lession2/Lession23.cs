using System;

namespace Lession23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, напишите пожайлуста любое число");
            string x = Console.ReadLine();
            int n = Convert.ToInt32(x);
            int y = n % 2;
            if (y == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }
        }
    }
}
