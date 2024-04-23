string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('('); //IndexOf finds the index of a char
int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length + 1)); //Substring needs starting position and number of characters/length