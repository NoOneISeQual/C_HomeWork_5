void a(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(99,1000);
}

double Elementssum(int[] array)
{
    int sum = 0;
    int i = 0;
    while (i < array.Length)
    {
        sum = sum + array[i];
        i = i + 2;
    }
    return sum;
}


Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
a(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов стоящих на не чёт. позициях в массиве: {Elementssum(array)}");