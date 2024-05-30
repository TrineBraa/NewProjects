

using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace NewProjects
{
    public class WeatherRoulette
    {

        public void HowToDress()
        {
            string[] Weather = new[]
            {
                "It is bright and sunny!",
                "It's cold and windy :(",
                "There is a rainstorm outside!",
                "There is thunder and Lightning today!",
                "It's snowing and so very cold!",
            };

            string[] Clothes = new[]
            {
                "How about a dress or shorts and t-shirt!",
                "Best put on some trousers and a jacket today!",
                "I will find my rain coat and boots to stay dry!",
                "Today is an inside day with a cup of tea, watching the weather!",
                "I think I will need my winter coat with a hat and mittens today!",
            };

            while (true)
            {
                
                Random RndNum = new Random();
                int Selector = RndNum.Next(0, 5);
                string RandWeather = Weather[Selector];


                Console.Clear();

                var OriginalColor = Console.ForegroundColor;
                Console.WriteLine("\nHave a look at today's weather");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($" \tToday's Weather: {RandWeather}");
                Console.ForegroundColor = OriginalColor;
                Console.WriteLine("\nWhat is today's Adventuring attire?");

                
                for (int i = 0; i < Clothes.Length; i++)
                {
                    Console.WriteLine(" \t" + i + ". " + Clothes[i]);
                }
                Console.WriteLine("\t5. To return to main menu");

               
                int UserInput = int.Parse(Console.ReadLine());
                int PutOn = UserInput - 0;

                while (PutOn > 5){
                    PutOn = UserInput - 0;
                    if (PutOn > 5)
                    {
                        Console.WriteLine("Invalid option");
                        break;
                    }
                }


                if (UserInput == 5)
                {
                    break;
                }


                if (UserInput == 0)
                {
                    switch (PutOn)
                    {
                        case 0:
                            Console.WriteLine("Perfect for this warm weather!");
                            Thread.Sleep(2000);
                            break;
                        case 1:
                            Console.WriteLine("It might be a bit to warm for that!");
                            Thread.Sleep(2000);
                            break;
                        case 2:
                            Console.WriteLine("It's not the best wear for a day like today!");
                            Thread.Sleep(2000);
                            break;
                        case 3:
                            Console.WriteLine("You want to sit inside on a day like this?!");
                            Thread.Sleep(2000);
                            break;
                        case 4:
                            Console.WriteLine("That is definitely to hot!");
                            Thread.Sleep(2000);
                            break;
                    }
                }
                else if (UserInput == 1)
                {
                    switch (PutOn)
                    {
                        case 0:
                            Console.WriteLine("It will be a bit chilly!");
                            Thread.Sleep(2000);
                            break;
                        case 1:
                            Console.WriteLine("Perfect, won't be to cold or to warm like this!");
                            Thread.Sleep(2000);
                            break;
                        case 2:
                            Console.WriteLine("Not quite fitting for this weather.");
                            Thread.Sleep(2000);
                            break;
                        case 3:
                            Console.WriteLine("it's not that bad, you'll be okay to go out!");
                            Thread.Sleep(2000);
                            break;
                        case 4:
                            Console.WriteLine("You will be quite warm in that, not the best idea!");
                            Thread.Sleep(2000);
                            break;
                    }
                }
                else if (UserInput == 2)
                {
                    switch (PutOn)
                    {
                        case 0:
                            Console.WriteLine("You will be quite wet and miserable like this today!");
                            Thread.Sleep(2000);
                            break;
                        case 1:
                            Console.WriteLine("it's okay, tho You'd still be cold and rather wet.");
                            Thread.Sleep(2000);
                            break;
                        case 2:
                            Console.WriteLine("IThat is a great idea! you'll stay dry and comfortable!");
                            Thread.Sleep(2000);
                            break;
                        case 3:
                            Console.WriteLine("Not a bad idea, but it's not that bad that you need to stay in!!");
                            Thread.Sleep(2000);
                            break;
                        case 4:
                            Console.WriteLine("you will be very warm, wet and the clothes will be so heavy...");
                            Thread.Sleep(2000);
                            break;
                    }
                }
                else if (UserInput == 3)
                {
                    switch (PutOn)
                    {
                        case 0:
                            Console.WriteLine("Definitely not the best wear for today....");
                            Thread.Sleep(2000);
                            break;
                        case 1:
                            Console.WriteLine("it's not very fitting for today..");
                            Thread.Sleep(2000);
                            break;
                        case 2:
                            Console.WriteLine("That is great, you'll stay dry, tho with a storm like this, maybe not?");
                            Thread.Sleep(2000);
                            break;
                        case 3:
                            Console.WriteLine("Sounds like such a great idea, find a book and chill!");
                            Thread.Sleep(2000);
                            break;
                        case 4:
                            Console.WriteLine("Not today, the rain will soak you and might ruin your winter clothes!");
                            Thread.Sleep(2000);
                            break;
                    }
                }
                else if (UserInput == 4)
                {
                    switch (PutOn)
                    {
                        case 0:
                            Console.WriteLine("You want to turn into an ice cube???");
                            Thread.Sleep(2000);
                            break;
                        case 1:
                            Console.WriteLine("it's not the attire for winter, go change!");
                            Thread.Sleep(2000);
                            break;
                        case 2:
                            Console.WriteLine("That isn't going to keep you warm at all..");
                            Thread.Sleep(2000);
                            break;
                        case 3:
                            Console.WriteLine("not a bad idea, but the world doesn't stop even when it snows!");
                            Thread.Sleep(2000);
                            break;
                        case 4:
                            Console.WriteLine("Perfect, warm and comfortable in the snow! ");
                            Thread.Sleep(2000);
                            break;
                    }
                }
                else if (UserInput == 5)
                {
                    break;
                }
                


            }
        }
    }
}
