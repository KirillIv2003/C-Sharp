using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите высоту песочных часов: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Выберите тип заполнения (1 - звёздочками, 2 - цифрами): ");
        int fillType = int.Parse(Console.ReadLine());

        if (fillType == 1)
        {
            DrawHourglassWithStars(height);
        }
        else if (fillType == 2)
        {
            DrawHourglassWithNumbers(height);
        }
        else
        {
            Console.WriteLine("Неверный выбор типа заполнения.");
        }
    }

    static void DrawHourglassWithStars(int height)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * (height - i) - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (int i = height - 2; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * (height - i) - 1; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    static void DrawHourglassWithNumbers(int height)
    {
        int halfHeight = height / 2;
        int number = halfHeight + 1;

        for (int i = 0; i < halfHeight + 1; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < height - 2 * i; j++)
            {
                Console.Write(number);
            }

            Console.WriteLine();
            number--;
        }

        number = 2;

        for (int i = halfHeight - 1; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < height - 2 * i; j++)
            {
                Console.Write(number);
            }

            Console.WriteLine();
            number++;
        }
    }
}
