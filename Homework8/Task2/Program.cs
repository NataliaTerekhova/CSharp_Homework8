/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.  */

int[,] arr = Generate2DArray(4, 3);
Print2DArray(arr);
System.Console.WriteLine();
GetMaxSum(arr);

void GetMaxSum(int[,] array)
{
    int sum = int.MaxValue;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }
        if (temp < sum)
        {
            sum = temp;
            index = i;
        }
    }

    Console.WriteLine($"Наименьшая сумма элементов ({sum}) находится в {index} строке");
    Console.WriteLine();
}


int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($" {arr[i, j]}");
        }
        System.Console.WriteLine();
    }
}


