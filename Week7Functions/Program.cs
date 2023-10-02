Console.WriteLine("Are you coming or leaving? (in/out)");
string userChoice = Console.ReadLine();

if (userChoice == "in" )
{
    PrintHello();
}
else
{
    printGoodbye();
}





static void PrintHello () //function ehk või method
{
Console.WriteLine("Hello, world!");
}

static void printGoodbye()
{
    Console.WriteLine("See you later, aligator.");
}

