string? readResult; // expecting a string input
string valueEntered = ""; // empty string for the input
int numValue = 0; // empty num value
bool validNumber = false; // boolean to verify num

Console.WriteLine("Enter an integer value between 5 and 10"); //display for the start of program

do
{
    readResult = Console.ReadLine(); // ask for the user input
    if (readResult != null) // if null
    {
        valueEntered = readResult; //enter the value into the valueEntered variable
    }

    validNumber = int.TryParse(valueEntered, out numValue); // convert the string input into a int, store into numValue

    if (validNumber == true) // if validNumber is true, continue
    {
        if (numValue <= 5 || numValue >= 10) // check if value is between 5-10
        {
            validNumber = false; //change valid number to false
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10."); //display user input and the range
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again"); //otherwise ask user to input again
    }
} while (validNumber == false); //do loop while validNumber is false

Console.WriteLine($"Your input value ({numValue}) has been accepted."); //display if number is valid and accepted

readResult = Console.ReadLine(); //ask for user input