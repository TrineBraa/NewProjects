

namespace NewProjects
{
    internal class GuessNumber
    {
            public void GuessingGame()
            {

                Random Rnd = new Random();
                int Number = Rnd.Next(1, 100);
                int SavedNumber = Number;
            while (true)
                {
                    var OriginalColor = Console.ForegroundColor;
                   
                    int UserInput = Convert.ToInt32(Console.ReadLine());

           
                    Console.WriteLine("Guess the number game!");
                    Console.WriteLine(
                        "\tThis game is for you to guess what the secret number is! \n\tYou can guess from 1 to 100, so take a guess!");
                    Console.WriteLine();
                    Console.WriteLine("Press x to exit the game and return to main menu!");
                    Console.WriteLine();
                    Console.WriteLine();
                    if (UserInput == 'x')
                    {
                        break;
                    }
                    
                    if (UserInput > SavedNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\tThat is too high! \nGuess again!");
                        Console.ForegroundColor = OriginalColor;
                    }
                    else if (UserInput < SavedNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\t That is to low! \nGuess again!");
                        Console.ForegroundColor = OriginalColor;
                    }
                    else if (UserInput == SavedNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\t Correct Number! \nYou want to play again? (Y/N)");
                        string Replay = Console.ReadLine().ToUpper();
                        Console.ForegroundColor = OriginalColor;

                        if (Replay == "Y")
                        {
                            GuessingGame();
                        }else if (Replay == "N")
                        { break; };
                    }
                    





                }
            }
    }
}
