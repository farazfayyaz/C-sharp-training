// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})"); //currency format

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units"); //numeric format allows for readability, add a number after N to extend decimal

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}"); // formatting percentages, the number is to extend decimal placement

// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// //combinging formatting approaches
// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price); 

// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted

// Console.WriteLine(yourDiscount);

//------------------------------------------------------------------------------
// Using String formatting to display receipt information

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}"); //regular formatted integer

// Console.WriteLine($"   Shares: {productShares:N3} Product"); //decimal up to 3rd value
// Console.WriteLine($"     Sub Total: {subtotal:C}"); //currency based on user culture
// Console.WriteLine($"           Tax: {taxPercentage:P2}"); //percentage up to 2nd decimal
// Console.WriteLine($"     Total Billed: {total:C}"); //currency based on user culture

//------------------------------------------------------------------------------

// string input = "Pad this";
// // Console.WriteLine(input.PadRight(12)); // padleft method adds spacing on the left of the string

// // overloaded methods are methods with extra arguments that modify the funtionality of the method slightly
// Console.WriteLine(input.PadLeft(12, '-'));
//  Console.WriteLine(input.PadRight(12, '-'));

//-------------------------------------------------------------------------------
// Working with Padded Strings - build an app that converts data to legacy file format

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);