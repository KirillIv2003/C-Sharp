using System;

class Program
{
    static void Main()
    {
        bool repeat = true;

        while (repeat)
        {
            Console.Write("Введите ширину прямоугольника: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Введите высоту прямоугольника: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Закрасить прямоугольник (да/нет)? ");
            string fillInput = Console.ReadLine();
            bool fill = fillInput.ToLower() == "да";

            DrawRectangle(width, height, fill);

            Console.Write("Повторить? (да/нет): ");
            string repeatInput = Console.ReadLine();
            repeat = repeatInput.ToLower() == "да";

            Console.Clear();
        }
    }

    static void DrawRectangle(int width, int height, bool fill)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (fill || i == 0 || i == height - 1 || j == 0 || j == width - 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
