// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите делимое и делитель через пробел");
string[] num = Console.ReadLine().Split(' ');
               double a = double.Parse(num[0]);
               double b = double.Parse(num[1]);
Console.WriteLine(a/b);
