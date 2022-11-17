

// Watchtower
//
// Objectives:
// Ask the user for an x value and a y value. These are the coordinates of the enemy relative to the watchtower's location
// Using the image on the right, if statements, and relational operators, display a message about what direction the enemy is coming from
// For Example, "The enemy is to the northwest!" or "The enemy is here!"

Console.Title = "Watchtower";
Console.BackgroundColor = ConsoleColor.Gray;
Console.ForegroundColor = ConsoleColor.Red;
Console.Clear();

Console.WriteLine("The Consolas Milita have established watchtowers around the area. A program has been developed to assist in spotting \nthe direction of the attack");
Console.WriteLine("What is the X Coordinate?");
var x = Console.ReadLine();
int xint = Convert.ToInt32(x); 
Console.WriteLine($"X is {xint}, now what is the Y Coordinate?");
var y = Console.ReadLine();
int yint = Convert.ToInt32(y);
Console.Clear();
Console.WriteLine($"Coordinates are: \n X - {xint} \n Y - {yint}");
Console.WriteLine("Press any key to calculate attack direction");
Console.ReadKey(true);

if (yint == 0)
{
    if (xint > 0) Console.WriteLine("They are coming from the East!");
    else if (xint < 0) Console.WriteLine("They are coming from the West!");
}
if (xint == 0)
{
    if (yint > 0) Console.WriteLine("They are coming from the North!");
    else if (yint < 0) Console.WriteLine("They are coming from the South!");
}

if (xint <0 && yint > 0) Console.WriteLine("They are coming from the Northwest!");
if (xint > 0 && yint > 0) Console.WriteLine("They are coming from the Northeast!");
if (xint < 0 && yint < 0) Console.WriteLine("They are coming from the Southwest!");
if (xint > 0 && yint < 0) Console.WriteLine("They are coming from the Southeast!");


