string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})"); //currency format

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units"); //numeric format allows for readability, add a number after N to extend decimal