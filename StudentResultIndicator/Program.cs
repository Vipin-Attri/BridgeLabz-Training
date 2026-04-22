// See https://aka.ms/new-console-template for more information
// Get student score from the user
Console.WriteLine("Enter grade:");
int studentGrade = int.Parse(Console.ReadLine());
// Condition for invalid score
if (studentGrade < 0 || studentGrade > 100)
{
    Console.Error.WriteLine("Invalid grade.");
    Environment.Exit(0);
}
// Check for pass/fail
if (studentGrade >= 50)
{
    Console.WriteLine("Congratulations!");
    Console.WriteLine("You passed the examination.");
}
else
{
    Console.WriteLine("Sorry.\nYou failed the examination.");
}