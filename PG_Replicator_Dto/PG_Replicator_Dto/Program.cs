

//
// The Replicator of D'To
//
// Objectives:
// Make a program that creates an array of length 5
// Ask the user for five numbers and put them in the array
// Make a second array of length 5
// Use a loop to copy the values out of the original array and into the new one
// Display the contents of both arrays one at a time to illustrate that the Replicator of D'To works again
//

Console.Title = "Replicator of D'To";
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();
Console.WriteLine("Behold, I have found among the abandoned ruins a relic! Few have seen it, but those who have describe it as The Replicator of D'To");

Console.WriteLine("To make the artifact work, I need a volunteer to provide 5 integers");
int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int[] copy = new int[5];

for (int i = 0; i < copy.Length; i++)
{
    copy[i] = array[i];
}

foreach (int number in array) Console.WriteLine("This array of integers " + number);
foreach (int numb in copy) Console.WriteLine("Has been copied to here "+ numb);

