using System;

class DiceRoller
{
    public static (int[], int) RollDice(int numDice, int numSides = 6, int[] customValues = null)
    {
        if (numDice <= 0 || numSides <= 1)
        {
            throw new ArgumentException("Количество кубиков и количество сторон должно быть больше нуля.");
        }
        else if (numDice > 10 || numSides > 6) 
        {
            throw new ArgumentException("Количество кубиков должно быть не больше 10 и количество сторон должно быть не больше 6.");
        }

        if (customValues != null && customValues.Length != numSides)
        {
            throw new ArgumentException("Количество пользовательских значений должно соответствовать количеству сторон.");
        }
        

        Random random = new();
        int[] results = new int[numDice];
        int total = 0;

        for (int i = 0; i < numDice; i++)
        {
            if (customValues != null)
            {
                results[i] = customValues[random.Next(numSides)];
            }
            else
            {
                results[i] = random.Next(1, numSides + 1);
            }
            total += results[i];
        }

        return (results, total);
    }

    static void Main()
    {
        var result1 = RollDice(3); // Подбрасываем 3 кубика по умолчанию (6 граней)
        Console.WriteLine("Results 1: " + string.Join(", ", result1.Item1) + " Total: " + result1.Item2);

        var customValues = new int[] { 1, 2, 3, 4, 5, 6 };
        var result2 = RollDice(2, 6, customValues); // Подбрасываем 2 кубика с заданными значениями на гранях
        Console.WriteLine("Results 2: " + string.Join(", ", result2.Item1) + " Total: " + result2.Item2);

        var customValues1 = new int[] { 10, 20, 30};
        var result3 = RollDice(4, 3, customValues1); // Подбрасываем 4 кубика с 10 гранями (по умолчанию)
        Console.WriteLine("Results 3: " + string.Join(", ", result3.Item1) + " Total: " + result3.Item2);
    }
}
