//Brandon Langehennig
//Challenge 2 Guess the number
//Make a game with 4 different modes that generates a random number and has the user guess the number which then says if the number guessed is higher or lower than generated number. Make it replayable
//Peer Reviewer Name:
//Review:

string play;


Console.WriteLine("Welcome would you like to play a number guessing game?(yes or no)");
play = Console.ReadLine();
while(play == "yes")
    {
         
        Console.WriteLine("Great, Choose a game, easy, medium, hard, or custom, enter choice now: ");
       Console.ReadLine();
        string[] choices = [ "easy" , "medium" , "hard" , "custom" ];
        string choice1 = choices[0];
        string choice2 = choices[1];
        string choice3 = choices[2];
        string choice4 = choices[3];
    if(choice1 == choices[0])
    {
        Console.WriteLine("easy it is lets begin");
    }
    if(choice2 == choices[1])
    {
    Console.WriteLine("Guess we will do medium then");    
    }
    if(choice3 == choices[2])
    {
        Console.WriteLine("Hard game coming up");
    }
    if(choice4 == choices[3])
    {
    Console.WriteLine("A custom game,please enter a number: ");
    string num1 = Console.ReadLine();
    Console.WriteLine("Please enter another number: ");
    string num2 = Console.ReadLine();

    Console.WriteLine("Guess the number between " + num1 + " and " + num2 + ":" );
Console.ReadLine();
    }
    
    
    
    
    
    
    
    
    
    }
    
    
    if(play == "no")
    {
        Console.WriteLine("Thanks come again.");
     
    }

