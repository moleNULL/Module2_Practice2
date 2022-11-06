using Module2_Practice2.Sorters;

namespace Module2_Practice2
{
    public class SafariPark
    {
        private Enclosure _enclosure;

        public SafariPark()
        {
            _enclosure = new Enclosure();
            Printer = new ConsolePrinter(); // printer by default is Console
        }

        public IPrinter Printer { get; set; }

        public Animal[] Animals
        {
            get
            {
                return _enclosure.Animals;
            }

            set
            {
                if (value != null)
                {
                    _enclosure.Animals = value;
                }
                else
                {
                    Console.WriteLine("Error! Animals cannot be initialized with null");
                }
            }
        }

        public void PrintAnimals()
        {
            _enclosure.PrintAnimals(Printer);
        }

        public void PrintFirstAnimal()
        {
            _enclosure.PrintFirstAnimal(Printer);
        }

        public void PrintLastAnimal()
        {
            _enclosure.PrintLastAnimal(Printer);
        }

        public void SortByLifespan()
        {
            Animal[] animals = _enclosure.Animals;

            new LifespanSorter().Sort(ref animals);

            _enclosure.Animals = animals; // Property cannot be passed as a ref parameter
        }

        public void SortByPopulationNumber()
        {
            Animal[] animals = _enclosure.Animals;
            new PopulationSorter().Sort(ref animals);

            _enclosure.Animals = animals;
        }

        // Create initial animals
        public void PopulateByDefault()
        {
            var ostrich = new SomaliOstrich(populationNumber: 102);
            var africanMarabou = new AfricanMarabou(populationNumber: 225);
            var sumatranOrangutan = new SumatranOrangutan(populationNumber: 2);
            var lion = new Lion(populationNumber: 35);
            var americanAlligator = new AmericanAlligator(populationNumber: 16);
            var taipan = new CoastalTaipan(populationNumber: 7);

            var animals = new Animal[] { ostrich, africanMarabou, sumatranOrangutan, lion, americanAlligator, taipan };

            _enclosure.Animals = animals;
        }
    }
}
