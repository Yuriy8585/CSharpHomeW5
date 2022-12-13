// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

//int[] arr = {345, 897, 568, 234};
//void PrintArray(int[] array)  // размерность массива
//{
//int count = array.Length;
    //for (int i = 0; i < count; i++)  // рандомные числа
    //{
    //Console.Write($"{array[i]}");
    //}
//}

int[] AddArray()
{
    int[] array = {345, 897, 568, 234};
    //int[] array = new int[4];
    for (int i = 0; i < 4; i++)
    {
        //array[i] = new Random().Next(10,100);
        Console.Write($"{array[i]} ");
        
    }
    Console.WriteLine();
    return array;
}

void Count(int[] newArray)
{
    int sum = 0;
    foreach (int i in newArray)
    {
        if (i % 2 == 0) sum++;
    }
    Console.WriteLine($"Кол-во четных чисел {sum}");
}
Count(AddArray());
