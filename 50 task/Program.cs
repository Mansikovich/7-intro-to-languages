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

Console.Write("Enter element's value: ");
int element=int.Parse(Console.ReadLine());

if(FindElement(matrix, element))
{
    Console.WriteLine("Element found");
}
else
{
    Console.WriteLine("Element not found");
}

bool FindElement(int[,] matrix, int el)
    {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
     for   (int j = 0; j < matrix.GetLength(1); j++)
     {
        if (matrix[i,j] == el) return true;
     }
        }
        return false;
    }

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
}
}
}
