
//Массив (array)

string[] cities = { "Тула", "Уфа", "Ялта", "Сочи" };
Console.WriteLine(cities[0]);
Console.WriteLine(cities[^1]); //индексирование с конца
Console.WriteLine("--------------");

//(1)
for  (int i = 0; i < cities.Length; i++)
{
    Console.WriteLine(cities[i]);
}
Console.WriteLine();
Console.WriteLine("--------------");

//(2)
foreach (var cyti in cities)
{
    Console.WriteLine(cyti);
}
Console.WriteLine("--------------");


//изменить разсер массива
Array.Resize<string>(ref cities, 3);
Console.WriteLine(String.Join(' ', cities));
Console.WriteLine("--------------");

//пустой массив
string[] m1 = { };
string[] m2 = Array.Empty<string>();