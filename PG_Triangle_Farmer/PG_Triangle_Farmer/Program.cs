

// The Triangle Farmer
//
// Area = (Base * Height) / 2
// 
// Objectives:
// Write a program that lets you input the triangle's base size and height
// Compute the area of a triangle by turning the above equation in to code
// Write the result of the computation

using System.ComponentModel;

string baseinputText;
string heightinputText;
float baseNumber;
float heightNumber;

float area;

Console.Write("I have created a calculator to assist with the management of your triangles.");
Console.WriteLine("First, tell me the Base of the triangle");
baseinputText = Console.ReadLine();
baseNumber = Convert.ToSingle(baseinputText);
Console.WriteLine("The base is " + baseNumber + ". Now tell me the Height of the triangle");
heightinputText = Console.ReadLine();
heightNumber = Convert.ToSingle(heightinputText);
Console.WriteLine("The base is " + baseNumber + " and the height is " + heightNumber + ".");
area = baseNumber * heightNumber / 2;
Console.WriteLine("I have calculated the area of the triangle to be " + area);