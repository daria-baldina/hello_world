// See https://aka.ms/new-console-template for more information
Console.Write("Введите два слагаемых через пробел");
string[] num = Console.ReadLine().Split(' ');
               int a = int.Parse(num[0]);
               int b= int.Parse(num[1]);
Console.WriteLine(a + b);