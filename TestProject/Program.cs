Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int sum = roll1 + roll2 + roll3;

Console.WriteLine($"Your first dice is: {roll1}");
Console.WriteLine($"Your second dice is: {roll2}");
Console.WriteLine($"Your third dice is: {roll3}");

// Giving bonus points.
if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
{
    Console.WriteLine("You rolled a double! You get 2 bonus points.");
    sum += 2;
}
else if (roll1 == roll2 && roll2 == roll3)
{
    Console.WriteLine("You rolled a perfect dice! You get 6 bonus points.");
    sum += 6;
}

Console.WriteLine($"The sum of your dice is: {sum}");

// Final calculation of the score.
if (sum > 15)
{
    Console.WriteLine("Congratulations! You won.");
}
else
{
    Console.WriteLine("I'm sorry, you lost!");
}

Console.Read();

