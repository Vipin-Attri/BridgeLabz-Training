// See https://aka.ms/new-console-template for more information
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
String[] array= new String[number];
for (int i = 1; i <= number; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        array[i-1] = "FizzBuzz";
    }
    else if (i % 3 == 0)
    {
        array[i-1] = "Fizz";
    }
    else if (i % 5 == 0)
    {
        array[i-1] = "Buzz";
    }
    else
    {
        array[i-1] = Convert.ToString(i);
    }
}
foreach(String values in array)
{
    Console.WriteLine(values);
}