using System;

class CrossPattern
{
    public static void DrawCross(int height, int width)
    {
        if (height <= 0 || width <= 0)
        {
            throw new ArgumentException("Invalid parameters.");
        }

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (col == row)
                {
                    Console.Write("\\");
                }
                else if (col == width - row - 1)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Enter the height of the cross: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("Enter the width of the cross: ");
        int width = int.Parse(Console.ReadLine());

        DrawCross(height, width);
    }
}
