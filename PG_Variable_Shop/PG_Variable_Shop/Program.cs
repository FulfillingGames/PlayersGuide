
// The Variable Shop

// Objectives:
// Build a program with a variable of all fourteen types described in this level
// Assign each of them a value using a literal of the correct type
// Use Console.WriteLine to display the contents of each variable

// The Variable Shop Returns

// Objectives:
// Modify your variable shop program to assign a new, different literal value to each of the 14 original variables. Do not declare any additional variables
// Use Console.WriteLine to display the updated contents of each variable 

// Variable Types
// Integers - byte, short, int, long, sbyte, ushort,uint,ulong
// Characters - char, string
// Floating Point - float, double, decimal
// Bool - bool

// Literal Modifiers - Placed at the end of a number to force it to be larger
// Integer Literals - U, L, UL
// Floating Literals - F, M

byte shopByte = 255;
short shopShort = 32_767;
int shopInt = 2_147_483_647;
long shopLong = 9_223_372_036_854_775_807;
sbyte shopSbyte = 127;
ushort shopUshort = 65_535;
uint shopUint = 4_294_967_295;
ulong shopUlong = 18_446_744_073_709_551_615;
char shopChar = 'a';
string shopString = "Strings";
float shopFloat = 7;
double shopDouble = 14;
decimal shopDecimal = 28;
bool shopBool = true;


Console.WriteLine("Come one, Come all! Make a stop at the variable shop!");
Console.WriteLine("Whatever equation one's trying to fill, I have the variables to fit the bill!");
Console.WriteLine("My Integer Inventory is: ");
Console.WriteLine("byte - Has a minimum of 0 and a maximum of " + shopByte);
Console.WriteLine("short - Has a minimum of -32,768 and a maximum of " + shopShort);
Console.WriteLine("int - Has a minimum of -2,147,483,648 and a maximum of " + shopInt);
Console.WriteLine("long - Has a minimum of BIG and a maximum of " + shopLong);
Console.WriteLine("sbyte - Has a minimum of -127 and a maximum of " + shopSbyte);
Console.WriteLine("ushort - Has a minimum of 0 and a maximum of " + shopUshort);
Console.WriteLine("uint - Has a minimum of 0 and a maximum of " + shopUint);
Console.WriteLine("ulong - Has a minimum of 0 and a maximum of " + shopUlong);
Console.WriteLine("My Word Inventory is: ");
Console.WriteLine("char - Represent a single letter, like " + shopChar);
Console.WriteLine("string - Represent as many letters as you need, like " + shopString);
Console.WriteLine("My Big Number Inventory is: ");
Console.WriteLine("float - Has a minimum of smol and a maximum of " + shopFloat);
Console.WriteLine("double - Has a minimum of smol and a maximum of " + shopDouble);
Console.WriteLine("decimal - Has a minimum of smol and a maximum of " + shopDecimal);
Console.WriteLine("My Logic Inventory is: ");
Console.WriteLine("bool - Represents True or False" + shopBool);
Console.WriteLine("Which of these items can I interest you in today?");
var input = Console.ReadLine();
Console.WriteLine("Ah, " + input + ". An excellent choice.");
Console.WriteLine("Here is your item and thank you very much for your visit today!");
