namespace Module2_Practice2
{
    public static class SafariParkExtensions
    {
        public static void PrintMaxLifespanAnimals(this SafariPark safariPark)
        {
            if (safariPark.Animals.Length == 0)
            {
                Console.WriteLine("There are no animals in the safari park");

                return;
            }

            int maxAge = safariPark.Animals[0].Lifespan;

            foreach (var animal in safariPark.Animals)
            {
                if (maxAge < animal.Lifespan)
                {
                    maxAge = animal.Lifespan;
                }
            }

            Animal[] longLivers = new Animal[safariPark.Animals.Length];
            int count = 0;

            foreach (var animal in safariPark.Animals)
            {
                if (animal.Lifespan == maxAge)
                {
                    longLivers[count++] = animal;
                }
            }

            Console.WriteLine($"\n\t\t\tAnimals that live the longest life [{count}]:");

            // 'j' is needed not to apply Array.Resize() to cut off null elements
            for (int i = 0; i < count; i++)
            {
                longLivers[i].PrintInfo(safariPark.Printer);
            }
        }

        public static void PrintLessPopulousAnimals(this SafariPark safariPark)
        {
            if (safariPark.Animals.Length == 0)
            {
                Console.WriteLine("There are no animals in the safari park");

                return;
            }

            int minPopulated = safariPark.Animals[0].PopulationNumber;

            foreach (var animal in safariPark.Animals)
            {
                if (minPopulated > animal.PopulationNumber)
                {
                    minPopulated = animal.PopulationNumber;
                }
            }

            Animal[] smallPops = new Animal[safariPark.Animals.Length];
            int count = 0;

            foreach (var animal in safariPark.Animals)
            {
                if (animal.PopulationNumber == minPopulated)
                {
                    smallPops[count++] = animal;
                }
            }

            Console.WriteLine($"\n\t\t\tAnimals that have the lowest population " +
                $"in the safari park [{count}]:");

            // 'count' is needed not to apply Array.Resize() to cut off null elements
            for (int i = 0; i < count; i++)
            {
                smallPops[i].PrintInfo(safariPark.Printer);
            }
        }

        // method combines printing animals FROM Africa and NOT FROM Africa
        public static void PrintAnimalsFromContinent(this SafariPark safariPark, bool fromAfrica)
        {
            if (safariPark.Animals.Length == 0)
            {
                Console.WriteLine("There are no animals in the safari park");

                return;
            }

            Animal[] animals = new Animal[safariPark.Animals.Length];
            int count = 0;

            Continent africa = Continent.Africa;

            foreach (var animal in safariPark.Animals)
            {
                foreach (var continent in animal.Continents)
                {
                    if (fromAfrica)
                    {
                        if (continent == africa)
                        {
                            animals[count++] = animal;
                        }
                    }
                    else
                    {
                        if (continent != africa)
                        {
                            animals[count++] = animal;

                            // needed cuz we may have duplicates since one animal from
                            // Asia & NorthAmerica will be counted as 2 different animals
                            break;
                        }
                    }
                }
            }

            if (fromAfrica)
            {
                Console.WriteLine($"\n\t\t\tAnimals from Africa [{count}]:");
            }
            else
            {
                Console.WriteLine($"\n\t\t\tAnimals not from Africa [{count}]:");
            }

            // 'count' is needed not to apply Array.Resize() to cut off null elements
            for (int i = 0; i < count; i++)
            {
                animals[i].PrintInfo(safariPark.Printer);
            }
        }
    }
}
