using System;
namespace RockPaperScissorsGame
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            int scorePoints = 0;
            int gameCounter = 0;

            Console.Write("How many games would you like to play with the computer?: ");
            int gamesNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < gamesNumber; i++)
            {
                Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
                string playerMove = Console.ReadLine();

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = Scissors;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again...");
                    continue;
                }

                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);

                string computerMove = "";

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }

                Console.WriteLine($"The computer chose {computerMove}.");

                if ((playerMove == Rock && computerMove == Scissors) ||
                    (playerMove == Paper && computerMove == Rock) ||
                    (playerMove == Scissors && computerMove == Paper))
                {
                    gameCounter++;
                    Console.WriteLine($"This is your {gameCounter} game.");
                    Console.WriteLine("You win!");
                    scorePoints += 3;
                    Console.WriteLine("You won 3 points!");
                    Console.WriteLine();
                }
                else if ((playerMove == Rock && computerMove == Paper) ||
                    (playerMove == Paper && computerMove == Scissors) ||
                    (playerMove == Scissors && computerMove == Rock))
                {
                    gameCounter++;
                    Console.WriteLine($"This is your {gameCounter} game.");
                    Console.WriteLine("You lose!");
                    scorePoints += 0;
                    Console.WriteLine("You won 0 points!");
                    Console.WriteLine();
                }
                else
                {
                    gameCounter++;
                    Console.WriteLine($"This is your {gameCounter} game.");
                    Console.WriteLine("This game was a draw!");
                    scorePoints += 1;
                    Console.WriteLine($"You won 1 point!");
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Your score is {scorePoints} points!");
        }
    }
}