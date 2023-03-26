void a(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(99,1000);
}

int Elementskol(int[] array)
{
    int kol = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            kol = kol + 1;
    }
    return kol;
}


Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
a(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество чётных чисел в массиве: {Elementskol(array)}");