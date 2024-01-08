using System;
using System.Reflection;

class BombermanGame
{
    private char[][] gameMap;
    private Random random = new Random();

    public BombermanGame(int height, int width)
    {
        if (height <= 5 || width <= 5 || height % 2 == 0 || width % 2 == 0)
        {
            throw new ArgumentException("Invalid game field size.");
        }

        InitializeEmptyMap(height, width);
        PlaceDestructibleWalls();
    }

    private void InitializeEmptyMap(int height, int width)
    {
        gameMap = new char[height][];
        for (int i = 0; i < height; i++)
        {
            gameMap[i] = new char[width];
            for (int j = 0; j < width; j++)
            {
                gameMap[i][j] = '▓';
            }
        }

        for (int i = 1; i < height - 1; i++)
        {
            for (int j = 1; j < width - 1; ++j)
            {
                gameMap[i][j] = ' ';
            }
        }

        for (int i = 2; i < height - 2; i+=2)
        {
            for (int j = 2; j < width - 2; j+=2)
            {
                gameMap[i][j] = '▓';
            }
        }
    }

    private void PlaceDestructibleWalls()
    {
        int height = gameMap.Length;
        int width = gameMap[0].Length;

        for (int i = 1; i < height - 1; i++)
        {
            for (int j = 1; j < width - 1; j++)
            {
                if (random.Next(2) < 1 && gameMap[i][j] != '▓')
                {
                    gameMap[i][j] = '░';
                }
            }
        }

        gameMap[1][1] = ' ';
        gameMap[1][2] = ' ';
        gameMap[2][1] = ' ';

        gameMap[1][width - 2] = ' ';
        gameMap[1][width - 3] = ' ';
        gameMap[2][width - 2] = ' ';

        gameMap[height - 3][1] = ' ';
        gameMap[height - 2][2] = ' ';
        gameMap[height - 2][1] = ' ';

        gameMap[height - 3][width - 2] = ' ';
        gameMap[height - 2][width - 2] = ' ';
        gameMap[height - 2][width - 3] = ' ';

    }

    public void PrintMap()
    {
        int height = gameMap.Length;
        int width = gameMap[0].Length;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(gameMap[i][j]);
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        int height = 11;
        int width = 11;

        BombermanGame game = new BombermanGame(height, width);
        game.PrintMap();
    }
}
