// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

//int[] arr = {3, 7, 22, 2, 78};
double[] CreateArray()
{
    //double[] array = new double[5];
    double[] array = {3, 7, 22, 2, 78};
    for (int i = 0; i < 5; i++)
    {
        //array[i] = new Random().Next(0, 1000);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

void Differ(double[] newArray)
{
    int numMax = 0;
    int numMin = 0;
    for (int i = 1; i < newArray.Length; i++)
    {
        if (newArray[i] > newArray[numMax]) 
        numMax = i;
        if (newArray[i] < newArray[numMin]) 
        numMin = i;
    }
    Console.WriteLine($"Разница max-min = {Math.Round(newArray[numMax] - newArray[numMin], 4)}");
}
Differ(CreateArray());
