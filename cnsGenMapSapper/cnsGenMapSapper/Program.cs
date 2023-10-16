using System;

class Minesweeper
{
    public static char[,] GenerateMinesweeperMap(int height = 9, int width = 9, int mineCount = 10, Tuple<int, int>[] mineLocations = null, Tuple<int, int> firstMove = null)
    {
        if (height <= 0 || width <= 0 || mineCount < 0)
        {
            throw new ArgumentException("Invalid height, width, or mine count.");
        }

        char[,] map = new char[height, width];

        // Инициализация карты с пустыми клетками
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                map[row, col] = '0';
            }
        }

        // Размещение мин
        Random random = new Random();

        if (mineLocations == null)
        {
            for (int i = 0; i < mineCount; i++)
            {
                int row, col;
                do
                {
                    row = random.Next(height);
                    col = random.Next(width);
                }
                while (map[row, col] == '*');

                map[row, col] = '*';
            }
        }
        else
        {
            foreach (Tuple<int, int> mineLocation in mineLocations)
            {
                int row = mineLocation.Item1;
                int col = mineLocation.Item2;

                if (row >= 0 && row < height && col >= 0 && col < width)
                {
                    map[row, col] = '*';
                }
            }
            for (int i = 0; i < mineCount - mineLocations.Length; i++)
            {
                int row, col;
                do
                {
                    row = random.Next(height);
                    col = random.Next(width);
                }
                while (map[row, col] == '*');

                map[row, col] = '*';
            }
        }

        // Открываем первую клетку (первый ход без мины)
        if (firstMove != null)
        {
            int row = firstMove.Item1;
            int col = firstMove.Item2;

            if (row >= 0 && row < height && col >= 0 && col < width)
            {
                if (map[row, col] != '*')
                {
                    map[row, col] = ' ';
                }
            }
        }

        // Заполняем клетки с количеством мин
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (map[row, col] == '*')
                {
                    continue;
                }

                int mineCountAdjacent = 0;

                for (int r = -1; r <= 1; r++)
                {
                    for (int c = -1; c <= 1; c++)
                    {
                        if (row + r >= 0 && row + r < height && col + c >= 0 && col + c < width && map[row + r, col + c] == '*')
                        {
                            mineCountAdjacent++;
                        }
                    }
                }

                map[row, col] = mineCountAdjacent.ToString()[0];
            }
        }

        return map;
    }

    static void Main()
    {
        char[,] map1 = GenerateMinesweeperMap(8, 8, 10);
        char[,] map2 = GenerateMinesweeperMap(10, 10, 15, null, new Tuple<int, int>(3, 3));
        char[,] map3 = GenerateMinesweeperMap(6, 6, 8, new Tuple<int, int>[] { new Tuple<int, int>(1, 1), new Tuple<int, int>(2, 2), new Tuple<int, int>(4, 4) });

        Console.WriteLine("Minesweeper Map 1:");
        PrintMap(map1);

        Console.WriteLine("\nMinesweeper Map 2:");
        PrintMap(map2);

        Console.WriteLine("\nMinesweeper Map 3:");
        PrintMap(map3);
    }

    static void PrintMap(char[,] map)
    {
        int height = map.GetLength(0);
        int width = map.GetLength(1);

        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                Console.Write(map[row, col]);
            }
            Console.WriteLine();
        }
    }
}
