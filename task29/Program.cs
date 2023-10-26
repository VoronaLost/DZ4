//Напишите программу, которая задаёт массив из случайного количества элементов и выводит их на экран.
int[] GetRandomArray()
{
    int[] array = new int[(new Random().Next(2, 11))];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(11); // [0, 11)
    }
    return array;
}
int[] random = GetRandomArray();
Console.WriteLine($"Количество элементов в массиве: {random.Length}");
Console.WriteLine($"[{String.Join("; ", random)}]");
