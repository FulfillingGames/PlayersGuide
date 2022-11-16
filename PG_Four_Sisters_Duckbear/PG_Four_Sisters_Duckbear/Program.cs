
// The Four Sisters and the Duckbear
// 
// Objectives:
// Create a program that lets the user enter the number of chooclate eggs gathered that day
// Using / and %, compute how many eggs each sister should get and how many are left over for the duckbear
// ANSWER THIS QUESTION - What are three total egg counts where the duckbear gets more than each sister does? Answer - 1, 2, 3

Console.WriteLine("By the order of the arbiter, this program must be used to equally distribute the number of chocolate eggs produced each day.");
Console.WriteLine("How many eggs were produced?");
var eggsProduced = Console.ReadLine();
int eggs = Convert.ToInt32(eggsProduced);
int eggsdistributed = eggs / 4;
int eggsremainder = eggs % 4;
Console.WriteLine("You have produced " + eggs + " eggs today.");
Console.WriteLine("Each sister gets " + eggsdistributed + "");
Console.WriteLine("And the duckbear gets " + eggsremainder);
