namespace cSharpAcademy_Math_Game
{
    internal class GameEngine
    {
        internal void AdditionGame(int numberOfGames)
        {
            int score = 0;  
            for (int i = 0; i < numberOfGames; i++)
            {
                var random = new Random();
                int firstNumber = random.Next(1, 10);
                int secondNumber = random.Next(1, 10);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var computerResult = firstNumber + secondNumber;
                var userGuess = Console.ReadLine();
                userGuess = Helpers.Validation(userGuess);

                if (int.Parse(userGuess) == firstNumber + secondNumber)
                {
                    score++;
                    Console.WriteLine("Correct answer, Press enter to see next question");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Wrong answer. Press enter to see next question");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Helpers.AddToHistory(score, GameType.Addition);

        }

        internal void SubstractionGame(int numberOfGames)
        {
            int score = 0;
            for (int i = 0; i < numberOfGames; i++)
            {
                var random = new Random();
                int firstNumber = random.Next(1, 10);
                int secondNumber = random.Next(1, 10);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var computerResult = firstNumber - secondNumber;
                var userGuess = Console.ReadLine();
                userGuess = Helpers.Validation(userGuess);

                if (int.Parse(userGuess) == firstNumber - secondNumber)
                {
                    score++;
                    Console.WriteLine("Correct answer, Press enter to see next question");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Wrong answer. Press enter to see next question");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Helpers.AddToHistory(score, GameType.Substraction);
        }

        internal void MultiplicationGame(int numberOfGames)
        {
            int score = 0;
            for (int i = 0; i < numberOfGames; i++)
            {
                var random = new Random();
                int firstNumber = random.Next(1, 10);
                int secondNumber = random.Next(1, 10);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var computerResult = firstNumber * secondNumber;
                var userGuess = Console.ReadLine();
                userGuess = Helpers.Validation(userGuess);

                if (int.Parse(userGuess) == firstNumber * secondNumber)
                {
                    score++;
                    Console.WriteLine("Correct answer, Press enter to see next question");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Wrong answer. Press enter to see next question");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void DivisionGame(int numberOfGames)
        {
            int score = 0;
            for (int i = 0; i < numberOfGames; i++)
            {
                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var computerResult = firstNumber / secondNumber;
                var userGuess = Console.ReadLine();
                userGuess = Helpers.Validation(userGuess);

                if (int.Parse(userGuess) == firstNumber / secondNumber)
                {
                    score++;
                    Console.WriteLine("Correct answer, Press enter to see next question");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Wrong answer. Press enter to see next question");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Helpers.AddToHistory(score, GameType.Division);
        }

        internal void QuitGame()
        {
            Console.WriteLine("Are you sure you want to exit?");
            if(Console.ReadLine().Trim().ToLower() == "y") { Environment.Exit(0); };
        }
    }
}
