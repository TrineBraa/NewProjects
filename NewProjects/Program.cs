using NewProjects;

Storm storm = new Storm();
Main();
void Main()
{
    var OriginalColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Welcome to this random play with C# of repeats of different tasks done before!");
    Console.ForegroundColor = OriginalColor;
    Console.WriteLine("\tI still have a lot to learn, things might change and if you have tips or tricks I will happily accept!");
    Console.WriteLine();
    Console.WriteLine("There will be different options that you can check out and have a look at: ");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("1) A little pet you can interact with");
   

    MenuOptions();
}


void MenuOptions()
{
    string Inputs = Console.ReadLine();
    switch (Inputs)
    {
        case "1":
            storm.ShowStorm();
            break;
        case "2":
            break;
        case "3":
            break;
        default:
            Main();
            break;
    }
}