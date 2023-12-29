/*
Monster Battle Challenge written in C#.  Hero attacks first and then monster attacks, based on 
random hit points that are taken from the health of the player.  This iteration continues until
one or the other has 0 or less Health.  At that point the winner is declared.
*/
Random random = new Random();
int heroHealth = 10;
int monsterHealth = 10;
int attack = random.Next(1, 10);

do
{
    if (heroHealth > 0)
    {
        monsterHealth -= attack;
        Console.WriteLine($"Monster was damaged and lost {attack} health points and now has {monsterHealth} health.");
    }
    
    if (monsterHealth > 0)
    {
    attack = random.Next(1, 10);
    heroHealth -= attack;
    Console.WriteLine($"Hero was damaged and lost {attack} health points and now has {heroHealth} health.");
    }

} while (heroHealth > 0 && monsterHealth > 0);

    if (heroHealth > 0)
        Console.WriteLine("Hero Wins!");
    else if (monsterHealth > 0)
        Console.WriteLine("Monster Wins!");
