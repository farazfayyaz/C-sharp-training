string? userInput;
string input = "";

bool validInput = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{

    userInput = Console.ReadLine();

    if(userInput != null)
    {
        input = userInput.Trim().ToLower();
    }

    if(validInput == false)
    {
        if(input == "administrator")
        {
            Console.WriteLine("Your input value (Administrator) has been accepted.");
            validInput = true;
        }
        else if (input == "manager")
        {
            Console.WriteLine("Your input value (Manager) has been accepted.");
            validInput = true;
        }
        else if (input == "user")
        {
            Console.WriteLine("Your input value (User) has been accepted.");
            validInput = true;
        }
        else
        {
            Console.WriteLine($"The role name that you entered, \"{input}\" is not valid. Enter your role name (Administrator, Manager, or User)");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again"); //otherwise ask user to input again
    }

} while (validInput == false);