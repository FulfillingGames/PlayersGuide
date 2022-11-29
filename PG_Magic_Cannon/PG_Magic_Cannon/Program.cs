
//
// The Magic Cannon
//
// Objectives:
// Write a program that will loop thorugh the values between 1 and 100 and display what kind of blast the crew should expect (The % operator may be of use)
// Change the color of the output based on the type of blast (For example, red for Fire, yellow for Electric, and blue for Electric and Fire)
// Fire Gem - 3rd turn, Electric Gem - 5th turn, Combined Blast when aligned

Console.Title = "The Magic Cannon";
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Clear();
Console.Beep(300, 250);
Console.Beep(350, 250);
Console.Beep(450, 500);

Console.WriteLine("Skorin of the Guard has requested I devise a program to assist in the prediction of enemy attacks");
Console.WriteLine("Behold, a chart of the next 100 attacks");

int fireGem = 3;
int electricGem = 5;

for (int i = 1; i <= 100; i++)
{

    if (i % fireGem != 0 && i % electricGem != 0)
    {
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.WriteLine($"{i}: Normal");
    } else if (i % fireGem == 0 && i % electricGem != 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}: Fire");
    } else if (i % fireGem != 0 && i % electricGem == 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{i}: Electric");
    } else if (i % fireGem == 0 && i % electricGem == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{i}: COMBINED BLAST");
    }


}

