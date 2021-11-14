using System;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[5, 5];
            for (int i = 0; i<a.GetLength(0); i++)
            {
                Console.Write(a[i, i] + "");
            }
        }
    }
}
