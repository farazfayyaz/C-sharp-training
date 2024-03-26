int heroHealth = 10; //hero health
int monsterHealth = 10; //mosnster health

Random val = new Random(); //new random object


do 
{
    int attackVal = val.Next(1, 11); // generate random num for attack
    monsterHealth -= attackVal; // subtract the damage from the monster health
    Console.WriteLine($"Monster was damaged and lost {attackVal} health and now has {monsterHealth} health."); // display monster health

    if (monsterHealth <= 0) continue; // if monster health is not 0 or less, continue

    attackVal = val.Next(1, 11); // generate new num for attack
    heroHealth -= attackVal; // subtract the damage from the hero health
    Console.WriteLine($"Hero was damaged and lost {attackVal} health and now has {heroHealth} health."); //display

    
} while (heroHealth > 0 && monsterHealth > 0); //loop while both health bars are greater than 0

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!"); // display who wins