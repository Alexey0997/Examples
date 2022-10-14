// Написать программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промеждутке от -N до N.
Console.Clear();
Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
int count = number * -1;
while(count <= number)
{
    Console.Write($"{count}, ");
    count++;
}
