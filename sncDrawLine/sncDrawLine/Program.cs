bool isContinue;

do
{
    Console.WriteLine("Длинна?");

    int.TryParse(Console.ReadLine(), out int width);

    //1
    //for (int i = 0; i < width; i++)
    //{
    //    Console.WriteLine("*");
    //}
    //Console.WriteLine();

    //(2)
    Console.WriteLine(new String('*', width));

    Console.Write("Повторить? [Y/N] ->");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";
} while (isContinue);