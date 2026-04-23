// See https://aka.ms/new-console-template for more information
using System;

using System;

Console.Write("Enter the no. of rows: ");

int[][] arr = new int[Convert.ToInt32(Console.ReadLine())][];
arr[0] = new int[] { 1, 2 };
arr[1] = new int[] { 4, 5, 6 };
arr[2] = new int[] { 7 };
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr[i].Length; j++)
    {
        Console.Write(arr[i][j] + " ");
    }
    Console.WriteLine();
}