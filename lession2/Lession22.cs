using System;

namespace Lession22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, напишите пожайлуста порядковый номер текущего месяца года");
            string x = Console.ReadLine();
            int n = Convert.ToInt32(x);
            string mount = "";
            switch (n)
            {
                case 0:
                    mount = "Нет такого месяца";
                    break;
                case 1:
                    mount = "Январь";
                    break;
                case 2:
                    mount = "Февраль";
                    break;
                case 3:
                    mount = "Март";
                    break;
                case 4:
                    mount = "Апрель";
                    break;
                case 5:
                    mount = "Май";
                    break;
                case 6:
                    mount = "Июнь";
                    break;
                case 7:
                    mount = "Июль";
                    break;
                case 8:
                    mount = "Август";
                    break;
                case 9:
                    mount = "Сентябрь";
                    break;
                case 10:
                    mount = "Октябрь";
                    break;
                case 11:
                    mount = "Ноябрь";
                    break;
                case 12:
                    mount = "Текущий месяц 'Декабрь'";
                    break;
            }
            Console.WriteLine(mount);

        }
    }
}
