// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, 
// какое число больше, а какое меньше. Например, а=5, b=7 -> max = 7.
Console.Clear();
Console.WriteLine("Уважаемый пользователь, введите первое целое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Уважаемый пользователь, введите второе целое число: ");
int numberB = int.Parse(Console.ReadLine());
if(numberA == numberB)
{
    Console.WriteLine("Эти числа равны. Введите, пожалуйста, два разных целых числа.");
}
else
if(numberA > numberB)
{
    Console.WriteLine($"Первое число {numberA} больше второго числа {numberB}.");
}
else
{
    Console.WriteLine($"Второе число {numberB} больше первого числа {numberA}.");
}