
//Stack Стек

//Обычный

using System.Collections;

Stack stack = new();
stack.Push("hello");
stack.Push(33);
stack.Push(1234);
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

//Обобщённый

Stack<string> cities = new();
//Hw