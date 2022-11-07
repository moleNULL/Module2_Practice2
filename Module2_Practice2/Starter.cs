namespace Module2_Practice2
{
    public class Starter
    {
        public static void Run()
        {
            Console.WriteLine("\t\t\t\t\t\t\tSafari park:\n");

            SafariPark safariPark = new SafariPark();
            safariPark.PopulateByDefault();
            safariPark.Printer = new ConsolePrinter(); // Output to Console for SafariPark class
            safariPark.PrintAnimals();

            SortByUserChoice(safariPark);
            safariPark.PrintAnimals();

            PrintUserFindChoice(safariPark);

            // сделать возможность добавления += Animal[]
            // написать комментарии
            // проверить все файлы проекта

            /*var snake = new Snake(name: "Common European Viper", populationNumber: 23, lifespan: 10, isPoisonous: true, continents: new string[] { "Europe" });
            var bird = new Bird(name: "American Flamingo", canFly: true, populationNumber: 16, lifespan: 49, continents: new string[] { "South America" });

            safariPark.Animals = new Animal[] { snake, bird };

            // safariPark.Printer = new FilePrinter("animals.txt");
            safariPark.PrintFirstAnimal();
            safariPark.PrintLastAnimal();*/
        }

        // Ask user how to sort animals in the enclosure of the safari park
        private static void SortByUserChoice(SafariPark safariPark)
        {
            while (true)
            {
                Console.Write("\nSort animals by:\n 1. Lifespan\n " +
                    "2. Population number\nChoice: ");
                string? sortAnswer = Console.ReadLine();

                switch (sortAnswer)
                {
                    case "1":
                        safariPark.SortByLifespan();
                        Console.WriteLine("\n\t\t\tSorted by [Lifespan] in ascending order:");
                        break;
                    case "2":
                        safariPark.SortByPopulationNumber();
                        Console.WriteLine("\n\t\t\tSorted by [PopulationNumber] in ascending order:");
                        break;
                    default:
                        Console.WriteLine("Error! Only 1 or 2 is a valid answer");
                        continue;
                }

                break;
            }
        }

        // Ask user what animals to find in the enclosure of the safari park
        private static void PrintUserFindChoice(SafariPark safariPark)
        {
            while (true)
            {
                Console.Write("\nFind animals by:" +
                    $"\n 1. Long life" +
                    "\n 2. Less populous\n 3. Only from Africa\n 4. Not from Africa" +
                    "\nChoice: ");
                string? findAnswer = Console.ReadLine();

                switch (findAnswer)
                {
                    case "1":
                        safariPark.PrintMaxLifespanAnimals();
                        break;
                    case "2":
                        safariPark.PrintLessPopulousAnimals();
                        break;
                    case "3":
                        safariPark.PrintAnimalsFromContinent(fromAfrica: true);
                        break;
                    case "4":
                        safariPark.PrintAnimalsFromContinent(fromAfrica: false);
                        break;
                    default:
                        Console.WriteLine("Error! Only 1, 2, 3, or 4 is a valid answer");
                        continue;
                }

                break;
            }
        }
    }
}
