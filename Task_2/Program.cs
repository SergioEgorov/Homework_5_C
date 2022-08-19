// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];
int length = array.Length;
int sum = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    array[i] = new Random().Next(-100, 100);
    sum = array[1] + array[3];
}
Console.WriteLine($"[{String.Join("; ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");