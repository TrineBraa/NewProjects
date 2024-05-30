

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
                   

           
                    Console.WriteLine("Guess the number game!");
                    Console.WriteLine(
                        "\tThis game is for you to guess what the secret number is! " +
                        "\n\tYou can guess from 1 to 100, so take a guess!");
                    Console.WriteLine();
                    Console.WriteLine("Press 0 to exit the game and return to main menu!");
                    Console.WriteLine();
                    Console.WriteLine();


                    int UserInput = Convert.ToInt32(Console.ReadLine());

                    if (UserInput == 0)
                    {
                        break;
                    }

                    if (UserInput == 1000)
                    {
                        GuessingGame();
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
                        Console.WriteLine("\t Correct Number! \nYou want to play again? (1000 =yes / 0 = no");
                        Console.ForegroundColor = OriginalColor;

                    }
                    





                }
            }
    }
}
