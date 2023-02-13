/* Задайте две матрицы. Напишите программу, которая 
будет находить произведение двух матриц.  */

int[,] arr1 = Generate2DArray(3, 3);
Print2DArray(arr1);
System.Console.WriteLine();
int[,] arr2 = Generate2DArray(3, 3);
Print2DArray(arr2);
System.Console.WriteLine();
if (Check2DArrays(arr1, arr2))
{
int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
Multiply2DArray(arr1, arr2, result);
System.Console.WriteLine( $"Произведение матриц:");
Print2DArray(result); 
}
else
{
    System.Console.WriteLine("Данные матрицы не могут быть перемножены");
}


void Multiply2DArray(int[,] array1, int[,] array2, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            resultArray[i, j] = sum;
        }
    }
}

bool Check2DArrays(int[,] array1, int[,] array2)
{
    if (array1.GetLength(0) == array2.GetLength(1))
    {
        return true;
    }
    else
    {
        return false;
    }
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