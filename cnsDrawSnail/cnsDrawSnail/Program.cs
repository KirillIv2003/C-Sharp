using System;

class Program
{
    static void Main()
    {
        bool repeat = true;
        while (repeat)
        {
            Console.Write("Выберите направление (1 - по часовой стрелке, 2 - против часовой стрелки): ");
            int direction = int.Parse(Console.ReadLine());

            //Console.Write("\u25A0");
            int width = 20; // Ширина поля
            int height = 10; // Высота поля

            DrawSnakeVertical(width, height, direction);

            Console.Write("Повторить? (да/нет):");
            string repeatInput = Console.ReadLine();
            repeat = repeatInput.ToLower() == "да";

            Console.Clear();
        }


    }

    static void DrawSnakeVertical(int width, int height, int direction)
    {
        int count = 0;
        for (int i = 0; i < height; i++)
        {


            if (i % 2 == 1)
            {
                count++;
                if (direction == 1)
                {
                    if (count % 2 == 1)
                    {
                        Console.CursorLeft = width - 1;
                        Console.Write("█");
                    }
                    else
                    {
                        Console.Write("█");
                    }
                }
                else if (direction == 2)
                {
                    if (count % 2 == 0)
                    {
                        Console.CursorLeft = width - 1;
                        Console.Write("█");
                    }
                    else
                    {
                        Console.Write("█");
                    }
                }
            }
            else
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("█");
                }
            }
            Console.WriteLine();
        }
    }

    static void DrawSnakeHorizontal(int width, int height, int direction)
    {
        for (int i = 0; i < height; i++)
        {
            int count = 0;
            for (int j = 0; j < width; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write("█");
                }
                else
                {
                    count++;
                    if (direction == 1)
                    {
                        if (i == 0)
                        {
                            if (count % 2 == 1)
                            {
                                Console.Write("█");
                            }
                            else
                            {
                                Console.Write(' ');
                            }

                        }
                        else if (i == height - 1)
                        {
                            if (count % 2 == 0)
                            {
                                Console.Write("█");
                            }
                            else
                            {
                                Console.Write(' ');
                            }
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            if (count % 2 == 0)
                            {
                                Console.Write("█");
                            }
                            else
                            {
                                Console.Write(' ');
                            }

                        }
                        else if (i == height - 1)
                        {
                            if (count % 2 == 1)
                            {
                                Console.Write("█");
                            }
                            else
                            {
                                Console.Write(' ');
                            }
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }

                }
            }

            Console.WriteLine();
        }
    }
}



