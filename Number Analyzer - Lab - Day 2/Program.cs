Console.WriteLine("Hello, what is your name?");
string userName = Console.ReadLine();
bool runWhile = true;
while (runWhile == true)
{
    Console.WriteLine(userName + ", Please choose an integer between 1 and 100 inclusive.");
    int num = int.Parse(Console.ReadLine());

    if (num > 0 && num <= 100)

    {
        if (num % 2 != 0 && num < 60)
        {
            Console.WriteLine(userName + ", " + num + " is odd and less than 60.");
        }
        else if (num % 2 == 0 && num >= 2 && num <= 24)
        {
            Console.WriteLine(userName + ", " + num + " is even and less than 25.");
        }
        else if (num % 2 == 0 && num >= 26 && num <= 60)
        {
            Console.WriteLine(userName + ", " + num + " is even and between 26 and 60 inclusive.");
        }
        else if (num % 2 == 0 && num > 60)
        {
            Console.WriteLine(userName + ", " + num + " is even and greater than 60.");
        }
        else if (num % 2 != 0 && num > 60)
        {
            Console.WriteLine(userName + ", " + num + " is odd and greater than 60.");
        }
    }
    else
    {
        Console.WriteLine(userName + ", " + num + " is not in the required range.You FAILED! How embarassing.");
        Console.WriteLine();
    }
    Console.WriteLine("Would you like to try again, " + userName + "? Please choose y/n.");
    string choice = Console.ReadLine().ToLower();
    runWhile = choice == "y" || choice == "yes" ? true : false;

    //    if (choice == "n")
    //{
    //    runWhile = false;
}
Console.WriteLine();
Console.WriteLine("Goodbye!");


