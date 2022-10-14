// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.Clear();
Console.WriteLine("Введи первое целое и положительное число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введи второе целое и положительное число: ");
int numberB = int.Parse(Console.ReadLine());
int sqw = numberB * numberB;
if(numberA == sqw)
{
    Console.WriteLine($"Первое число {numberA} является квадратом второго числа {numberB}.");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго.");
}