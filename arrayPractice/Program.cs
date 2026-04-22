// See https://aka.ms/new-console-template for more information
int[] arr=new int[5];
for(int i=0;i<arr.Length;i++)
{
    Console.WriteLine("Enter the values for the array:" + (i+1));
    arr[i] = Convert.ToInt32(Console.ReadLine());
        }
foreach(int values in arr)
{
    Console.WriteLine(values);
}


Console.WriteLine("");
