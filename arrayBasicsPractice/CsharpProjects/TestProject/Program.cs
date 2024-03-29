﻿// string[] fraudulentOrderIDs = new string[3]; //declaring an array that holds 3 strings

// //assigning index value with a string
// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";

// //access an array value 
// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

/* Multi line comment */

string[] arr2 = { "A123", "B456", "C789" }; //initialize array during declaration

Console.WriteLine($"First: {arr2[0]}");
Console.WriteLine($"Second: {arr2[1]}");
Console.WriteLine($"Third: {arr2[2]}");

arr2[0] = "F000";

Console.WriteLine($"Reassign First: {arr2[0]}");

Console.WriteLine($"There are {arr2.Length} fraudulent orders to process.");

string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names) {
    Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;

int bin = 0;

foreach (int items in inventory) {
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");