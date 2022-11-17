
//
// The Prototype
//
// Objectives:
// Build a program that will allow a user, the pilot, to enter a number
// If the number is above 100 or less than 0, keep asking
// Clear the screen once the program has collected a good number
// Ask a second user, the hunter, to guess numbers
// Loop until they get it right, then end the program
//

Console.Title = "The Prototype";
Console.BackgroundColor = ConsoleColor.Cyan;
Console.ForegroundColor = ConsoleColor.Red;
Console.Clear();


int selection = -1;
int hunterSelection = -1;

Console.WriteLine("I have devised a program that will help the Guard track down The Uncoded One's airship");
while (selection < 0 || selection > 100)
{
    Console.WriteLine("Pilot, Enter a number between 0 and 100: ");
    int input = Convert.ToInt32(Console.ReadLine());
    selection = input;
}
Console.WriteLine($"You have chosen {selection}");
Console.WriteLine("Press any key to continue");
Console.ReadKey(true);
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();

Console.WriteLine("Hunter, the Pilot has chosen a destination. It is up to you to lead the way.");
while (hunterSelection >= 0 || hunterSelection <= 100)
{
    Console.WriteLine("Hunter, Enter a number between 0 and 100: ");
    int input = Convert.ToInt32(Console.ReadLine());
    hunterSelection = input;
    if (hunterSelection < selection) Console.WriteLine("We are not close enough. Search higher!");
    if (hunterSelection > selection) Console.WriteLine("We are too high. Go lower!");
    if (hunterSelection == selection)
    {
        Console.WriteLine($"Excellent Work! You've spooted the airship at {hunterSelection}!");
        Console.WriteLine("Press any key to land");
        Console.ReadKey(true);
        Console.Beep(440, 250);
        Console.Beep(350, 250);
        Console.Beep(200, 500);

        break;
    }
}

