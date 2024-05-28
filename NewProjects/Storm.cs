
namespace NewProjects
{
    public class Storm
    {
        public int _hunger;
        public int _happiness;
        public int _cleanliness;

        public Storm(int Hunger = 50, int Happiness = 50, int Cleanliness = 50)
        {
            _hunger = Hunger;
            _happiness = Happiness;
            _cleanliness = Cleanliness;
        }

        public void FeedStorm()
        {
            Console.WriteLine("Storm is so happy about getting food, he is so hungry!");
            _hunger += 30;
            _happiness -= 10;
            _cleanliness -= 20;
            Thread.Sleep(1000);
        }

        public void CleanStorm()
        {
            Console.WriteLine("You gave Storm a bath, he hates it and is unhappy.");
            _cleanliness += 30;
            _hunger -= 10;
            _happiness -= 20;
            Thread.Sleep(1000);
        }

        public void PetStorm()
        {
            Console.WriteLine("You pet Storm, He is so happy and wags his tail excitedly!");
            _hunger -= 20;
            _cleanliness -= 10;
            _happiness += 30;
            Thread.Sleep(1000);
        }

        public void StormNeed()
        {
            Console.WriteLine($"Hunger: {_hunger}");
            Console.WriteLine($"Cleanliness: {_cleanliness}");
            Console.WriteLine($"Happiness: {_happiness}");
        }


        public void ShowStorm()
        {
            while (true)
            {
                Console.WriteLine("Storm is a happy boy!");
                Console.WriteLine("\tStorm has different needs you have to care for!");
                Console.WriteLine();
                StormNeed();
                Console.WriteLine();
                Console.WriteLine("You can choose what you want to take care of");
                Console.WriteLine("\t1. Feed Storm, you will make him very happy!");
                Console.WriteLine("\t2. Clean him, he is a dirty boi!");
                Console.WriteLine("\t3. Pet him, He loves pets and cuddles");
                Console.WriteLine("\t4. Return to main menu");


                int UserInput = Console.Read();
                if (UserInput == 1)
                {
                    Console.Clear();
                    FeedStorm();
                    StormNeed();
                }
                else if (UserInput == 2)
                {
                    Console.Clear();
                    CleanStorm();
                    StormNeed();
                }
                else if (UserInput == 3)
                {
                    Console.Clear();
                    PetStorm();
                    StormNeed();
                }
                else if (UserInput == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please write one of the listed numbers number!");
                }

            }

        }



    }
}
