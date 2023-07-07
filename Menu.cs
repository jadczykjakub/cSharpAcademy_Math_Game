using System.Diagnostics;

namespace cSharpAcademy_Math_Game
{
    internal class Menu
    {
        string name { get; set; }
        DateTime date { get; set; }
        public Menu(string name, DateTime date)
        {
            this.name = name;
            this.date = date;
        }

        GameEngine game = new GameEngine();
        internal void ShowMenu()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine($"Hello {name}, It's {date}.");
            var isGameOn = true;

            do
            {
                Console.WriteLine("Please give number of games");
                var numberOfGames = Console.ReadLine();
                numberOfGames = Helpers.Validation(numberOfGames);

                Console.WriteLine($"ok so the number of games will be {numberOfGames} and now choose a game");
                Console.WriteLine("A - Addition");
                Console.WriteLine("S - Substraction");
                Console.WriteLine("M - Multiplication");
                Console.WriteLine("D - Division ");
                Console.WriteLine("Q - Quit game ");
                Console.WriteLine("H - show history of games");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "a":
                        game.AdditionGame(int.Parse(numberOfGames));
                        break;
                    case "s":
                        game.SubstractionGame(int.Parse(numberOfGames));
                        break;
                    case "m":
                        game.MultiplicationGame(int.Parse(numberOfGames));
                        break;
                    case "d":
                        game.DivisionGame(int.Parse(numberOfGames));
                        break;
                    case "q":
                        game.QuitGame();
                        break;
                    case "h":
                        Helpers.PrintGames();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Environment.Exit(1);
                        break;
                }

                Console.WriteLine("Would you like to play again? Y/N");
                string playAgainAnswer = Console.ReadLine();

                if (playAgainAnswer.Trim().ToLower() == "n")
                {
                    isGameOn = false;
                    stopwatch.Stop();
                    double elapsedTime = Convert.ToInt32(stopwatch.Elapsed.TotalSeconds);
                    Console.Clear();
                    Console.WriteLine($"You have spent {elapsedTime} seconds on the game.");
                    Console.WriteLine("Thanks for playing, see you soon");
                }
            } while (isGameOn);
        }
    }
}
