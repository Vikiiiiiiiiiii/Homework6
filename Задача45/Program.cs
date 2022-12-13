//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

// метод, который будет выдавать зполненный массив случайными числами
int[] InitArray(int length)
{
    int [] array = new int [length];
    Random rnd = new Random();
    for (int i = 0; i<length; i++)
    {
        array [i] = rnd.Next(-5,15);
    }
    return array;
}
//метод, который будет печатать массив
void PrintArray(int [] array)
{
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]"); 
    Console.WriteLine(); 
}
//метод, который будет копировать массив (печатает копию массива)
void PrintCopyArray(int [] arr) 
{
        int[] copy = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++) 
        {
            copy[i] = arr[i];
        }
        Console.WriteLine(); 

    Console.WriteLine(string.Join(" , ", copy)); 
}     

int [] arr = InitArray(7);
PrintArray(arr);      
PrintCopyArray(arr);     
