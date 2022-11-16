

// Defense of Consolas
//
// Objectives:
// Ask the user for the target row and column
// Compute the neighboring rows and colums of where to deploy the squad
// Display the deployment instructions in a different color of your choosing
// Change the window title to be Defense of Consolas
// Play a sound with Console.Beep when the results have been computed and displayed



Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();
Console.Title = "Defense of Consolas";

string targetRow;
string targetColumn;
int northSquad;
int southSquad;
int westSquad;
int eastSquad;

Console.WriteLine("Defenders of Consolas! The city is under attack!");
Console.WriteLine("Worry not for I have devised a program that shall effectively deploy our defenses!");
Console.WriteLine("Commander, Enter your name");
var commanderName = Console.ReadLine();
Console.Clear();
Console.WriteLine($"Commander {commanderName}, using the intelligence our spies have gathered, use this program to intercept the attackers!");
Console.WriteLine("What is the Target Row?");
targetRow = Console.ReadLine();
var rowInt = Convert.ToInt32(targetRow);
Console.WriteLine($"Target Row is {targetRow}, now enter the Target Column");
targetColumn = Console.ReadLine();
var columnInt = Convert.ToInt32(targetColumn);
Console.WriteLine($"Target Row is {targetRow}, and Target Column is {targetColumn}?");
Console.WriteLine("Press any key to compute the Deployment Solution");
Console.ReadKey(true);
Console.Clear();
northSquad = (rowInt + 1);
southSquad = (rowInt - 1);
westSquad = (columnInt - 1);
eastSquad = (columnInt + 1);
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Targeting - ");
Console.WriteLine($"Row {targetRow}");
Console.WriteLine($"Column {targetColumn}");
Console.WriteLine("Deploy To: ");
Console.WriteLine($"{northSquad}, {columnInt}");
Console.WriteLine($"{southSquad}, {columnInt}");
Console.WriteLine($"{westSquad}, {rowInt}");
Console.WriteLine($"{eastSquad}, {rowInt}");
Console.Beep(440, 250);
Console.Beep(700, 250);
Console.Beep(440, 250);
Console.Beep(700, 250);
Console.Beep(440, 250);
Console.Beep(900, 250);
Console.Beep(1440, 500);
