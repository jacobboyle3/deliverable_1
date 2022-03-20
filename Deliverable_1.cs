// See https://aka.ms/new-console-template for more information
do
{
    Console.WriteLine("Hi! How many people are we making pbj sandwiches for today? ");
    int sandwiches = int.Parse(Console.ReadLine());
    int tablespoon = 2;
    int teaspoon = 4;
    int slices = 2;
    double result1 = sandwiches * tablespoon;
    double result2 = sandwiches * teaspoon;
    double result3 = sandwiches * slices;

    double loaf = Math.Ceiling(result3 / 28);
    double jarOfPeanutButter = Math.Ceiling(result1 / 32);
    double jarOfjelly = Math.Ceiling(result2 / 48);



    Console.WriteLine("You need: " + result3 + " slices of bread, "
        + result1 + " tablespoons of peanut butter, "
        + result2 + " teaspoons of jelly. Which is... "
        + Math.Ceiling(loaf) + " loaves of bread, "
        + Math.Ceiling(jarOfPeanutButter) + " Jars of peanut butter, "
        + Math.Ceiling(jarOfjelly) + " Jars of jelly. ");



    string userInput;
    Console.WriteLine(" Would you like to restart? Enter yes or y to continue, or enter any other key to exit. ");
    userInput = Console.ReadLine().ToUpper();
    while ((userInput == "Yes") && (userInput == "y"))
    

    while (userInput != "yes" || userInput != "y") ;
    {
        Console.WriteLine("Goodbye");
        Environment.Exit(0);
    }
} while (true);
        
    









