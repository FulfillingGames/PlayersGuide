
//
// Simula's Test
//
// Objectives:
// Define an enumeration for the state of the chest
// Make a variable whose type is the new enumeration
// Write code to allow you to manipulate the chest with the lock, unlock, open, and close commands, but ensure that you don't transition between 
// states that don't support it
// Loop forever, asking for the next command

Console.Title = "Simula's Test";
Console.BackgroundColor = ConsoleColor.Cyan;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();

Console.WriteLine("While walking through the village of Enumerant you are stopped by a strange person.");
Console.WriteLine("Taking interest in your skills as a programmer, they have challenged you with the opening of a small box.");
Console.WriteLine();
Console.WriteLine("Press any key to continue...");
Console.ReadLine();
Console.Clear();

Chest state = Chest.Locked;
int i = -1;
while (i < 0)
{
    Console.WriteLine($"The chest is {state}. What do you want to do?");
    string reply = Console.ReadLine();
    if (state == Chest.Locked)
    {
        switch (reply)
        {
            case "unlock": state = Chest.Closed; Console.WriteLine("You unlock the chest."); break;
            case "lock": Console.WriteLine("The chest is already locked."); break;
            case "open": Console.WriteLine("You need to unlock it first."); break;
            case "close": Console.WriteLine("The chest is already closed."); break;
            default: Console.WriteLine("I don't recognize that command."); break;
        }
    } else
    if (state == Chest.Closed)
    {
        switch (reply)
        {
            case "unlock": Console.WriteLine("The chest is already unlocked."); break;
            case "lock": state = Chest.Locked; Console.WriteLine("You lock the chest."); break;
            case "open": state = Chest.Open; Console.WriteLine("You open the chest."); break;
            case "close": Console.WriteLine("The chest is already closed."); break;
            default: Console.WriteLine("I don't recognize that command."); break;
        }
    } else
    if (state == Chest.Open)
    {
        switch (reply)
        {
            case "unlock": Console.WriteLine("The chest is already unlocked"); break;
            case "lock": Console.WriteLine("You must close the chest first."); break;
            case "open": Console.WriteLine("The chest is already open."); break;
            case "close": state = Chest.Closed; Console.WriteLine("You close the chest."); break;
            default: Console.WriteLine("I don't recognize that command."); break;
        }
    }
}



enum Chest { Locked, Closed, Open }