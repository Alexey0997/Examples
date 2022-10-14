// Программа для определения максимального числа из некоторого множества
int a = 1; // Вводим значения переменных а-е
int b = 2;
int c = 6;
int d = 8;
int e = 4; 
int max = a; // присваиваем max значение a
if (a > max) max = a;// сравниваем максимум с значениями переменных
if (b > max) max = b; 
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.Write("max = ");// Выводим на печать выражение max = 
Console.WriteLine(max);// Выводим на печать максимальное число