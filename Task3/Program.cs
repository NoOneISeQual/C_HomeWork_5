void a(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(99,1000);
}

double Elementsraz(double[] array)
{
    double max = array[0];
    double min = array[0];
    int i = 0;
    while (i < array.Length)
    {
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array [i];
        i = i + 1;
    }
    return max - min;
}


Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
a(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Разница макс и мин чисел в массиве: {Elementsraz(array)}");