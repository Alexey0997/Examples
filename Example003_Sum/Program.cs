// Программа для сложения двух целых чисел
int numberA = new Random().Next(1,10); // используем герератор случайных чисел для задания А [0,10)
Console.WriteLine(numberA); // Выведем значение А в терминале
int numberB = new Random().Next(1,10); // используем герератор случайных чисел для задания B [0,10)
Console.WriteLine(numberB); // Выведем значение B в терминале
int result = numberA + numberB; // Вводим значение result для обозначения суммы
Console.WriteLine(result); // Выводим результат вычислений на печать