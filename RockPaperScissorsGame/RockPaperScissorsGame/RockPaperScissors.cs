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

            //Asking the user
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("How many games would you like to play with the computer?: ");

            //How many games is the player going to play
            int gamesNumber = int.Parse(Console.ReadLine());
            

            //Loop for the number of games
            for (int i = 0; i < gamesNumber; i++)
            {
                //Asking the user
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
                string playerMove = Console.ReadLine();


                //Separate the sentences so that the user can read more easily
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("=======================");

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
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Input. Try Again...");
                    continue;
                }


                //Chosing random number so that the computer can choose rock, paper or scissors
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


                //Computer choise
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"The computer chose {computerMove}.");


                //Separator
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("=======================");

                //The computer checks the situatuon
                if ((playerMove == Rock && computerMove == Scissors) ||
                    (playerMove == Paper && computerMove == Rock) ||
                    (playerMove == Scissors && computerMove == Paper))
                {
                    //Shows how many games has the user played
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    gameCounter++;
                    Console.WriteLine($"This is your {gameCounter} game.");


                    //Separator
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("=======================");

                    //The user wins
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You win!");
                    scorePoints += 3;
                    Console.WriteLine("3 points are added to your score!");

                    //Separator
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("=======================");
                    Console.WriteLine();
                    Console.WriteLine();
                }

                //Situation check
                else if ((playerMove == Rock && computerMove == Paper) ||
                    (playerMove == Paper && computerMove == Scissors) ||
                    (playerMove == Scissors && computerMove == Rock))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    gameCounter++;
                    Console.WriteLine($"This is your {gameCounter} game.");

                    //Separator
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("=======================");

                    //The user loses
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You lose!");
                    scorePoints += 0;
                    Console.WriteLine("0 points are added to your score!");

                    //Separator
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("=======================");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else
                {
                    //Shows the number of games
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    gameCounter++;
                    Console.WriteLine($"This is your {gameCounter} game.");

                    //Separator
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("=======================");

                    //The game has ended as a draw
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("This game was a draw!");
                    scorePoints += 1;
                    Console.WriteLine($"1 point is added to your score!");

                    //Separator
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("=======================");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
            //Shows the score
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Your score is {scorePoints} points!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}