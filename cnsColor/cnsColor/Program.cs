﻿Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("Зелёный текст на красном фоне");
Console.ResetColor();
Console.WriteLine("Обычный текст");

foreach (var color in Enum.GetValues<ConsoleColor>())
{
    Console.WriteLine(color);
}