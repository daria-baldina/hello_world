Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Машенька, солнышко, привет!");
}
else
{
    Console.Write("Добрый день, ");
    Console.WriteLine(username);
}