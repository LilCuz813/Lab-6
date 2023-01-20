using System.Text.RegularExpressions;

Console.WriteLine("Welcome to the Dice Roller!");

Console.WriteLine("Enter a number from the sides of a pair of dice: ");
bool runWhile = true;
int num = 0;
while (runWhile)
{
    if (int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine($"Your number is: {num}");
        break;
    }
    else
    {
        Console.WriteLine("Invaild number! Please try again");
    }
}
Console.WriteLine("Roll the dice:");
Console.WriteLine("");

int roll1 = GetRandom(num);
int roll2 = GetRandom(num);
int sums = roll1 + roll2;

Console.WriteLine($"You rolled a {roll1}, and a {roll2}");
Console.WriteLine("");
Console.WriteLine("Would you like to play again? y/n");

string choice = Console.ReadLine().ToLower().Trim();
while (runWhile)
{
    if (choice == "y" || choice == "yes")
    {
        continue;       
    }
    else if (choice == "n" || choice == "no")
    {
        Console.WriteLine("Thanks for playing!");
        break;
    }
    else
    {
        Console.WriteLine("Invaild input! Please try again.");
        break;
    }
}


while (runWhile)
{
    if (num == 6)
    {
        Console.WriteLine(CheckSides(roll1, roll2));
        Console.WriteLine(CheckWins(sums));
    }
}


Console.ReadLine();

//METHOD SECTION
//------------------------------------------------------------------------

static int GetRandom(int max)
{
    Random r = new Random();
    return r.Next(1, max + 1);
}

static string CheckSides(int die1, int die2)
{
    if(die1 == 1 && die2 == 1)
    {
        return "You have a pair of Snake Eyes!";
    }
    else if ((die1 == 1 && die2 == 2) || (die1 == 2 && die2 == 1))
    {
        return "You have a Ace Duece!";        
    }
    else if (die1 == 6 && die2 == 6)
    {
        return "You have Box Cars!";
    }
    else
    {
        return "";
    }
}

static string CheckWins(int sums)
{
    if(sums == 7 || sums == 11)
    {
        return "You have won!!";
    }
    else if (sums == 2 || sums ==  3 || sums == 12)
    {
        return "CRAPS!!";
    }
    else
    {
        return "";
    }
}

