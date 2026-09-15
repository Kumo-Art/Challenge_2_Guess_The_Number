//Brandon Langehennig
//Challenge 2 Guess the number
//Make a game with 4 different modes that generates a random number and has the user guess the number which then says if the number guessed is higher or lower than generated number. Make it replayable
//Peer Reviewer Name:
//Review:

string play;


Console.WriteLine("Welcome would you like to play a number guessing game?(yes or no)");
play = Console.ReadLine();
while (play == "yes")
{

    Console.WriteLine("Great, Choose a game, easy, medium, hard, or custom, enter choice now: ");
    string choice = Console.ReadLine();
   

    switch (choice)
    {
        case "easy":
            Console.WriteLine("easy it is lets begin");
            Console.WriteLine("Guess the number between 1 and 10? " + Console.ReadLine());
            break;


        case "medium":
            Console.WriteLine("Guess we will do medium then");
            Console.WriteLine("Guess the number between 1 and 50? " + Console.ReadLine());
            break;

        case "hard":
            Console.WriteLine("Hard game coming up");
            Console.WriteLine("Guess the number between 1 and 100? " + Console.ReadLine());
            break;

        case "custom":
            Console.WriteLine("A custom game,please enter a number: ");
            string num1 = Console.ReadLine();
    Console.WriteLine("Please enter another number: ");
    string num2 = Console.ReadLine();

    Console.WriteLine("Guess the number between " + num1 + " and " + num2 + ":");
    Console.ReadLine();
            break;
            default:
            Console.WriteLine("Invalid input");
            break;
    }

    
}
    
    
    
    
    
    
    
    
    
    
    
    
    if (play == "no")
{
    Console.WriteLine("Thanks come again.");

}

