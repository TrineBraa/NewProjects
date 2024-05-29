using NewProjects;

    Storm storm = new Storm();
    WeatherRoulette roulette = new WeatherRoulette();
    Main();

    void Main()
    {
        bool MainTrue = true;
        while (MainTrue)
        {
            Console.Clear();
            var OriginalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to this random play with C# of repeats of different tasks done before!");
            Console.ForegroundColor = OriginalColor;
            Console.WriteLine(
                "\tI still have a lot to learn, things might change and if you have tips or tricks I will happily accept!");
            Console.WriteLine();
            Console.WriteLine("There will be different options that you can check out and have a look at: ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1) A little pet you can interact with");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2) Weather roulette, choose the right clothes!");

            Console.WriteLine();



            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("0) Exit the app!");
            Console.ForegroundColor = OriginalColor;

            MenuOptions();



            void MenuOptions()
            {
                string Inputs = Console.ReadLine();
                switch (Inputs)
                {
                    case "0":
                    {
                        MainTrue = false;
                        Console.WriteLine("Good bye, see you another time");
                        return;
                    }
                    case "1":
                        storm.ShowStorm();
                        break;
                    case "2":
                        roulette.HowToDress();
                        break;
                    case "3":
                        
                        break;
                    default:
                        Console.WriteLine("Please chose a number from the list!");
                        break;
                }
            }
        }
    }
