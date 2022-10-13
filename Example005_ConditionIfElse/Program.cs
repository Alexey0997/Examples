// Программа для особого приветствия Валюшки
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "Валюшка")
{
    Console.WriteLine("Ура, это же Валюшка!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine("username!");
}