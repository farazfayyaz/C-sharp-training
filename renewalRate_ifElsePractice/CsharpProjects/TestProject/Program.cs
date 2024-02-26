Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

if (daysUntilExpiration <= 10) {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (daysUntilExpiration <= 5) {
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    Console.WriteLine($"Renew now and save 10%!");
}