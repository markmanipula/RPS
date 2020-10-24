using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();

            //generates random number between 1-3
            int computer = random.Next(1,4);

            Console.WriteLine("Let's play rock paper scissors");

            bool keepPlaying = true;

            int computerScore = 0;
            int playerScore = 0;
            

            while (keepPlaying == true)
            {
                computer = random.Next(1, 4);

                Console.WriteLine("Rock paper scissors shoot!");
                string userInput = Console.ReadLine();
                if (userInput == "rock" && computer == 1)
                {
                    Console.WriteLine("Computer plays rock. It's a tie");
                }
                else if (userInput == "rock" && computer == 2) 
                {
                    Console.WriteLine("Computer plays paper. You lose");
                    computerScore++;
                }
                else if (userInput == "rock" && computer == 3) 
                {
                    Console.WriteLine("Computer plays scissors. You win");
                    playerScore++;
                }
                else if (userInput == "paper" && computer == 1) 
                {
                    Console.WriteLine("Computer plays rock. You win");
                    playerScore++;
                }
                else if (userInput == "paper" && computer == 2) 
                {
                    Console.WriteLine("Computer plays paper. It's a tie");
                }
                else if (userInput == "paper" && computer == 3) 
                {
                    Console.WriteLine("Computer plays scissors. You lose");
                    computerScore++;
                }
                else if (userInput == "scissors" && computer == 1) 
                {
                    Console.WriteLine("Computer plays rock. You lose");
                    computerScore++;
                }
                else if (userInput == "scissors" && computer == 2)
                {
                    Console.WriteLine("Computer plays paper. You win");
                    playerScore++;
                }
                else if (userInput == "scissors" && computer == 3) 
                {
                    Console.WriteLine("Computer plays scissors. It's a tie");
                }
                else Console.WriteLine("Invalid input");

                Console.WriteLine("Your score: " + playerScore + " Computer score: " + computerScore);

                Console.WriteLine("Would you like to keep playing?");
                string userAnswer = Console.ReadLine();

                if (userAnswer == "yes") keepPlaying = true;
                else keepPlaying = false;
            }

            if (playerScore < computerScore) Console.WriteLine("You lost the game");
            if (playerScore > computerScore) Console.WriteLine("You won the game");
            else Console.WriteLine("It's a tie");

        }
    }
}
