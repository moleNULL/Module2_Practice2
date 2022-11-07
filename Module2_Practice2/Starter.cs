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
            safariPark.AddAnimals(CreateMoreAnimals());

            safariPark.PrintAnimals();

            SortByUserChoice(safariPark);
            safariPark.PrintAnimals();

            PrintUserFindChoice(safariPark);

            if (AskIfNeedToPrintToFile())
            {
                string path = AskFilePath();
                safariPark.Printer = new FilePrinter(path);

                safariPark.PrintAnimals();
                Console.WriteLine($"\tData has been successfully written into {path}");

                safariPark.Printer = new ConsolePrinter(); // set default printer
            }

            // написать комментарии
            // проверить все файлы проекта

            /*
            // safariPark.Printer = new FilePrinter("animals.txt");
            safariPark.PrintFirstAnimal();
            safariPark.PrintLastAnimal();*/
        }

        // Create more animals for safari park
        private static Animal[] CreateMoreAnimals()
        {
            var snake = new Snake(name: "Common European Viper", populationNumber: 23, lifespan: 10, isPoisonous: true, continents: new Continent[] { Continent.Europe });
            var bird = new Bird(name: "American Flamingo", canFly: true, populationNumber: 16, lifespan: 49, continents: new Continent[] { Continent.SouthAmerica });

            return new Animal[] { snake, bird };
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

        // Ask user if it is needed to print animals to a file
        private static bool AskIfNeedToPrintToFile()
        {
            while (true)
            {
                Console.Write("\n\nDo you want to print all animals to file? (y/n): ");
                string? answer = Console.ReadLine();

                switch (answer)
                {
                    case "y":
                        return true;
                    case "n":
                        return false;
                    default:
                        continue;
                }
            }
        }

        // Ask user about filepath to the file to print data into
        private static string AskFilePath()
        {
            while (true)
            {
                Console.Write("FilePath: ");
                string? filePath = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(filePath))
                {
                    continue;
                }

                return filePath;
            }
        }
    }
}
