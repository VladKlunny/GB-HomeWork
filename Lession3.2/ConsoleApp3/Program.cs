using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[5, 2];
            array[0, 0] = new string("Vlad");
            array[0, 1] = new string("8236385683 Vlad@gmail.com");
            array[1, 0] = new string("Andre");
            array[1, 1] = new string("8213234532 Andre@gmail.com");
            array[2, 0] = new string("Anastasiya");
            array[2, 1] = new string("8123123456 Anastasiya@gmail.com");
            array[3, 0] = new string("Ilya");
            array[3, 1] = new string("8923642343 Ilya@gmail.com");
            array[4, 0] = new string("Dasha");
            array[4, 1] = new string("8278034647 Dasha@gmail.com");
            Console.WriteLine($"{array[0, 0]} {array[0, 1]}");
            Console.WriteLine($"{array[1, 0]} {array[1, 1]}");
            Console.WriteLine($"{array[2, 0]} {array[2, 1]}");
            Console.WriteLine($"{array[3, 0]} {array[3, 1]}");
            Console.WriteLine($"{array[4, 0]} {array[4, 1]}");

        }
    }
}
