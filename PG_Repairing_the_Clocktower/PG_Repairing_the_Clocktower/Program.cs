

// Repairing the Clocktower
//
// Objectives:
// Take a number as input from the console
// Display the word "Tick" if the number is even. Display the word "Tock" if the number is odd.

Console.Title = "Repairing the Clocktower";
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();

Console.WriteLine("I have written a program to assist with the repairs of the clock tower!");
Console.WriteLine("Input a number to determine its status");
var input = Console.ReadLine();
int inputInt = Convert.ToInt32(input);
if (inputInt % 2 == 0)
{
    Console.WriteLine("Tick");
} else
{
    Console.WriteLine("Tock");
}

