// Программа для построения треугольника Серпинского
Console.Clear(); // Очистка консоли.
// Console.SetCursorPosition(10, 4); // Определяем начальную позицию курсора.
// Console.WriteLine("+"); // Указываем символ, которым будем рисовать. 
int xa = 30; // задаем координаты точек a, b, c. (x - отступ от левого края, y - вниз).
int ya = 1;
int xb = 1;
int yb = 10;
int xc = 60;
int yc = 10;
Console.SetCursorPosition(xa, ya); // Устанавливаем курсор в точку А.
Console.WriteLine("+"); // Рисуем в точке А знак +.
Console.SetCursorPosition(xb, yb); 
Console.WriteLine("+"); 
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+"); 

int x = xa, y = xb;

int count = 0;
while(count < 10000)
{
    int what = new Random().Next(0, 3); // Выбираем одну из трех точек, поэтому генерируем число 0, 1 или 2.
    if (what == 0) // Если это число равно 0, то в х положим середину отрезка.
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1) 
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2) 
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;
}