// Задача 34: Задайте массив 
// заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[4];
int length = array.Length;
int count = 0;
for (int index = 0; index < array.Length; index++)
{
    array[index] = new Random().Next(100, 1000);
}

for (int index = 0; index < array.Length; index++)
{
    if (array[index] % 2 == 0) count++; 
    else Console.WriteLine("Чётных чисел нет");
}
Console.WriteLine($"[{String.Join("; ", array)}]");
Console.WriteLine($"Количество чётных чисел: {count}");