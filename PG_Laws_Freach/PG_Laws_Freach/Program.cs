//
// The Laws of Freach
//
// Objectives:
// Using the sample code for computing an array's minimum and average valus in on Page 94
// Modify the code to use foreach loops instead of for loops
//
//

Console.Title = "The Laws of Freach";
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Clear();
Console.Beep(440, 250);
Console.Beep(350, 250);
Console.Beep(200, 500);

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue; // Start higher than anything in the array
foreach (int item in array)
{
    if (item < currentSmallest) currentSmallest = item;
}
Console.WriteLine(currentSmallest);
