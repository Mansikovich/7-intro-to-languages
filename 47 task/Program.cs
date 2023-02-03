using System;

namespace ConsoleApp
{
class Program
{
static void Main()
{

double[,] matrix = new double [3,4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

void PrintArray(double[,] matr)
{
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
     {
        Console.Write($"{matr[i,j]} ");
     }
     Console.WriteLine();
    }
}    
void FillArray(double[,] matr)
{

    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
    {
        matr[i,j] = Convert.ToDouble(new Random().Next(-100,100)) / 10;
    }
    }
}
}
}
}
