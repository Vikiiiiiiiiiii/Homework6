/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//ввод значений пользователем

Console.WriteLine("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());    //var позволяет объявлять локальную переменную без явного указания типа.

Console.WriteLine("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

//определение положения прямых по отношению друг к другу

if ((k1 != k2) && (b1 != b2))

Console.WriteLine("Прямые совпадают");

else if ((k1 == k2) && (b1 == b2))

Console.WriteLine("Прямые параллельны");

//нахождение точки пересечения двух прямых
var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;

x = Math.Round(x, 1);  // метод, который округляет значение до ближайшего целого или указанного количества десятичных знаков.
y = Math.Round(y, 1);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");


