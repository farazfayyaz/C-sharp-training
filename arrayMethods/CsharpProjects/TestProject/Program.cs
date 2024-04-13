// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted....");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed....");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string value = "abc123";
// char[] valueArray = value.ToCharArray();

// Array.Reverse(valueArray);

// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

//-------------------------------------------------------------------------
//Challenge: reverse each word in the panagram and return the new sentence

// string pangram = "The quick brown fox jumps over the lazy dog";

// // Step 1
// string[] message = pangram.Split(' '); //split the string into an array of words without spaces

// //Step 2
// string[] newMessage = new string[message.Length]; //make a new array as long as the split up sentence

// // Step 3
// for (int i = 0; i < message.Length; i++)
// {
//     char[] letters = message[i].ToCharArray();
//     Array.Reverse(letters);
//     newMessage[i] = new string(letters);
// }

// //Step 4
// string result = String.Join(" ", newMessage);
// Console.WriteLine(result);

//-------------------------------------------------------------------------
//Challenge: parse OrderIDs and return a sorted list and error tag if they aren't 4 characters

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIDs = orderStream.Split(",");
Array.Sort(orderIDs);

foreach (string orderID in orderIDs)
{
    if (orderID.Length == 4)
    {
        Console.WriteLine(orderID);
    }
    else
    {
        Console.WriteLine($"{orderID}\t - Error");
    }
}