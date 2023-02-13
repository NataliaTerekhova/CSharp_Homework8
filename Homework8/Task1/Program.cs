/* Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.  */


int[,] arr = Generate2DArray(3,3);
Print2DArray(arr);
System.Console.WriteLine();
SortRow(arr);



void SortRow(int[,] array)
{
    int[] row= new int[array.GetLength(0)];   
    for (int i = 0; i < array.GetLength(0); i++)
        {
         for(int j =0 ; j< array.GetLength(1); j++)
         {
            row[j]=array[i,j];
         }

           Array.Sort(row);
           PrintArray(row);
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

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write($" {arr[i]}");
    }
    System.Console.WriteLine();
}

