//Brandon Langehennig
//Challenge 2 Guess the number
//Make a game with 4 different modes that generates a random number and has the user guess the number which then says if the number guessed is higher or lower than generated number. Make it replayable
//Peer Reviewer Name: Zackary Santos
//Review: Code works alright, however it does not let me re-enter my answer and I have to start all over again




GuessNumberGame numberGame = new GuessNumberGame();

numberGame.StartGame();


string playAgain = Console.ReadLine();

while(playAgain == "yes")
{
    
    numberGame.NewChoice();



    
}















if (playAgain == "no")
{
    Console.WriteLine("Thanks come again.");

}


