﻿Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

if (daysUntilExpiration <= 10) {
    Console.WriteLine("Your subscription will expire soon. Renew now!")
}