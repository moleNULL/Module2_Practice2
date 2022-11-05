namespace Module2_Practice2
{
    public class Starter
    {
        public static void Run()
        {
            // Output to Console for SafariPark class
            ConsolePrinter consolePrinter = new ConsolePrinter();

            Animal[] animals = PopulatePark();

            SafariPark safariPark = new SafariPark(animals);
            safariPark.PrintAnimals(consolePrinter);
        }

        // Create initial animals
        private static Animal[] PopulatePark()
        {
            var ostrich = new SomaliOstrich(populationNumber: 102);
            var africanMarabou = new AfricanMarabou(populationNumber: 625);
            var sumatranOrangutan = new SumatranOrangutan(populationNumber: 2);
            var lion = new Lion(populationNumber: 35);

            var animals = new Animal[] { ostrich, africanMarabou, sumatranOrangutan, lion };

            return animals;
        }
    }
}
