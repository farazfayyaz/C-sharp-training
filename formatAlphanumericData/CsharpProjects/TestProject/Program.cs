string first = "Hello";
string second = "World";
string result = string.Format("{1} {0}!", first, second);
Console.WriteLine(result);

Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);
