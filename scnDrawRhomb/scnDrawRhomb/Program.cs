// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        bool repeat = true;

        while (repeat)
        {
            Console.Write("Введите длину сторон ромба (нечетное число): ");
            int sideLength = int.Parse(Console.ReadLine());

            Console.Write("Выберите цвет (черный/белый): ");
            string colorInput = Console.ReadLine();
            bool isWhite = colorInput.ToLower() == "белый";

            DrawDiamond(sideLength, isWhite);

            Console.Write("Повторить? (да/нет): ");
            string repeatInput = Console.ReadLine();
            repeat = repeatInput.ToLower() == "да";

            Console.Clear();
        }
    }

    static void DrawDiamond(int sideLength, bool isWhite)
    {

        if (isWhite)
        {
            for (int i = 1; i <= sideLength; i++)
            {
                for (int j = 1; j <= sideLength - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = sideLength - 1; i >= 1; i--)
            {
                for (int j = 1; j <= sideLength - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        else
        {
            for (int i = 1; i <= sideLength; i++)
            {
                for (int j = 1; j <= sideLength - i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= sideLength - i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = sideLength - 1; i >= 1; i--)
            {
                for (int j = 1; j <= sideLength - i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= sideLength - i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
                
        Console.WriteLine();
    }
}

