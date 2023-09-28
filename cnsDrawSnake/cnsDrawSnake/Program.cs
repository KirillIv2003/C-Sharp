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

            Console.Write("Выберите ориентацию (1 - вертикальная змейка, 2 - горизонтальная змейка): ");
            int orientation = int.Parse(Console.ReadLine());
            //Console.Write("\u25A0");
            int width = 10; // Ширина поля
            int height = 10; // Высота поля

            if (orientation == 1)
            {
                DrawSnakeVertical(width, height, direction);
            }
            else if (orientation == 2)
            {
                DrawSnakeHorizontal(width, height, direction);
            }
            else
            {
                Console.WriteLine("Неверный выбор ориентации.");
            }

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
                        Console.Write("\u25A0");
                    }
                    else
                    {
                        Console.Write("\u25A0");
                    }
                }
                else if (direction == 2)
                {
                    if (count % 2 == 0)
                    {
                        Console.CursorLeft = width - 1;
                        Console.Write("\u25A0");
                    }
                    else
                    {
                        Console.Write("\u25A0");
                    }
                }
            }
            else
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("\u25A0");
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
                    Console.Write("\u25A0");
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
                                Console.Write("\u25A0");
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
                                Console.Write("\u25A0");
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
                                Console.Write("\u25A0");
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
                                Console.Write("\u25A0");
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
