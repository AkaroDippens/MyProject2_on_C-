using System;

namespace Практика2
{
    internal class Program
    {
        static string otvet = " ";
        static void Main(string[] args)
        {
            while (true)
            {  
                int operation, perem;
                Console.WriteLine("Выберите программу, которую вы хотите запустить\n" +
                "1. Угадай число\n" +
                "2. Таблица умножения\n" +
                "3. Вывод делителей числа\n" +
                "4. Закрыть программу");
                while (!int.TryParse(Console.ReadLine(), out operation))
                {
                    Console.WriteLine("Ошибка, попробуйте снова");
                }
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Угадай число: ");
                        while (!int.TryParse(Console.ReadLine(), out perem))
                        {
                            Console.WriteLine("Ошибка");
                        }
                        if (perem < 0 && perem > 100)
                        {
                            Console.WriteLine("Ошибка");
                        }
                        else
                        {
                            NaydiChislo(perem);
                            Console.WriteLine(otvet);
                        }
                        break;
                    case 2:
                        Tablica();
                        break;
                    case 3:
                        Console.WriteLine("Введите число");
                        while (!int.TryParse(Console.ReadLine(), out perem))
                        {
                            Console.WriteLine("Ошибка");
                        }
                        Divis(perem);
                        break;
                    case 4:
                        Console.WriteLine("Программа завершена");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Введите число от 1 до 4 ");
                        break;
                }
               
            }
        }
        static void NaydiChislo(int perem)
        {
            int chislo;
            Random rnd = new();
            chislo = rnd.Next(0, 100);
            while (perem != chislo)
            {
                if (chislo > perem)
                {
                    Console.WriteLine("Надо побольше");
                    while (!int.TryParse(Console.ReadLine(), out perem))
                    {
                        Console.WriteLine("Ошибка");
                    }
                }
                else if (chislo < perem)
                {
                    Console.WriteLine("Надо меньше");
                    while (!int.TryParse(Console.ReadLine(), out perem))
                    {
                        Console.WriteLine("Ошибка");
                    }
                }

            }
            otvet = "Вы угадали";
        }
        static int[,] Tablica()
        {
            int[,] table = new int[10, 10];
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    table[i, j] = j * i;
                }
                Console.WriteLine();
            }
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {

                    Console.Write(table[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return table;
        }
        static int Divis(int perem)
        {
            Console.WriteLine("Введите число");
            int Delit = 1;
            for (; Delit < 50; Delit++)
            {
                if (perem % Delit == 0)
                {
                    Console.Write(Delit + "\t");
                }
            }
            Console.WriteLine(perem);
            return Delit;
        }
    }
}


