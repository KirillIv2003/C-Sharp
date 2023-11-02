//var arr = new int[] { 1, 2, 3, 4, 5, 6, 8 };
var arr = Enumerable.Range(0, 10).ToArray();

Console.WriteLine(string.Join(" ", arr));

var myQuery =
    from v in arr
    where v > 4 && v < 8
    orderby v descending
    select $"_{v}_";

Console.WriteLine(string.Join(" ", myQuery));
Console.WriteLine($"Sum = {arr.Sum()}");

var arr2 = new string[] { "Москва", "Воронеж", "Тула", "Тварь", "Якутск", "Пятигорск" };

var myQuery2 =
    from v in arr2
    where v.Length > 1
    select v;

Console.WriteLine(string.Join(" ", myQuery2));