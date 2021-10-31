using System;

namespace lession2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, введите пожайлуста минимальную температуру за сутки");
            string minT = Console.ReadLine();
            int min = Convert.ToInt32(minT);
            Console.WriteLine("Введите пожайлуста максимальную температуру за сутки");
            string maxT = Console.ReadLine();
            int max = Convert.ToInt32(maxT);
            Console.WriteLine($"Средняя температура за сутки [{(min + max)/2}]");
        }
    }
}
