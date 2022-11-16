
// The Dominion of Kings
//
// Objectives:
// Create a program that allows users to enter how many provinces, duchies, and estates they have
// Add up the user's total score, giving 1 point per estate, 3 per duchy, and 6 per province
// Display the point total to the user

int estateScore = 1;
int duchyScore = 3;
int provinceScore = 6;

Console.WriteLine("My King, the program requires only your inputs and it shall provide you with a score with which to compare among your rivals!");
Console.WriteLine("First, how many Estates does your kingdom have?");
var estatesInput = Console.ReadLine();
int estates = Convert.ToInt32(estatesInput);
Console.WriteLine("Your Kingdom has " + estates + " estates. Now how many Duchies does your Kingdom contain?");
var duchiesInput = Console.ReadLine();
int duchies = Convert.ToInt32(duchiesInput);
Console.WriteLine("Your Kingdom has " + estates + " estates, and " + duchies + " duchies. Finally, how many Provinces are in your Kingdom?");
var provincesInput = Console.ReadLine();   
int provinces = Convert.ToInt32(provincesInput);
Console.WriteLine("Your Kingdom has " + estates + " estates, " + duchies + " duchies, and " +provinces+" provinces. A grand Kingdom indeed!");
int score = (estates * estateScore) + (duchies * duchyScore) + (provinces * provinceScore);
Console.WriteLine("The program has calculated the Score of your Kingdom to be: " + score);
Console.WriteLine("May your reign be long and prosperous");
