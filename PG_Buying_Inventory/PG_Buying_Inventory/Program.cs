
//
// Buying Inventory
// 
// Objectives:
// Build a program that will show the menu illustrated above
// Ask the user to enter a number from the menu
// Using the information above, use a switch (either type) to show the item's cost
//
// Discounted Inventory
//
// Objectives:
// Modify your program from before to also ask the user for their name
// If their name equals your name, divide the cost in half
//
// Prices:
// Rope - 10, Torches - 15, Climbing Equipment - 25, Clean Water - 1, Machete - 20, Canoe - 200, Food Supplies - 1

Console.Title = "Buying Inventory";
Console.BackgroundColor = ConsoleColor.Magenta;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Clear();

Console.WriteLine("I have devised a program for Tortuga to assist in the organization of his shop.");
Console.WriteLine("Hopefully now he can get some customers.\nPress any key to continue.");
Console.ReadKey(true);
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Clear();


int rope = 10;
int torches = 15;
int climbing = 25;
float water = 1;
int machete = 20;
int canoe = 200;
float food = 1;

Console.WriteLine("Welcome to Tortuga's General Store\nOur current inventory is:" +
    "\n1 - Rope" +
    "\n2 - Torches" +
    "\n3 - Climbing Equipment" +
    "\n4 - Clean Water" +
    "\n5 - Machetes" +
    "\n6 - Canoe" +
    "\n7 - Food Supplies" +
    "\nPlease enter your selection to see the price");
Console.WriteLine("But first, you look familiar. Mind telling me your name?");
string name = Console.ReadLine();
if (name == "M")
{
    rope /= 2;
    torches /= 2;
    climbing /= 2;
    water /= 2;
    machete /= 2;
    canoe /= 2;
    food /= 2;
    Console.WriteLine("Ah I knew I recognized you, we have the same name! Half off for a limited time only\nSo what can I interest you in?");
}
else Console.WriteLine("Ah sorry then, must have mistaken you for someone else\nAnyway what'll your selection be?");

var selection = Convert.ToInt32(Console.ReadLine());
string price;
price = selection switch
{
    1 => $"Rope - {rope} gold",
    2 => $"Torches - {torches} gold",
    3 => $"Climbing Equipment - {climbing} gold",
    4 => $"Clean Water - {water} gold",
    5 => $"Machete - {machete} gold",
    6 => $"Canoe - {canoe} gold",
    7 => $"Food Supplies - {food} gold",
    _ => "Apologies, I am out of stock of that at the moment"
};
if (name == "M")
{
    Console.WriteLine(price + " with your 50% discount");
    Console.WriteLine("Thanks for shopping");
} else 

Console.WriteLine($"{price}, Thanks for shopping!");
Console.WriteLine("Press any key to leave");
Console.ReadKey(true);
Console.BackgroundColor = ConsoleColor.Magenta;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Beep(350, 250);
Console.Beep(300, 250);
Console.Beep(200, 500);
Console.Clear();

