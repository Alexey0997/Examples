// Программа рассчета квадрата числа, введенного пользователем. 
Console.Clear();
Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
int sqw = number * number;
Console.WriteLine($"квадрат числа {number} = {sqw}");
