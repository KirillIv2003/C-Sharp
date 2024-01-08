using System;

class ColoredSquarePattern
{
    public static void DrawColoredSquare(int width, int height, ConsoleColor[] colors, int symbol)
    {
        if (width <= 0 || height <= 0 || colors.Length == 0)
        {
            throw new ArgumentException("Invalid parameters.");
        }
        
        int colorIndex = 0;
        int colorCount = colors.Length;
        char simvol = '█';

        if (symbol == 1)//квадрат
        {
            int cenX = width / 2;
            int cenY = height / 2;
            int max = Math.Max(width, height);
            for (int i = max; i >= 2; i -= 2)
            {
                int x = cenX - i / 2;
                int y = cenY - i / 2;

                ConsoleColor color = colors[(max - i) % colors.Length];
                Console.ForegroundColor = color;

                for (int row = 0; row < i; row++)
                {
                    for (int col = 0; col < i; col++)
                    {
                        Console.SetCursorPosition(x + col, y + row);
                        Console.Write(simvol);
                    }
                }

                //Console.WriteLine();
            }
        }

        

        //for (int row = 0; row < height; row++)
        //{
        //    for (int col = 0; col < width; col++)
        //    {
        //        Console.ForegroundColor = colors[colorIndex];
        //        Console.Write(symbol);

        //        colorIndex = (colorIndex + 1) % colorCount;
        //    }

        //    Console.WriteLine();
        //}
    }

    static void Main()
    {
        int width = 10;
        int height = 10;
        ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue };
        int symbol = 1;

        
        DrawColoredSquare(width, height, colors, symbol);
    }
}

