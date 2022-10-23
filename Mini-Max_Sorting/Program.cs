// Вывод на экран цифр заданного массива.
// Console.Clear();
// int [] array = {9, 5, 4, 3, 2, 6, 7, 1, 1}; // Исходный массив.
// void PrintArray(int [] array)               // Вывести данный массив на экран.
// {
//     int count = array.Length;               // Длина массива.
//     for(int i = 0; i < count; i++)          // Цикл от нулевого до последнего элемента. 
//     {
//         Console.Write($"{array[i]} ");      // Печать заданного элемента массива.
//     }
//     Console.WriteLine();                    // Пустая строка. 
// }
// PrintArray(array);                          // Вывести цифры массива на печать. 
// void SelectionSort(int [] array)            // Провести сортировку массива.
// {
//      for(int i = 0; i < array.Length; i++)  // От нулевого к последнему элементу.  
//      {
//         int minPosition = i;                // Присвоим минимум нулевому элементу.
//         for(int j = i + 1; j < array.Length; j++) // Сравним первый и последующие 
//         {                                         // элементы с минимумом.
//             if(array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];           // Запишем нулевой элемент в temporary.
//         array [i] = array [minPosition];    // Запишем в нулевой элемент минимум.
//         array [minPosition] = temporary;    // Запишем минимум во временный файл.
//      }
// }
// // PrintArray(array);
// SelectionSort(array);                       // Запустим функцию упрядочивания массива.
// PrintArray(array);                          // Печать результата.



// Вывод на экран цифр заданного массива.
Console.Clear();
int [] array = {9, 5, 4, 32, 2, 6, 7, 1, 1}; // Исходный массив.
void PrintArray(int [] array)               // Вывести данный массив на экран.
{
    int count = array.Length;               // Длина массива.
    for(int i = 0; i < count; i++)          // Цикл от нулевого до последнего элемента. 
    {
        Console.Write($"{array[i]} ");      // Печать заданного элемента массива.
    }
    Console.WriteLine();                    // Пустая строка. 
}
PrintArray(array);                          // Вывести цифры массива на печать. 
void SelectionSort(int [] array)            // Провести сортировку массива.
{
     for(int i = 0; i < array.Length; i++)  // От нулевого к последнему элементу.  
     {
        int maxPosition = i;                // Присвоим минимум нулевому элементу.
        for(int j = i + 1; j < array.Length; j++) // Сравним первый и последующие 
        {                                         // элементы с минимумом.
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];           // Запишем нулевой элемент в temporary.
        array [i] = array [maxPosition];    // Запишем в нулевой элемент минимум.
        array [maxPosition] = temporary;    // Запишем минимум во временный файл.
     }
}
// PrintArray(array);
SelectionSort(array);                       // Запустим функцию упрядочивания массива.
PrintArray(array);                          // Печать результата.
