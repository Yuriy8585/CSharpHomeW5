// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

//int[] arr = {3, 7, 23, 12};
//void PrintArray(int[] array)  // размерность массива
//{
//int count = array.Length;
    //for (int i = 0; i < count; i++)  // рандомные числа
    //{
    //Console.Write($"{array[i]}");
    //}
    //Console.WriteLine();
    //return array;
//}

//int[] array = {-4, -6, 89, 6};
//void PrintArray(int[] array)  // размерность массива
//{
//int count = array.Length;
    //for (int i = 0; i < count; i++)  // рандомные числа
    //{
    //Console.Write($"{array[i]}");
    //}
    //Console.WriteLine();
    //return array;
//}

int[] AddArray()
{
    int[] array = {-4, -6, 89, 6};
  
    //int[] array = new int[4];
    for (int i = 0; i < 4; i++)
    {
        //array[i] = new Random().Next(100, 900);
        Console.Write($"{array[i]} ");
        
    }
    Console.WriteLine();
    return array;
}

void FindSum(int[] newArray)
{
    int sum = 0;
    for (int i = 0; i < 4; i++)
    {
        if (i % 2 != 0) sum += newArray[i];
    }
    Console.WriteLine($"Summ = {sum}");
}
FindSum(AddArray());