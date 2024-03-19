Random coinSide = new Random(); // new random 
int side = coinSide.Next(1, 3); //generates random number into variable

Console.WriteLine(side == 1 ? "Tails" : "Heads"); //string literal displays