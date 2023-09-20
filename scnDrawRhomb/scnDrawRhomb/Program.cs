// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int n = 5; // Размер ромба (можете изменить на желаемое значение)

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            Console.Write("/");

            for (int j = 2; j < 2 * i; j++)
            {
                Console.Write(" ");
            }

            Console.Write("\\");

            Console.WriteLine();
        }

        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            Console.Write("\\");

            for (int j = 2; j < 2 * i; j++)
            {
                Console.Write(" ");
            }

            Console.Write("/");

            Console.WriteLine();
        }
    }
}

