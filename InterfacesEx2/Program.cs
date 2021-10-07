using System;

namespace InterfacesEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Dog = new Animal();
            Dog.species = "dog";
            Dog.talk = "bark";

            Animal Cat =  new Animal();
            Cat.species = "cat";
            Cat.talk = "meow";

            Animal Cow = new Animal();
            Cow.species = "cow";
            Cow.talk = "moo";

            Animal Sheep = new Animal();
            Sheep.species = "sheep";
            Sheep.talk = "bah";

            Animal Duck = new Animal();
            Duck.species = "duck";
            Duck.talk = "quack";


            while (true)
            {
                Console.WriteLine("Choose an animal (1 to 5) and the application will display it's voice.");
                Console.WriteLine("1 - Dog \n2 - Cat \n3 - Cow \n4 - Sheep \n5 - Duck \n0 - Quit");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Dog.Talk();
                        Console.WriteLine("Press any key to continue. . .");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Cat.Talk();
                        Console.WriteLine("Press any key to continue. . .");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Cow.Talk();
                        Console.WriteLine("Press any key to continue. . .");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "4":
                        Sheep.Talk();
                        Console.WriteLine("Press any key to continue. . .");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "5":
                        Duck.Talk();
                        Console.WriteLine("Press any key to continue. . .");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Please insert a valid input. . .");
                        break;
                }
            }
        }
    }
}
