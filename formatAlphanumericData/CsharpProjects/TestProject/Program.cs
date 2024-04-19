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

decimal price = 67.55m;
decimal salePrice = 59.99m;

//combinging formatting approaches
string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price); 

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted

Console.WriteLine(yourDiscount);