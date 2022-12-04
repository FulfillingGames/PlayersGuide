
//
// BOSS BATTLE
// Hunting the Manticore
//
// __________________________________________________
// STATUS: Round: 1   City: 15/15   Manticore: 10/10
// The Cannon is expected to deal 1 damage this round
// Enter desired cannon range: 50
// The round OVERSHOT the target.
//
// Objectives
// Establish the game's starting state: the Manticore begins with 10 health points and the city with 15, the game starts at Round 1
// Ask the first player to choose the Manticore's distance from the city (0 to 100). Clear the screen.
// Run the game in a loop until either the Manticore's or City's health reaches 0
// Before the second player's turn, display the round number, the city's health, and the Manticore's health.
// Compute how much damage the cannon will deal this round: 10 points if the round number is a multiple of both 3 and 5, 3 if it is a multiple of 3 or 5, and 1 otherwise
// Display this to the player
// Get a target range from the second player, and resolve its effect. Tell the user if they overshot (too far), fell short, or hit the Manticore.
// If it was a hit, reduce the Manticore's health by the expected amount
// If the Manticore is still alive, reduce the city's health by 1
// Advance to the next round
// When the Manticore or the city's health reaches 0, end the game and display the outcome
// Use different colors for different types of messages
//

using System.Drawing;

Console.Title = "Hunting the Manticore";
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Clear();
/*Console.Beep(600, 125);
Console.Beep(500, 125);
Console.Beep(300, 250);
Console.Beep(325, 125);
Console.Beep(350, 125);
Console.Beep(400, 250);
Console.Beep(300, 250);
Console.Beep(250, 250);*/

Console.WriteLine("The time has come to defeat the Manticore once and for all!");

int cityHealth = 15;
int manticoreHealth = 10;
int manticoreLocation = -1;
int round = 1;
int damage;

while (manticoreLocation < 0 || manticoreLocation > 100)
{
    Console.WriteLine("Player 1, determine the location of the Manticore (0 to 100)");
    int _ = Convert.ToInt32(Console.ReadLine());
    manticoreLocation = _;
    if (_ < 0 || _ > 100) Console.WriteLine("Invalid selection. Please try again.");
}
Console.WriteLine($"Player 1, You have chosen {manticoreLocation} as the Distance of the Manticore");
Console.WriteLine("Press any key to continue...");
Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkRed;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();


while (cityHealth > 0 && manticoreHealth > 0)
{

    NewRound();
    DamageCalc();
    FireCannon();
    if (manticoreHealth > 0) cityHealth--;
    round++;
    //Console.WriteLine("Press any key to continue...");
    //Console.ReadLine();
    CheckEnd();
}

void CheckEnd()
{
    if (manticoreHealth <= 0)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("A fiery explosion fills the sky, shrapnel rains down, and the cheers of victory are heard all across the city.");
        Console.WriteLine("A gargantuan task has been accomplished with the assistance of the Programmer. The Manticore has finally been defeated");
        Console.WriteLine("But we all know this is not the end, and the machinations of the Uncoded One are still fouling the lands.");
        Console.WriteLine("Rest well, you've earned it.");
        Console.WriteLine();
        Console.WriteLine("Press any key to exit");
        Console.ReadLine();
    }
    else if (cityHealth <= 0)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("The unthinkable has happened. Unable to properly direct the attacks of the cannon, the onslaught has began");
        Console.WriteLine("Anyone unfortunate enough to fall under its shadow are obliterated, any who gaze upon it soon find themselves set upon.");
        Console.WriteLine("The Uncoded One shall forever hold dominion over these lands.");
        Console.WriteLine();
        Console.WriteLine("Press any key to exit");
        Console.ReadLine();
    } 
}

void FireCannon()
{
    Console.WriteLine();
    Console.WriteLine("Player 2, enter desired Cannon range: ");
    int range = Convert.ToInt32(Console.ReadLine());
    if (range < manticoreLocation) Console.WriteLine("Shot was too low!");
    if (range > manticoreLocation) Console.WriteLine("Shot was too high!");
    if (range == manticoreLocation)
    {
        Console.WriteLine("Direct hit!");
        Console.ForegroundColor = ConsoleColor.White;
        manticoreHealth -= damage;
    }
}
void DamageCalc()
{
    int currentRound = round;
    int fireGem = 3;
    int electricGem = 5;

    if (currentRound % fireGem != 0 && currentRound % electricGem != 0)
    {
        damage = 1;
    } else
    if (currentRound % fireGem == 0 && currentRound % electricGem != 0)
    {
        damage = 3;
    } else
    if (currentRound % fireGem != 0 && currentRound % electricGem == 0)
    {
        damage = 3;
    }else 
    if (currentRound % fireGem == 0 && currentRound % electricGem == 0)
    {
        damage = 10;
    }
    else damage = 1;
    Console.Write($"The cannon is expected to do ");
    switch (damage)
    {
        case 1: Console.ForegroundColor = ConsoleColor.Green;

            Console.Write($"{damage} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("point of damage.");
            break;
        case 3: Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write($"{damage} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("points of damage.");
            break;
        case 10: Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write($"{damage} ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("points of damage."); 
            break;
        default:
            break;
    }
}

void NewRound()
{
    switch (round)
    {
        case 1: Console.WriteLine("The Manticore is attacking the city! Rally the defenses! Prepare to attack!");
            break;
        case 10: Console.WriteLine("Time is running out! We must take down the Manticore!");
            break;
        case 15: Console.WriteLine("The city cannot hold much longer! This is your final chance!");
            break;
        default: Console.WriteLine("The Manticore continues to attack the city!");
            break;
    }
    Console.WriteLine("_____________________________________________________________________________");
    Console.WriteLine($"Current Status: Round {round}   City: {cityHealth}   Manticore: {manticoreHealth}");
}