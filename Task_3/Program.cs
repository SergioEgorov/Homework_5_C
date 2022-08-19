// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = new double[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}

double minNumber = array[0];
double maxNumber = array[0];
double result = 0;

for (int i = 0; i < array.Length; i++)
{
    if (minNumber > array[i]) minNumber = array[i];
    if (maxNumber < array[i]) maxNumber = array[i];
    result = maxNumber - minNumber;
}

Console.WriteLine($"[{String.Join("; ", array)}]");
Console.WriteLine($"Разница между максимальным элементом {maxNumber} и минимальным {minNumber} = {result}");


