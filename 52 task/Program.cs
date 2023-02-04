using System;

namespace ConsoleApp
{
class Program
{
static void Main()
{
int[,] matrix = new int [3,4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

double[] averageColumns=GetResultArray(matrix);
Console.WriteLine($"Average value of each column is = {string.Join("; ", averageColumns)}");


void PrintArray(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
     {
        Console.Write($"{matrix[i,j]} ");
     }
     Console.WriteLine();
    }
}    
void FillArray(int[,] matrix)
    {

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        matrix[i,j] = new Random().Next(1,100);
    }
    }
    }

    double[] GetResultArray(int[,] matrix)
    {
        double[] result = new double[matrix.GetLength(1)];
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            double sum = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                sum+=matrix[rows, columns];
            }
            result[columns]=Math.Round(sum/matrix.GetLength(0), 2);
        }
        return result;
    }
}
}
}

