// See https://aka.ms/new-console-template for more information
int row = 3, col = 3;
int[,] array = new int[row,col];
int sum = 0;
for(int i=0; i < row; i++)
{
    for(int j = 0; j < col; j++)
    {
        Console.Write("Enter the value for array[" + i + "," + j + "]: ");
        array[i, j] = Convert.ToInt32(Console.ReadLine());
        sum += array[i, j];
    }

}
Console.WriteLine("The sum of all the elements of the array is:" + sum);
