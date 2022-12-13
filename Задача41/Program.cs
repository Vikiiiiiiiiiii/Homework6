
/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3  */

//массив с выдачей случайных чисел

int[] arr = new int [7];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-100,100);
    Console.Write($"{arr[i]}, "); 
}
Console.WriteLine();

// получение кол-ва чисел больше 0

int coll = 0; 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        coll++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0 = {coll}");

