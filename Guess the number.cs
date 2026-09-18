using System.Security.Cryptography.X509Certificates;

public class GuessNumberGame
{

public string playAgain = Console.ReadLine();




public void StartGame()
    
{

Console.WriteLine("Welcome to guess the number, woud you like to play!: ");

}
public void NewChoice()
    {
         Console.WriteLine("Great, Choose a game, easy, medium, hard, or custom, enter choice now: ");
            string choice = Console.ReadLine();




    switch (choice)
    {
        case "easy":
            Console.WriteLine("easy it is lets begin");


            Console.WriteLine("Guess the number between 1 and 10? ");
            string number1 = Console.ReadLine();


            Random rnd1;

            rnd1 = new Random();

            int min1 = 1;

            int max1 = 10;

            int tries1 = 0;

            int randomNum1 = rnd1.Next(min1, max1);


            bool success1 = int.TryParse(number1, out int playerGuess1);


            if (success1)
            {
                if (randomNum1 == playerGuess1)
                {
                    Console.WriteLine("Wow you got it right");
                }
                else
                {
                    Console.WriteLine("Sorry you got it wrong, try again ");
                    string try2 = Console.ReadLine();
                    
                
                    
                        
                    
                }
            }

            break;


        case "medium":
            Console.WriteLine("Guess we will do medium then");

            Console.WriteLine("Guess the number between 1 and 50? ");
             string number2 = Console.ReadLine();


            Random rnd2;

            rnd2 = new Random();

            int min2 = 1;

            int max2 = 50;

            int tries2 = 0;

            int randomNum2 = rnd2.Next(min2, max2);


            bool success2 = int.TryParse(number2, out int playerGuess2);


            if (success2)
            {
                if (randomNum2 == playerGuess2)
                {
                    Console.WriteLine("Wow you got it right");
                }
                else
                {
                    Console.WriteLine("Sorry you got it wrong");
                }
            }

            break;

        case "hard":
            Console.WriteLine("Hard game coming up");

            Console.WriteLine("Guess the number between 1 and 100? ");
             string number3 = Console.ReadLine();


            Random rnd3;

            rnd3 = new Random();

            int min3 = 1;

            int max3 = 100;

            int tries3 = 0;

            int randomNum3 = rnd3.Next(min3, max3);


            bool success = int.TryParse(number3, out int playerGuess3);


            if (success)
            {
                if (randomNum3 == playerGuess3)
                {
                    Console.WriteLine("Wow you got it right");
                }
                else
                {
                    Console.WriteLine("Sorry you got it wrong");
                }
            }
            break;

        case "custom":
            Console.WriteLine("A custom game,please enter a number: ");
            string num1 = Console.ReadLine();
            Console.WriteLine("Please enter another number: ");
            string num2 = Console.ReadLine();

            Console.WriteLine("Guess the number between " + num1 + " and " + num2 + ":");
            string number4 = Console.ReadLine();


            Random rnd4;

            rnd4 = new Random();

            int min4 = 1;

            int max4 = 10;

            int tries4 = 0;

            int randomNum4 = rnd4.Next(min4, max4);


            bool success4 = int.TryParse(number4, out int playerGuess4);


            if (success4)
            {
                if (randomNum4 == playerGuess4)
                {
                    Console.WriteLine("Wow you got it right");
                }
                else
                {
                    Console.WriteLine("Sorry you got it wrong");
                }
            }
            break;
         default:
            Console.WriteLine("Invalid input");
        break;
    }




    }
    
public void PlayAgain()
    {
        Console.WriteLine("Would you like to play again? yes or no");
        Console.ReadLine();



    }




}